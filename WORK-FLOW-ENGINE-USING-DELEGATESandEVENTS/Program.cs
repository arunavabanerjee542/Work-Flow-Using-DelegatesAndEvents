using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORK_FLOW_ENGINE_USING_DELEGATESandEVENTS
{
    class Program
    {
        static void Main(string[] args)
        {

            Email e = new Email();

            WebService w = new WebService();

            CloudStorage c = new CloudStorage();

            DataBase db = new DataBase();

            WorkFlowBroadCast wb = new WorkFlowBroadCast();


            wb.WorkFlowEvent += e.SendEmail;
            wb.WorkFlowEvent += w.VedioEncoding;
            wb.WorkFlowEvent += c.UploadInCloud;
            wb.WorkFlowEvent += db.SendEmail;


            wb.LoadWork();


        }
    }
}
