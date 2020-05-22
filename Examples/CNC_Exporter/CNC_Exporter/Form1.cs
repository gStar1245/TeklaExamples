using System;
using System.IO;
using System.Windows.Forms;

using Tekla.Structures;
using Tekla.Structures.Model;
using TSMO = Tekla.Structures.Model.Operations;

namespace CNC_Exporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BtnExportScript.Click += BtnExportScript_Click;
            BtnExportAPI.Click += BtnExportAPI_Click;
        }

        private void BtnExportScript_Click(object sender, EventArgs e)
        {
            #region 테클라에 연결과 기본 모델의 경로, 버전 정보
            Model model = new Model();
            string modelname = model.GetInfo().ModelName;
            string modelpath = model.GetInfo().ModelPath;
            string configuration = ModuleManager.Configuration.ToString();
            string TSversion = TeklaStructuresInfo.GetCurrentProgramVersion();
            string macrodir = "";
            TeklaStructuresSettings.GetAdvancedOption("XS_MACRO_DRIECTORY", ref macrodir);

            #endregion

            string CNC_Files = "\\CNC_Output";
            if (!Directory.Exists(modelpath + CNC_Files))
            {
                Directory.CreateDirectory(modelpath + CNC_Files);
            }
            if (!File.Exists(modelpath + CNC_Files + @"\CreateDstv.cs"))
            {
                StreamWriter SW3 = new StreamWriter(modelpath + CNC_Files + @"\CreateDstv.cs");
                SW3.Write(Resources.CreateDSTV);
                SW3.Close();
            }

            StreamWriter SW4 = new StreamWriter(modelpath + @"\CNCProps");
            SW4.WriteLine("standard");
            SW4.WriteLine("");
            SW4.WriteLine(CNC_Files);
            SW4.Close();

            TSMO.Operation.RunMacro("CreateDstv.cs");

            while(TSMO.Operation.IsMacroRunning())
            {

            }
            if (MessageBox.Show("DSTV Export Complete. Do you want me to open the Folder?","Export Complete Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string filepath = modelpath + CNC_Files;
                System.Diagnostics.Process Explorer = new System.Diagnostics.Process();
                Explorer.EnableRaisingEvents = false;
                Explorer.StartInfo.FileName = "explorer";
                Explorer.StartInfo.Arguments = filepath + "\\";
                Explorer.Start();
            }

        }

        private void BtnExportAPI_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            string modelname = model.GetInfo().ModelName;
            string modelpath = model.GetInfo().ModelPath;
            string configuration = ModuleManager.Configuration.ToString();
            string TSversion = TeklaStructuresInfo.GetCurrentProgramVersion();

            string CNC_Files = @"CNC_Output\";

            if (!Directory.Exists(modelpath + @"\" + CNC_Files))
            {
                Directory.CreateDirectory(modelpath + @"\" + CNC_Files);
            }

            bool Create1 = TSMO.Operation.CreateNCFilesFromSelected("DSTV for plates", modelpath + @"\" + CNC_Files);
            bool Create2 = TSMO.Operation.CreateNCFilesFromSelected("DSTV for profiles", modelpath + @"\" + CNC_Files);

            if (MessageBox.Show("DSTV Export Complete. Do you want me to open the Folder?", "Export Complete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string filepath = modelpath + @"\" + CNC_Files;
                System.Diagnostics.Process Explorer = new System.Diagnostics.Process();
                Explorer.EnableRaisingEvents = false;
                Explorer.StartInfo.FileName = "explorer";
                Explorer.StartInfo.Arguments = "\"" + filepath + "\"";
                Explorer.Start();
            }
        }
    }
}
