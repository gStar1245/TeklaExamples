using System;
using System.Collections;
using System.IO;
using System.Xml;

using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Solid;
using Tekla.Structures.Model;
using TSMUI = Tekla.Structures.Model.UI;

namespace ExportXML
{
    class WriteXmlFileSample
    {
        private const string document = "C:\\TeklaStructuresPartnerModels\\Example";

        [STAThread]
        static void Main(string[] args)
        {
            WriteXmlFileSample writeXmlFileSample = new WriteXmlFileSample();
            writeXmlFileSample.Run(document);
        }

        public void Run(String args)
        {
            XmlTextWriter myXmlTextWriter = null;
            int Count = 0;
            int AssemblyId = 0;
            long TotalTime = 0;
            long ElapsedTime = 0;
            long StartTicks = DateTime.Now.Ticks;

            try
            {
                ArrayList listOfPieces = new ArrayList();
                Model myModel = new Model();

                ModelObjectEnumerator myEnum = new TSMUI.ModelObjectSelector().GetSelectedObjects();

                myXmlTextWriter = new XmlTextWriter(args, null);
                myXmlTextWriter.Formatting = Formatting.Indented;
                myXmlTextWriter.WriteStartDocument(false);
                myXmlTextWriter.WriteComment("This file is just a sample output from Tekla Structures");
                myXmlTextWriter.WriteStartElement("project");
                StartTicks = DateTime.Now.Ticks;

                while(myEnum.MoveNext())
                {
                    Part myPart = myEnum.Current as Part;
                    if((myPart != null) && (myPart.GetReportProperty("ASSEMBLY.ID", ref AssemblyId)) &&
                        !listOfPieces.Contains(AssemblyId.ToString()))
                    {
                        WritePiece(myXmlTextWriter, myPart, myModel);
                        listOfPieces.Add(AssemblyId.ToString());
                        ++Count;
                        ElapsedTime = (DateTime.Now.Ticks - StartTicks) / 10000;
                        Console.WriteLine("{0} : {1} ({2} msecs)", Count, AssemblyId.ToString(), ElapsedTime);
                        TotalTime += ElapsedTime;
                        StartTicks = DateTime.Now.Ticks;
                    }
                    
                }
                myXmlTextWriter.WriteEndElement();

                myXmlTextWriter.Flush();
                myXmlTextWriter.Close();
                ElapsedTime = (DateTime.Now.Ticks - StartTicks) / 10000;
                Console.WriteLine("Writing xml-file : {0} msecs", ElapsedTime);
                TotalTime += ElapsedTime;

            }
            catch (Exception Ex)
            {
                Console.WriteLine("Exceptioni : {0}",Ex.ToString());
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("Totally {0} pieces exported.", Count);
                Console.WriteLine("Totla time spent : {0} seconds", (float)TotalTime / 1000);
                Console.WriteLine("Processing of the file {0} complete.", args);
                Console.WriteLine("\nPress enter ...");
                Console.Read();
                if (myXmlTextWriter != null)
                    myXmlTextWriter.Close();
            }
        }

