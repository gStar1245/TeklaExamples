using System;
using System.Collections.Generic;

using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;
using TSM = Tekla.Structures.Model;

namespace ImageListComboBoxPlugin
{
    public class StructureData
    {
        [StructuresField("Color")]
        public int Color;
        [StructuresField("Profile")]
        public string Profile;
    }

    /// <summary>
    /// 플러그인 ("Name") 
    /// 클래스가 플러그인임을 정의하고 플러그인 이름을 시스템에 저장하는 필수 필드
    /// 플러그인이 사용하는 사용자 인터페이스를 정의하는 필수 필드, Windows는 클래스 또는 .inp파일을 형성합니다.
    /// </summary>
    [Plugin("MainPlugin")]
    [PluginUserInterface("ImageListComboBoxPlugin.PluginForm")]
    public partial class MainPlugin : PluginBase
    {
        private StructureData Data { get; set; }

        private int _Color;
        private string _Profile;

        public MainPlugin(StructureData data)
        {
            TSM.Model Model = new TSM.Model();
            Data = data;

            GetValuesFromDialog();

        }

        public override List<InputDefinition> DefineInput()
        {
            Picker BeamPicker = new Picker();
            List<InputDefinition> PointList = new List<InputDefinition>();

            TSG.Point Point1 = BeamPicker.PickPoint();
            TSG.Point Point2 = BeamPicker.PickPoint();

            InputDefinition Input1 = new InputDefinition(Point1);
            InputDefinition Input2 = new InputDefinition(Point2);

            PointList.Add(Input1);
            PointList.Add(Input2);

            return PointList;
        }

        private void CreateBeam(TSG.Point Point1, TSG.Point Point2)
        {
            TSM.Beam MyBeam = new TSM.Beam(Point1, Point2);

            MyBeam.Profile.ProfileString = _Profile;
            MyBeam.Class = _Color.ToString();
            MyBeam.Insert();
        }

        public override bool Run(List<InputDefinition> Input)
        {
            try
            {
                GetValuesFromDialog();

                TSG.Point Point1 = (TSG.Point)(Input[0]).GetInput();
                TSG.Point Point2 = (TSG.Point)(Input[1]).GetInput();

                CreateBeam(Point1, Point2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return true;
        }

        private void GetValuesFromDialog()
        {
            _Color = Data.Color;
            _Profile = Data.Profile;
            if (IsDefaultValue(_Color))
            {
                _Color = 2;
            }
            if (IsDefaultValue(_Profile))
            {
                _Profile = "HEA300";
            }
        }
    }
}
