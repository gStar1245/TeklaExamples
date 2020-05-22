using System;
using System.Collections;

using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using ModelObectSelector = Tekla.Structures.Model.UI.ModelObjectSelector;

namespace ClashCheckExample
{
    public class ClashCheckExample
    {
        #region Field

        private readonly Model _model = new Model();
        private ModelObectSelector _selector;
        protected Events TsEvent;
        private ClashCheckHandler _clashCheckHandler;
        private int _numberClashes;
        private bool _clashCheckDone;
        private const int WAITTIME = 1500;
        private const int MAXTIME = 30;
        private readonly object _eventLock = new object();
        private ArrayList _clashes;
        
        #endregion

        public ArrayList Clashes { get { return _clashes; } }

        #region Public

        public bool ClashCheck()
        {
            bool result = false;
            _selector = new ModelObectSelector();
            _clashes = new ArrayList();
            _clashCheckDone = false;
            ArrayList objectsToSelect = new ArrayList();

            objectsToSelect = InsertThreeClashingParts();

            #region 전체 모델의 충돌에 대해 확인
            ModelObjectEnumerator modelObjectEnumerator = _model.GetModelObjectSelector().GetAllObjects();
            foreach (ModelObject modelObject in modelObjectEnumerator)
            {
                objectsToSelect.Add(modelObject);
            }
            #endregion

            _selector.Select(objectsToSelect);
            _model.CommitChanges();

            result = RunClashCheck();

            if (TsEvent != null)
            {
                TsEvent.UnRegister();
            }

            return result;
        }

        #endregion

        #region Private

        private ArrayList InsertThreeClashingParts()
        {
            ArrayList insertedObjects = new ArrayList();
            Beam beam1 = new Beam(new Point(2500.0, 0, 0), new Point(2500.0, 5000.0, 0));
            Beam beam2 = new Beam(new Point(0, 2500.0, 0), new Point(5000.0, 2500.0, 0));
            Beam column = new Beam(new Point(2500.0, 2500.0, -200.0), new Point(2500.0, 2500.0, 2000.0));

            beam1.Profile.ProfileString = "780*380";
            beam2.Profile.ProfileString = "780*380";
            column.Profile.ProfileString = "300*300";
            beam1.Insert();
            insertedObjects.Add(beam1);
            beam2.Insert();
            insertedObjects.Add(beam2);
            column.Insert();
            insertedObjects.Add(column);

            return insertedObjects;
        }

        private bool RunClashCheck()
        {
            bool result = true;
            _clashCheckDone = false;
            _numberClashes = 0;
            _clashes.Clear();

            try
            {
                _clashCheckHandler = _model.GetClashCheckHandler();
                TsEvent = new Events();
                TsEvent.ClashDetected += TsEvent_ClashDetected;
                TsEvent.ClashCheckDone += TsEvent_ClashCheckDone;
                TsEvent.Register();
            }
            catch (ApplicationException Exc)
            {
                Console.WriteLine("Exception : " + Exc.ToString());
            }

            DateTime start = DateTime.Now;
            _clashCheckHandler.RunClashCheck();

            TimeSpan span = new TimeSpan();

            while(!_clashCheckDone && span.TotalSeconds < MAXTIME)
            {
                System.Threading.Thread.Sleep(WAITTIME);
                DateTime end = DateTime.Now;
                span = end.Subtract(start);
            }

            return result;
        }

        private void TsEvent_ClashCheckDone(int NumbersOfClashes)
        {
            lock(_eventLock)
            {
                System.Threading.Thread.Sleep(WAITTIME);
                _numberClashes = NumbersOfClashes;
                _clashCheckDone = true;
            }
        }

        private void TsEvent_ClashDetected(ClashCheckData ClashData)
        {
            lock (_eventLock)
            {
                _clashes.Add("Clash : " + ClashData.Object1.Identifier.ID + " <-> " + ClashData.Object2.Identifier.ID + ".");
            }
        }

        #endregion

    }
}