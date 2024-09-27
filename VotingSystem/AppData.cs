using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{

    public delegate void OnChangeHandler();

    class AppData
    {

        public const int MaxFingers = 30;
        // shared data
        public int EnrolledFingersMask = 0;
        public int MaxEnrollFingerCount = MaxFingers;
        public bool IsEventHandlerSucceeds = true;
        public bool IsFeatureSetMatched = false;
        public int FalseAcceptRate = 0;
        public DPFP.Template[] Templates = new DPFP.Template[MaxFingers];

        // data change notification
        public void Update() { OnChange(); }        // just fires the OnChange() event
        public event OnChangeHandler OnChange;

    }
}
