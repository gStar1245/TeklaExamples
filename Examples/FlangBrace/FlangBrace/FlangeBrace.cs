using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using TSDatatype = Tekla.Structures.Datatype;
using TSM = Tekla.Structures.Model;
using TSPlugins = Tekla.Structures.Plugins;
using T3D = Tekla.Structures.Geometry3d;
using Tekla.Structures;
using Tekla.Structures.Model;
using Tekla.Structures.Plugins;
using Tekla.Structures.Geometry3d;
using TSMUI = Tekla.Structures.Model.UI;

namespace FlangeBrace
{
    #region StructureData
    public class StructureData
    {
        [Tekla.Structures.Plugins.StructuresField("ClipThickness")]
        public double ClipThickness;
        [Tekla.Structures.Plugins.StructuresField("ClipWidth")]
        public double ClipWidth;
        [Tekla.Structures.Plugins.StructuresField("ClipLength")]
        public double ClipLength;
        [Tekla.Structures.Plugins.StructuresField("ClipMaterial")]
        public string ClipMaterial;
        [Tekla.Structures.Plugins.StructuresField("ClipName")]
        public string ClipName;
        [Tekla.Structures.Plugins.StructuresField("ClipWeldSize")]
        public double ClipWeldSize;
        [Tekla.Structures.Plugins.StructuresField("BraceProfile")]
        public string BraceProfile;
        [Tekla.Structures.Plugins.StructuresField("BraceMaterial")]
        public string BraceMaterial;
        [Tekla.Structures.Plugins.StructuresField("BraceName")]
        public string BraceName;
        [Tekla.Structures.Plugins.StructuresField("BraceClass")]
        public string BraceClass;
        [Tekla.Structures.Plugins.StructuresField("PlateThickness")]
        public double PlateThickness;
        [Tekla.Structures.Plugins.StructuresField("PlateWidth")]
        public double PlateWidth;
        [Tekla.Structures.Plugins.StructuresField("PlateLength")]
        public double PlateLength;
        [Tekla.Structures.Plugins.StructuresField("PlateMaterial")]
        public string PlateMaterial;
        [Tekla.Structures.Plugins.StructuresField("PlateName")]
        public string PlateName;
        [Tekla.Structures.Plugins.StructuresField("UpperHorizontal")]
        public double UpperHorizontal;
        [Tekla.Structures.Plugins.StructuresField("UpperVertical")]
        public double UpperVertical;
        [Tekla.Structures.Plugins.StructuresField("UpperBoltHorizontal")]
        public double UpperBoltHorizontal;
        [Tekla.Structures.Plugins.StructuresField("LowerHorizontal")]
        public double LowerHorizontal;
        [Tekla.Structures.Plugins.StructuresField("LowerVertical")]
        public double LowerVertical;
        [Tekla.Structures.Plugins.StructuresField("LowerBoltHorizontal")]
        public double LowerBoltHorizontal;
        [Tekla.Structures.Plugins.StructuresField("ClipBoltStandard")]
        public string ClipBoltStandard;
        [Tekla.Structures.Plugins.StructuresField("ClipBoltSize")]
        public double ClipBoltSize;
        [Tekla.Structures.Plugins.StructuresField("BraceBoltStandard")]
        public string BraceBoltStandard;
        [Tekla.Structures.Plugins.StructuresField("BraceBoltSize")]
        public double BraceBoltSize;
    }

    #endregion

    [TSPlugins.Plugin("FlangeBrace")]
    [TSPlugins.PluginUserInterface("FlangeBrace.FlangeBraceForm")]

    public class FlangeBrace : PluginBase
    {
        #region Fields

