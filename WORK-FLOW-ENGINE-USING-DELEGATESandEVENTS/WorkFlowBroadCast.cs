using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORK_FLOW_ENGINE_USING_DELEGATESandEVENTS
{
    public delegate void WorkFlowDel();

    class WorkFlowBroadCast
    {
        public event WorkFlowDel WorkFlowEvent;

        public void LoadWork()
        {
            OnLoadWorkFlowEvent();
        }


        public void OnLoadWorkFlowEvent()
        {
            WorkFlowDel del = WorkFlowEvent as WorkFlowDel;

            if(del != null)
            {
                del();
            }

        }





    }
}