        private void WritePiece(XmlTextWriter writer, Part part, Model model)
        {
            string Mark = "";
            string Comment = "";
            double Width = 0;
            double Height = 0;
            double Length = 0;
            double Weight = 0;
            double Volume = 0;
            Assembly Piece = part.GetAssembly();

            if (Piece != null)
            {
                // Get some data for Assembly
                Piece.GetReportProperty("CAST_UNIT_POS", ref Mark);
                Piece.GetReportProperty("comment", ref Comment);
                Piece.GetReportProperty("WIDTH", ref Width);
                Piece.GetReportProperty("HEIGHT", ref Height);
                Piece.GetReportProperty("LENGTH", ref Length);
                Piece.GetReportProperty("WEIGHT", ref Weight);
                Piece.GetReportProperty("CAST_UNIT_VOLUME", ref Volume);

                // Write data to XML file
                writer.WriteStartElement("assembly", null);
                writer.WriteAttributeString("id", Piece.Identifier.ID.ToString());
                writer.WriteAttributeString("mark", Mark);
                writer.WriteElementString("name", part.Name);
                writer.WriteElementString("material", part.Material.MaterialString);
                writer.WriteElementString("weight", Weight.ToString("######"));
                writer.WriteElementString("volumne : ", Volume.ToString("###.##"));
                writer.WriteElementString("length : ", Length.ToString("#####."));
                writer.WriteElementString("profile", null);
                writer.WriteElementString("name", part.Profile.ProfileString);
                writer.WriteElementString("widhth", Width.ToString("#####."));
                writer.WriteElementString("height", Height.ToString("#####."));
                writer.WriteEndElement();
                WriteGeometry(writer, Piece, model);
                WriteEmbeds(writer, Piece);
                WriteHoles(writer, Piece, model);
                writer.WriteEndElement();
            }
        }

        private void WriteGeometry(XmlTextWriter writer, Assembly piece, Model model )
        {
            Part mainPart = piece.GetMainPart() as Part;
            ArrayList aList = piece.GetSecondaries();

            WriteGeometry(writer, mainPart, model);
            foreach(ModelObject mo in aList)
            {
                Part MyPart = mo as Part;
                if (MyPart != null)
                    WriteGeometry(writer, MyPart, model);
            }
        }

        private void WriteGeometry(XmlTextWriter writer, Part part, Model myModel)
        {
            if (part != null)
            {
                WorkPlaneHandler planeHandler = myModel.GetWorkPlaneHandler();
                TransformationPlane CurrentPlane = planeHandler.GetCurrentTransformationPlane();

                writer.WriteStartElement("Part", null);
                writer.WriteAttributeString("id", part.Identifier.ID.ToString());
                writer.WriteElementString("name", part.Name);
                writer.WriteElementString("material", part.Material.MaterialString);
                writer.WriteStartElement("profile", null);
                writer.WriteElementString("name", part.Profile.ProfileString);
                writer.WriteEndElement();

                Solid solid = part.GetSolid() as Solid;
                FaceEnumerator myFaceEnum = solid.GetFaceEnumerator();
                writer.WriteStartElement("Solid", null);
                while(myFaceEnum.MoveNext())
                {
                    Face myFace = myFaceEnum.Current as Face;
                    if(myFace != null)
                    {
                        writer.WriteStartElement("Face", null);
                        LoopEnumerator myLoopEnum = myFace.GetLoopEnumerator();
                        while(myLoopEnum.MoveNext())
                        {
                            Loop myLoop = myLoopEnum.Current as Loop;
                            if( myLoop != null)
                            {
                                writer.WriteStartElement("Loop", null);
                                VertexEnumerator myVertexEnum = myLoop.GetVertexEnumerator() as VertexEnumerator;
                                while(myVertexEnum.MoveNext())
                                {
                                    Point myVertex = myVertexEnum.Current as Point;
                                    if (myVertex != null)
                                    {
                                        writer.WriteStartElement("Vertex", null);
                                        writer.WriteElementString("X", myVertex.X.ToString("#.##"));
                                        writer.WriteElementString("Y", myVertex.Y.ToString("#.##"));
                                        writer.WriteElementString("Z", myVertex.Z.ToString("#.##"));
                                        writer.WriteEndElement(); // End Vertex
                                    }
                                }
                                writer.WriteEndElement(); // End Loop
                            }
                        }
                        writer.WriteEndElement(); //  End Face
                    }
                }
                writer.WriteEndElement(); // End Solid

                planeHandler.SetCurrentTransformationPlane(CurrentPlane);
                writer.WriteEndElement();
            }
        }

        private void WriteCoordSys(XmlTextWriter writer, CoordinateSystem CoordSys)
        {
            writer.WriteStartElement("CoordSys", null);
            WritePoint(writer, "Origin", CoordSys.Origin);
            WritePoint(writer, "AxisX", CoordSys.AxisX);
            WritePoint(writer, "AxisY", CoordSys.AxisY);
            writer.WriteEndElement();
        }

