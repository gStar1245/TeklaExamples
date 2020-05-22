using System.Collections.Generic;
using System.Windows.Forms;

using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Solid;
using TSSolid = Tekla.Structures.Solid;
using Tekla.Structures.Model.UI;
using Point = Tekla.Structures.Geometry3d.Point;

namespace CNCSolideExamle
{
    class CNCSolidLogic
    {
        internal static void GetParts(ref Dictionary<Plane, Face> FirstBeamPlanes, ref Dictionary<Plane, Face> SecondaryBeamPlanes)
        {
            Picker picker = new Picker();

            Part Part1 = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART) as Part;
            Part Part2 = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART) as Part;

            if (Part1 != null && Part2 != null)
            {
                Solid Solid1 = Part1.GetSolid(Solid.SolidCreationTypeEnum.RAW);
                FirstBeamPlanes = GetGeometricPlane(Solid1);

                Solid Solid2 = Part2.GetSolid(Solid.SolidCreationTypeEnum.RAW);
                SecondaryBeamPlanes = GetGeometricPlane(Solid2);
            }
        }

        internal static Dictionary<Plane, Face> GetGeometricPlane(Solid solid)
        {
            FaceEnumerator FaceEnum = solid.GetFaceEnumerator();
            Dictionary<Plane, Face> Planes = new Dictionary<Plane, Face>();

            while (FaceEnum.MoveNext())
            {
                List<Point> PlaneVertexes = new List<Point>();

                Face face = FaceEnum.Current as Face;

                LoopEnumerator Loops = face.GetLoopEnumerator();

                while (Loops.MoveNext())
                {
                    Loop loop = Loops.Current as Loop;
                    VertexEnumerator vertexes = loop.GetVertexEnumerator();

                    while (vertexes.MoveNext())
                    {
                        Point Vertex = vertexes.Current as Point;
                        if (!PlaneVertexes.Contains(Vertex))
                        {
                            if (PlaneVertexes.Count != 3 || (PlaneVertexes.Count == 3 && !ArePointAligned(PlaneVertexes[0], PlaneVertexes[1], Vertex)))
                                PlaneVertexes.Add(Vertex);

                            if (PlaneVertexes.Count == 3)
                            {
                                Vector Vector1 = new Vector(PlaneVertexes[1].X - PlaneVertexes[0].X, PlaneVertexes[1].Y - PlaneVertexes[0].Y,
                                                            PlaneVertexes[1].Z - PlaneVertexes[0].Z);
                                Vector Vector2 = new Vector(PlaneVertexes[2].X - PlaneVertexes[0].X, PlaneVertexes[2].Y - PlaneVertexes[0].Y,
                                                            PlaneVertexes[2].Z - PlaneVertexes[0].Z);

                                Plane plane = new Plane
                                {
                                    Origin = PlaneVertexes[0],
                                    AxisX = Vector1,
                                    AxisY = Vector2
                                };
                                Planes.Add(plane, face);
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            return Planes;
        }

        internal static bool ArePointAligned(Point Point1, Point Point2, Point Point3)
        {
            Vector Vector1 = new Vector(Point2.X - Point1.X, Point2.Y - Point1.Y, Point2.Z - Point1.Z);
            Vector Vector2 = new Vector(Point3.X - Point1.X, Point3.Y - Point3.Y, Point3.Z - Point1.Z);

            return Parallel.VectorToVector(Vector1, Vector2);
        }

        internal static List<Face> CompareNormals(Dictionary<Plane, Face> FirstBeamNormals, Dictionary<Plane, Face> SecondaryBeamNormals, double MaximumOffset)
        {
            List<Face> Faces = new List<Face>();

            foreach(Plane Plane in FirstBeamNormals.Keys)
            {
                foreach(Plane PlaneToCompare in SecondaryBeamNormals.Keys)
                {
                    Vector PlaneNormal = Vector.Cross(Plane.AxisX, Plane.AxisY);
                    Vector PlaneToCompareNormal = Vector.Cross(PlaneToCompare.AxisX, PlaneToCompare.AxisY);

                    if(Vector.Dot(PlaneNormal.GetNormal(), PlaneToCompareNormal.GetNormal()) == -1)
                    {
                        GeometricPlane GeometricPlane = new GeometricPlane(PlaneToCompare.Origin, PlaneToCompareNormal);
                        double distance = Distance.PointToPlane(Plane.Origin, GeometricPlane);

                        if(distance <= MaximumOffset)
                        {
                            DrawMesh(Plane);
                            Faces.Add(FirstBeamNormals[Plane]);
                        }
                    }
                }
            }
            return Faces;
        }

        private static void DrawMesh(Plane plane)
        {
            GraphicsDrawer graphicsDrawer = new GraphicsDrawer();

            Mesh mesh = new Mesh();
            Point Point1 = new Point(plane.Origin);

            Vector NormalX = plane.AxisX.GetNormal() * 300;

            Point Point2 = new Point(plane.Origin);
            Point2.Translate(NormalX.X, NormalX.Y, NormalX.Z);

            Vector NormalY = plane.AxisY.GetNormal() * 300;

            Point Point3 = new Point(plane.Origin);
            Point3.Translate(NormalY.X, NormalY.Y, NormalY.Z);

            Point Point4 = new Point(Point2);
            Point4.Translate(NormalY.X, NormalY.Y, NormalY.Z);

            mesh.AddPoint(Point1);
            mesh.AddPoint(Point2);
            mesh.AddPoint(Point3);
            mesh.AddPoint(Point4);

            mesh.AddTriangle(0, 1, 2);
            mesh.AddTriangle(2, 1, 0);
            mesh.AddTriangle(1, 2, 3);
            mesh.AddTriangle(3, 2, 1);

            graphicsDrawer.DrawMeshSurface(mesh, new Color(1, 0, 0));
        }
    }
}