        private double _TopClipThickness;
        private double _TopClipWidth;
        private double _TopClipLength;
        private double _ClipWeldSize;
        private string _TopClipMaterial = string.Empty;
        private string _TopClipName = string.Empty;
        private string _FlangeName = string.Empty;
        private string _FlangeMaterial = string.Empty;
        private string _FlangeClass = string.Empty;
        private string _FlangeProfile = string.Empty;
        private double _PlateThickness;
        private double _PlateWidth;
        private double _PlateLength;
        private string _PlateMaterial = string.Empty;
        private string _PlateName = string.Empty;
        private double _UpperHorizontalDistance;
        private double _UpperVerticalDistance;
        private double _UpperBoltHorizontalDistance;
        private double _LowerHorizontalDistance;
        private double _LowerVerticalDistance;
        private double _LowerBoltHorizontalDistance;
        private double _ClipBoltSize;
        private string _CliptBoltStandard = string.Empty;
        private double _BraceBoltSize;
        private string _BraceBoltStandard = string.Empty;

        #endregion

        #region Constructor, Property 

        private readonly TSM.Model _model;
        public TSM.Model Model { get { return _model; } }
        private readonly StructureData _data;
        public FlangeBrace(StructureData data)
        {
            _model = new TSM.Model();
            _data = data;
        }

        #endregion

        #region Override Define Input

        public override List<InputDefinition> DefineInput()
        {
            List<InputDefinition> PartList = new List<InputDefinition>();

            TSMUI.Picker _picker = new TSMUI.Picker();

            Beam Purlin1 = (Beam)_picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_PART);
            Beam Purlin2 = (Beam)_picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_PART);