        private void WritePoint(XmlTextWriter writer, string name, Point point)
        {
            writer.WriteStartElement(name, null);
            writer.WriteElementString("X", point.X.ToString("#.##"));
            writer.WriteElementString("Y", point.Y.ToString("#.##"));
            writer.WriteElementString("Z", point.Z.ToString("#.##"));
            writer.WriteEndElement();
        }

        private void WriteEmbeds(XmlTextWriter writer, Assembly piece)
        {
            ArrayList aList = piece.GetSubAssemblies();

            foreach(Assembly myEmbed in aList)
            {
                Part myPart = myEmbed.GetMainPart() as Part;
                if (myPart != null)
                {
                    writer.WriteStartElement("embed", null);
                    writer.WriteElementString("name", myPart.Name);
                    writer.WriteElementString("material", myPart.Material.MaterialString);
                    writer.WriteElementString("finish", myPart.Finish);
                    writer.WriteElementString("Class", myPart.Class);
                    writer.WriteEndElement();
                }
            }
        }

        private void WriteHoles(XmlTextWriter writer, Assembly piece, Model model)
        {
            Part mainPart = piece.GetMainPart() as Part;
            ArrayList aList = piece.GetSecondaries();

            WriteHoles(writer, mainPart);
            WriteBolts(writer, mainPart, model);
            foreach(ModelObject mo in aList)
            {
                Part myPart = mo as Part;
                if(myPart != null)
                {
                    WriteHoles(writer, myPart);
                    WriteBolts(writer, myPart, model);
                }
            }
        }

        private void WriteHoles(XmlTextWriter writer, Part part)
        {
            if(part !=null)
            {
                ModelObjectEnumerator myHoleEnum = part.GetChildren();
                while(myHoleEnum.MoveNext())
                {
                    BooleanPart myHole = myHoleEnum.Current as BooleanPart;
                    if(myHole != null)
                    {
                        double Width = 0;
                        double Height = 0;

                        myHole.GetReportProperty("WIDTH", ref Width);
                        myHole.GetReportProperty("HEIGHT", ref Height);

                        writer.WriteStartElement("hole", null);
                        writer.WriteAttributeString("id", myHole.Identifier.ID.ToString());
                        writer.WriteElementString("width", Width.ToString("#####."));
                        writer.WriteElementString("height", Height.ToString("#####."));
                        writer.WriteEndElement();
                    }
                }
            }
        }

        private void WriteBolts(XmlTextWriter writer, Part part, Model myModel)
        {
            if(part != null)
            {
                ModelObjectEnumerator myBoltEnum = part.GetBolts();

                while (myBoltEnum.MoveNext())
                {
                    BoltArray myBolt = myBoltEnum.Current as BoltArray;

                    writer.WriteStartElement("Bolt", null);
                    writer.WriteAttributeString("id", myBolt.Identifier.ID.ToString());

                    WorkPlaneHandler planeHandler = myModel.GetWorkPlaneHandler();
                    TransformationPlane currentPlane = planeHandler.GetCurrentTransformationPlane();


                    CoordinateSystem bCoordSys = myBolt.GetCoordinateSystem();
                    TransformationPlane BoltPlane = new TransformationPlane(bCoordSys);
                    planeHandler.SetCurrentTransformationPlane(BoltPlane);
                    myBolt.Select();

                    CoordinateSystem bCoordSys1 = myBolt.GetCoordinateSystem();

                    WriteCoordSys(writer, bCoordSys1);

                    writer.WriteStartElement("BoltPositions", null);
                    foreach (Point p in myBolt.BoltPositions)
                        writer.WriteElementString("Bolt position", p.ToString());

                    writer.WriteEndElement();

                    writer.WriteEndElement();

                    planeHandler.SetCurrentTransformationPlane(currentPlane);
                }
            }
        }

    }
}