            Beam OFlange = (Beam)_picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_PART);
            Beam Web = (Beam)_picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_PART);
            Beam IFlange = (Beam)_picker.PickObject(TSMUI.Picker.PickObjectEnum.PICK_ONE_PART);

            InputDefinition Input1 = new InputDefinition(Purlin1.Identifier);
            InputDefinition Input2 = new InputDefinition(Purlin2.Identifier);
            InputDefinition Input3 = new InputDefinition(OFlange.Identifier);
            InputDefinition Input4 = new InputDefinition(Web.Identifier);
            InputDefinition Input5 = new InputDefinition(IFlange.Identifier);

            PartList.Add(Input1);
            PartList.Add(Input2);
            PartList.Add(Input3);
            PartList.Add(Input4);
            PartList.Add(Input5);

            return PartList;
        }
        #endregion

        #region Override Run

        public override bool Run(List<InputDefinition> Input)
        {
            try
            {
                // 오버라이드 된 DefineInput에서 List를 가져옴
                // purlin = 중도리 지붕을 지탱하는 골조
                // flange = 플랜지 파이프를 연결하기 위한 배관?
                Beam Purlin1 = (Beam)_model.SelectModelObject((Identifier)Input[0].GetInput());
                Beam Purlin2 = (Beam)_model.SelectModelObject((Identifier)Input[1].GetInput());
                Beam OFlange = (Beam)_model.SelectModelObject((Identifier)Input[2].GetInput());
                Beam Web = (Beam)_model.SelectModelObject((Identifier)Input[3].GetInput());
                Beam IFlange = (Beam)_model.SelectModelObject((Identifier)Input[4].GetInput());

                // 초기값 체크
                GetValuesFromDialog();

                double WebThick = 0.0;
                double IFlangeWidth = 0.0;
                double IFlangeThick = 0.0;
                double OFlangeThick = 0.0;
                Web.GetReportProperty("WIDTH", ref WebThick);
                OFlange.GetReportProperty("WIDTH", ref OFlangeThick);
                IFlange.GetReportProperty("WIDTH", ref IFlangeThick);
                IFlange.GetReportProperty("HEIGHT", ref IFlangeWidth);

                if (IsDefaultValue(_PlateWidth) || _PlateWidth == 0)
                    _PlateWidth = (IFlangeWidth - WebThick) * 0.5;
                if (IsDefaultValue(_PlateLength) || _PlateLength == 0)
                    _PlateLength = (IFlangeWidth - WebThick) * 0.5;

                CoordinateSystem WebSys = Web.GetCoordinateSystem();

                // 평면(Web)과 선(purlin1의 시작과 끝점)이 만나는 교차점
                T3D.Point TopCenter = T3D.Intersection.LineToPlane(new Line(Purlin1.StartPoint, Purlin1.EndPoint), new GeometricPlane(WebSys.Origin, WebSys.AxisX, WebSys.AxisY));

                // 실제 좌표점(x,y,z)
                CoordinateSystem WorkSystem = new CoordinateSystem(TopCenter, WebSys.AxisX.Cross(WebSys.AxisY), WebSys.AxisY);

                // CoordinateSystem의 실좌표를 Plane 변경
                _model.GetWorkPlaneHandler().SetCurrentTransformationPlane(new TransformationPlane(WorkSystem));

                Purlin1.Select();
                Purlin2.Select();
                Web.Select();
                OFlange.Select();
                IFlange.Select();

                CoordinateSystem PurSys = Purlin1.GetCoordinateSystem();
                T3D.Point TopClipCenter = T3D.Intersection.LineToPlane(new Line(OFlange.StartPoint, OFlange.EndPoint), new GeometricPlane(PurSys.Origin, PurSys.AxisX, PurSys.AxisY));
                T3D.Point BottCenter = T3D.Intersection.LineToPlane(new Line(IFlange.StartPoint, IFlange.EndPoint), new GeometricPlane(PurSys.Origin, PurSys.AxisX, PurSys.AxisY));

                T3D.Point LeftAngleFirstPoint = new T3D.Point(-_UpperHorizontalDistance, _UpperVerticalDistance, 0);
                T3D.Point LeftAngleSecondPoint = new T3D.Point(-_LowerHorizontalDistance, BottCenter.Y - IFlangeThick + _LowerVerticalDistance, 0);
                T3D.Point RightAngleFirstPoint = new T3D.Point(_UpperHorizontalDistance, _UpperVerticalDistance, 0);
                T3D.Point RightAngleSecondPoint = new T3D.Point(_LowerHorizontalDistance, BottCenter.Y - IFlangeThick + _LowerVerticalDistance, 0);

                Beam LeftAngle = new Beam();
                Beam RightAngle = new Beam();
                Beam TopClip = new Beam();
                ContourPlate LeftPlate = new ContourPlate();
                ContourPlate RightPlate = new ContourPlate();

                TopClip.StartPoint = new T3D.Point(-_TopClipLength * 0.5, TopClipCenter.Y + OFlangeThick, 0);
                TopClip.EndPoint = new T3D.Point(_TopClipLength * 0.5, TopClipCenter.Y + OFlangeThick, 0);

                if (PurSys.AxisX.GetNormal() == new Vector(1,0,0) && PurSys.AxisY.GetNormal() == new Vector(0,1,0))
                {
                    LeftAngle.StartPoint = LeftAngleSecondPoint;
                    LeftAngle.EndPoint = LeftAngleFirstPoint;
                    RightAngle.StartPoint = RightAngleFirstPoint;
                    RightAngle.EndPoint = RightAngleSecondPoint;
                    LeftAngle.Position.Plane = Position.PlaneEnum.LEFT;
                    LeftAngle.Position.Rotation = Position.RotationEnum.BELOW;
                    LeftAngle.Position.Depth = Position.DepthEnum.BEHIND;
                    RightAngle.Position.Plane = Position.PlaneEnum.LEFT;
                    RightAngle.Position.Rotation = Position.RotationEnum.BELOW;
                    RightAngle.Position.Depth = Position.DepthEnum.BEHIND;
                    TopClip.Position.Plane = Position.PlaneEnum.LEFT;
                    TopClip.Position.Rotation = Position.RotationEnum.FRONT;
                    TopClip.Position.Depth = Position.DepthEnum.BEHIND;
                    LeftPlate.Position.Depth = Position.DepthEnum.FRONT;
                    RightPlate.Position.Depth = Position.DepthEnum.FRONT;
                }
                else
                {
                    LeftAngle.StartPoint = LeftAngleFirstPoint;
                    LeftAngle.EndPoint = LeftAngleSecondPoint;
                    RightAngle.StartPoint = RightAngleFirstPoint;
                    RightAngle.EndPoint = RightAngleSecondPoint;
                    LeftAngle.Position.Plane = Position.PlaneEnum.RIGHT;
                    LeftAngle.Position.Rotation = Position.RotationEnum.TOP;
                    LeftAngle.Position.Depth = Position.DepthEnum.FRONT;
                    RightAngle.Position.Plane = Position.PlaneEnum.RIGHT;
                    RightAngle.Position.Rotation = Position.RotationEnum.FRONT;
                    RightAngle.Position.Depth = Position.DepthEnum.FRONT;
                    TopClip.Position.Plane = Position.PlaneEnum.LEFT;
                    TopClip.Position.Rotation = Position.RotationEnum.FRONT;
                    TopClip.Position.Depth = Position.DepthEnum.FRONT;
                    LeftPlate.Position.Depth = Position.DepthEnum.BEHIND;
                    RightPlate.Position.Depth = Position.DepthEnum.BEHIND;
                }

                LeftAngle.Profile.ProfileString = _FlangeProfile;
                LeftAngle.Material.MaterialString = _FlangeMaterial;
                LeftAngle.Class = _FlangeClass;
                LeftAngle.Name = _FlangeName;
                LeftAngle.Insert();

                RightAngle.Profile.ProfileString = _FlangeProfile;
                RightAngle.Material.MaterialString = _FlangeMaterial;
                RightAngle.Class = _FlangeClass;
                RightAngle.Name = _FlangeName;
                RightAngle.Insert();

                double BraceWidth = 0.0;
                double BraceThickness = 0.0;
                RightAngle.GetReportProperty("WIDTH", ref BraceWidth);
                RightAngle.GetReportProperty("PROFILE.FLANGE_THICKNESS_1", ref BraceThickness);

                double BoltGauge = (BraceWidth + BraceThickness) * 0.5;
                LeftAngle.Position.PlaneOffset = -BoltGauge;
                LeftAngle.StartPointOffset.Dx = _UpperBoltHorizontalDistance;
                LeftAngle.EndPointOffset.Dx = _LowerBoltHorizontalDistance;
                LeftAngle.Modify();
                RightAngle.Position.PlaneOffset = -BoltGauge;
                RightAngle.StartPointOffset.Dx = -_LowerBoltHorizontalDistance;
                RightAngle.EndPointOffset.Dx = _UpperBoltHorizontalDistance;
                RightAngle.Modify();

                TopClip.Profile.ProfileString = "PL" + _TopClipThickness + "*" + _TopClipWidth;
                TopClip.Material.MaterialString = _TopClipMaterial;
                TopClip.Name = _TopClipName;
                TopClip.Insert();

                Point LeftPlatePoint1 = new Point(BottCenter.X - WebThick * 0.5, BottCenter.Y, 0);
                Point LeftPlatePoint2 = new Point(BottCenter.X - WebThick * 0.5, BottCenter.Y + _PlateLength, 0);
                Point LeftPlatePoint3 = new Point(BottCenter.X - WebThick * 0.5 - _PlateWidth, BottCenter.Y + _PlateLength, 0);
                Point LeftPlatePoint4 = new Point(BottCenter.X - WebThick * 0.5 - _PlateWidth, BottCenter.Y, 0);
                ContourPoint LeftPlateContourPoint1 = new ContourPoint(LeftPlatePoint1, new Chamfer(30, 30, Chamfer.ChamferTypeEnum.CHAMFER_LINE));
                ContourPoint LeftPlateContourPoint2 = new ContourPoint(LeftPlatePoint2, new Chamfer());
                ContourPoint LeftPlateContourPoint3 = new ContourPoint(LeftPlatePoint3, new Chamfer());
                ContourPoint LeftPlateContourPoint4 = new ContourPoint(LeftPlatePoint4, new Chamfer());
                LeftPlate.AddContourPoint(LeftPlateContourPoint1);
                LeftPlate.AddContourPoint(LeftPlateContourPoint2);
                LeftPlate.AddContourPoint(LeftPlateContourPoint3);
                LeftPlate.AddContourPoint(LeftPlateContourPoint4);
                LeftPlate.Material.MaterialString = _PlateMaterial;
                LeftPlate.Profile.ProfileString = "PL" + _PlateThickness.ToString();
                LeftPlate.Name = _PlateName;
                LeftPlate.Insert();

                Point RightPlatePoint1 = new Point(BottCenter.X + WebThick * 0.5, BottCenter.Y, 0);
                Point RightPlatePoint2 = new Point(RightPlatePoint1.X + _PlateWidth, RightPlatePoint1.Y, 0);
                Point RightPlatePoint3 = new Point(RightPlatePoint2.X, RightPlatePoint2.Y + _PlateLength, 0);
                Point RightPlatePoint4 = new Point(RightPlatePoint3.X - _PlateWidth, RightPlatePoint3.Y, 0);
                ContourPoint RightPlateContourPoint1 = new ContourPoint(RightPlatePoint1, new Chamfer(30, 30, Chamfer.ChamferTypeEnum.CHAMFER_LINE));
                ContourPoint RightPlateContourPoint2 = new ContourPoint(RightPlatePoint2, new Chamfer());
                ContourPoint RightPlateContourPoint3 = new ContourPoint(RightPlatePoint3, new Chamfer());
                ContourPoint RightPlateContourPoint4 = new ContourPoint(RightPlatePoint4, new Chamfer());
                RightPlate.AddContourPoint(RightPlateContourPoint1);
                RightPlate.AddContourPoint(RightPlateContourPoint2);
                RightPlate.AddContourPoint(RightPlateContourPoint3);
                RightPlate.AddContourPoint(RightPlateContourPoint4);
                RightPlate.Material.MaterialString = _PlateMaterial;
                RightPlate.Profile.ProfileString = "PL" + _PlateThickness.ToString();
                RightPlate.Name = _PlateName;
                RightPlate.Insert();

                Beam LeftPurlin = Purlin1;
                Beam RightPurlin = Purlin2;
                if ( (Purlin1.StartPoint.X - Purlin2.StartPoint.X) > 1 || (Purlin1.StartPoint.Y - Purlin2.StartPoint.Y) > 1)
                {
                    RightPurlin = Purlin1;
                    LeftPurlin = Purlin2;
                }

                Weld LeftPlateToIFlange = new Weld();
                LeftPlateToIFlange.MainObject = IFlange;
                LeftPlateToIFlange.SecondaryObject = LeftPlate;
                LeftPlateToIFlange.ShopWeld = true;
                LeftPlateToIFlange.Insert();
                Weld LeftPlateToWeb = new Weld();
                LeftPlateToWeb.MainObject = Web;
                LeftPlateToWeb.SecondaryObject = LeftPlate;
                LeftPlateToWeb.ShopWeld = true;
                LeftPlateToWeb.Insert();
                Weld RightPlateToIFlange = new Weld();
                RightPlateToIFlange.MainObject = IFlange;
                RightPlateToIFlange.SecondaryObject = RightPlate;
                RightPlateToIFlange.ShopWeld = true;
                RightPlateToIFlange.Insert();
                Weld RightPlateToWeb = new Weld();
                RightPlateToWeb.MainObject = Web;
                RightPlateToWeb.SecondaryObject = RightPlate;
                RightPlateToWeb.ShopWeld = true;
                RightPlateToWeb.Insert();

                PolygonWeld ClipToFlange = new PolygonWeld();
                ClipToFlange.TypeAbove = BaseWeld.WeldTypeEnum.WELD_TYPE_FILLET;
                ClipToFlange.TypeBelow = BaseWeld.WeldTypeEnum.WELD_TYPE_FILLET;
                ClipToFlange.SizeAbove = _ClipWeldSize;
                ClipToFlange.SizeBelow = _ClipWeldSize;
                ClipToFlange.MainObject = OFlange;
                ClipToFlange.SecondaryObject = TopClip;
                ClipToFlange.ShopWeld = true;
                ClipToFlange.Polygon.Points.Add(TopClip.StartPoint);
                ClipToFlange.Polygon.Points.Add(TopClip.EndPoint);
                ClipToFlange.Insert();

                // Bolting Brace with Plate or Purlin
                BoltArray UpperLeftBolt = new BoltArray();
                UpperLeftBolt.PartToBoltTo = LeftPurlin;
                UpperLeftBolt.PartToBeBolted = LeftAngle;
                UpperLeftBolt.FirstPosition = LeftAngle.StartPoint;
                UpperLeftBolt.SecondPosition = LeftAngle.EndPoint;
                UpperLeftBolt.AddBoltDistX(0.0);
                UpperLeftBolt.AddBoltDistY(0.0);
                UpperLeftBolt.BoltSize = _BraceBoltSize;
                UpperLeftBolt.Tolerance = 0.0625 * 25.4;
                UpperLeftBolt.BoltStandard = _BraceBoltStandard;
                UpperLeftBolt.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_SITE;
                UpperLeftBolt.CutLength = 76.2;
                UpperLeftBolt.Bolt = true;
                UpperLeftBolt.Position.Rotation = Position.RotationEnum.FRONT;
                BoltArray LowerLeftBolt = new BoltArray();
                LowerLeftBolt.PartToBoltTo = LeftPlate;
                LowerLeftBolt.PartToBeBolted = LeftAngle;
                LowerLeftBolt.FirstPosition = LeftAngle.EndPoint;
                LowerLeftBolt.SecondPosition = LeftAngle.StartPoint;
                LowerLeftBolt.AddBoltDistX(0.0);
                LowerLeftBolt.AddBoltDistY(0.0);
                LowerLeftBolt.BoltSize = _BraceBoltSize;
                LowerLeftBolt.BoltStandard = _BraceBoltStandard;
                LowerLeftBolt.Tolerance = 0.0625 * 25.4;
                LowerLeftBolt.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_SITE;
                LowerLeftBolt.CutLength = 76.2;
                LowerLeftBolt.Bolt = true;
                LowerLeftBolt.Position.Rotation = Position.RotationEnum.FRONT;
                BoltArray UpperRightBolt = new BoltArray();
                UpperRightBolt.PartToBoltTo = RightPurlin;
                UpperRightBolt.PartToBeBolted = RightAngle;
                UpperRightBolt.FirstPosition = RightAngle.EndPoint;
                UpperRightBolt.SecondPosition = RightAngle.StartPoint;
                UpperRightBolt.AddBoltDistX(0.0);
                UpperRightBolt.AddBoltDistY(0.0);
                UpperRightBolt.BoltSize = _BraceBoltSize;
                UpperRightBolt.Tolerance = 0.0625 * 25.4;
                UpperRightBolt.BoltStandard = _BraceBoltStandard;
                UpperRightBolt.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_SITE;
                UpperRightBolt.CutLength = 76.2;
                UpperRightBolt.Bolt = true;
                UpperRightBolt.Position.Rotation = Position.RotationEnum.FRONT;
                BoltArray LowerRightBolt = new BoltArray();
                LowerRightBolt.PartToBoltTo = RightPlate;
                LowerRightBolt.PartToBeBolted = RightAngle;
                LowerRightBolt.FirstPosition = RightAngle.StartPoint;
                LowerRightBolt.SecondPosition = RightAngle.EndPoint;
                LowerRightBolt.AddBoltDistX(0.0);
                LowerRightBolt.AddBoltDistY(0.0);
                LowerRightBolt.BoltSize = _BraceBoltSize;
                LowerRightBolt.Tolerance = 0.0625 * 25.4;
                LowerRightBolt.BoltStandard = _BraceBoltStandard;
                LowerRightBolt.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_SITE;
                LowerRightBolt.CutLength = 76.2;
                LowerRightBolt.Bolt = true;
                LowerRightBolt.Position.Rotation = Position.RotationEnum.FRONT;

                // Bolting ClipPlate with purlin
                BoltArray ClipBolts1 = new BoltArray();
                ClipBolts1.PartToBoltTo = LeftPurlin;
                ClipBolts1.PartToBeBolted = TopClip;
                ClipBolts1.FirstPosition = TopClip.StartPoint;
                ClipBolts1.SecondPosition = TopClip.EndPoint;
                ClipBolts1.StartPointOffset.Dx = 31.75;
                ClipBolts1.AddBoltDistX(0);
                ClipBolts1.AddBoltDistY(76.2);
                ClipBolts1.StartPointOffset.Dy = 76.2;
                ClipBolts1.EndPointOffset.Dy = 76.2;
                ClipBolts1.BoltSize = _ClipBoltSize;
                ClipBolts1.Tolerance = 0.0625 * 25.4;
                ClipBolts1.BoltStandard = _CliptBoltStandard;
                ClipBolts1.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_SITE;
                ClipBolts1.CutLength = 76.2;
                ClipBolts1.Bolt = true;
                ClipBolts1.Position.Rotation = Position.RotationEnum.FRONT;

                BoltArray ClipBolts2 = new BoltArray();
                ClipBolts2.PartToBoltTo = RightPurlin;
                ClipBolts2.PartToBeBolted = TopClip;
                ClipBolts2.FirstPosition = TopClip.StartPoint;
                ClipBolts2.SecondPosition = TopClip.EndPoint;
                ClipBolts2.StartPointOffset.Dx = _TopClipLength - 31.75;
                ClipBolts2.AddBoltDistX(0);
                ClipBolts2.AddBoltDistY(76.2);
                ClipBolts2.StartPointOffset.Dy = 76.2;
                ClipBolts2.EndPointOffset.Dy = 76.2;
                ClipBolts2.BoltSize = _ClipBoltSize;
                ClipBolts2.Tolerance = 0.0625 * 25.4;
                ClipBolts2.BoltStandard = _CliptBoltStandard;
                ClipBolts2.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_SITE;
                ClipBolts2.CutLength = 76.2;
                ClipBolts2.Bolt = true;
                ClipBolts2.Position.Rotation = Position.RotationEnum.FRONT;

                if(PurSys.AxisX.GetNormal() == new Vector(1,0,0) && PurSys.AxisX.GetNormal() == new Vector(0,1,0))
                {
                    UpperLeftBolt.FirstPosition = LeftAngle.EndPoint;
                    UpperLeftBolt.SecondPosition = LeftAngle.StartPoint;
                    UpperLeftBolt.Position.Rotation = Position.RotationEnum.BACK;
                    LowerLeftBolt.FirstPosition = LeftAngle.StartPoint;
                    LowerLeftBolt.SecondPosition = LeftAngle.EndPoint;
                    LowerLeftBolt.Position.Rotation = Position.RotationEnum.BACK;
                    UpperRightBolt.FirstPosition = RightAngle.StartPoint;
                    UpperRightBolt.SecondPosition = RightAngle.EndPoint;
                    UpperRightBolt.Position.Rotation = Position.RotationEnum.BACK;
                    LowerRightBolt.FirstPosition = RightAngle.StartPoint;
                    LowerRightBolt.SecondPosition = RightAngle.EndPoint;
                    LowerRightBolt.Position.Rotation = Position.RotationEnum.BACK;
                    ClipBolts1.Position.Rotation = Position.RotationEnum.BACK;
                    ClipBolts2.Position.Rotation = Position.RotationEnum.BACK;
                }
                UpperLeftBolt.Insert();
                LowerLeftBolt.Insert();
                UpperRightBolt.Insert();
                LowerRightBolt.Insert();
                ClipBolts1.Insert();
                ClipBolts2.Insert();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return true;
        }


        #endregion

        #region Private

        private void GetValuesFromDialog()
        {
            _TopClipThickness = _data.ClipThickness;
            _TopClipWidth = _data.ClipWidth;
            _TopClipLength = _data.ClipLength;
            _ClipWeldSize = _data.ClipWeldSize;
            _TopClipMaterial = _data.ClipMaterial;
            _TopClipName = _data.ClipName;
            _FlangeName = _data.BraceName;
            _FlangeMaterial = _data.BraceMaterial;
            _FlangeClass = _data.BraceClass;
            _FlangeProfile = _data.BraceProfile;
            _PlateThickness = _data.PlateThickness;
            _PlateWidth = _data.PlateWidth;
            _PlateLength = _data.PlateLength;
            _PlateMaterial = _data.PlateMaterial;
            _PlateName = _data.PlateName;
            _UpperBoltHorizontalDistance = _data.UpperBoltHorizontal;
            _UpperHorizontalDistance = _data.UpperHorizontal;
            _UpperVerticalDistance = _data.UpperVertical;
            _LowerBoltHorizontalDistance = _data.LowerBoltHorizontal;
            _LowerHorizontalDistance = _data.LowerHorizontal;
            _LowerVerticalDistance = _data.LowerVertical;
            _ClipBoltSize = _data.ClipBoltSize;
            _CliptBoltStandard = _data.ClipBoltStandard;
            _BraceBoltSize = _data.BraceBoltSize;
            _BraceBoltStandard = _data.BraceBoltStandard;

            if (IsDefaultValue(_TopClipThickness) || _TopClipThickness == 0)
                _TopClipThickness = 6;
            if (IsDefaultValue(_TopClipWidth) || _TopClipWidth ==0)
                _TopClipWidth = 152.4;
            if (IsDefaultValue(_TopClipLength) || _TopClipLength == 0)
                _TopClipLength = 152.4;
            if (IsDefaultValue(_ClipWeldSize) || _ClipWeldSize == 0)
                _ClipWeldSize = 6.35;
            if (IsDefaultValue(_TopClipMaterial) || _TopClipMaterial == string.Empty)
                _TopClipMaterial = "S235JR";
            if (IsDefaultValue(_TopClipName) || _TopClipName == string.Empty)
                _TopClipName = "PLATE";
            if (IsDefaultValue(_FlangeName) || _FlangeName == string.Empty)
                _FlangeName = "FLANGE_BRACE";
            if (IsDefaultValue(_FlangeClass) || _FlangeClass == string.Empty)
                _FlangeClass = "1";
            if (IsDefaultValue(_FlangeProfile) || _FlangeProfile == string.Empty)
                _FlangeProfile = "L50*6";
            if (IsDefaultValue(_PlateThickness) || _PlateThickness == 0)
                _PlateThickness = 6;
            if (IsDefaultValue(_PlateWidth))
                _PlateWidth = 0;
            if (IsDefaultValue(_PlateLength))
                _PlateLength = 0;
            if (IsDefaultValue(_PlateMaterial) || _PlateMaterial == string.Empty)
                _PlateMaterial = "S235JR";
            if (IsDefaultValue(_PlateName) || _PlateName == string.Empty)
                _PlateName = "PLATE";
            if (IsDefaultValue(_UpperHorizontalDistance) || _UpperHorizontalDistance == 0)
                _UpperHorizontalDistance = 441;
            if (IsDefaultValue(_UpperVerticalDistance) || _UpperVerticalDistance == 0)
                _UpperVerticalDistance = 80;
            if (IsDefaultValue(_UpperBoltHorizontalDistance) || _UpperBoltHorizontalDistance == 0)
                _UpperBoltHorizontalDistance = 30;
            if (IsDefaultValue(_LowerHorizontalDistance) || _LowerHorizontalDistance == 0)
                _LowerHorizontalDistance = 50;
            if (IsDefaultValue(_LowerVerticalDistance) || _LowerVerticalDistance == 0)
                _LowerVerticalDistance = 50;
            if (IsDefaultValue(_LowerBoltHorizontalDistance) || _LowerBoltHorizontalDistance == 0)
                _LowerBoltHorizontalDistance = 30;
            if (IsDefaultValue(_ClipBoltSize) || _ClipBoltSize == 0)
                _ClipBoltSize = 12;
            if (IsDefaultValue(_CliptBoltStandard) || _CliptBoltStandard == string.Empty)
                _CliptBoltStandard = "6914";
            if (IsDefaultValue(_BraceBoltSize) || _BraceBoltSize == 0)
                _BraceBoltSize = 12;
            if (IsDefaultValue(_BraceBoltStandard) || _BraceBoltStandard == string.Empty)
                _BraceBoltStandard = "6914";
        }

        #endregion
    }
}
