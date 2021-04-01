
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FastFoodOrder
{
    class csdl
    {
        public DataTable DTTable { get; set; }
        public DataTable DTOrder { get; set; }
        internal static csdl Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new csdl();
                }
                return _Instance;

            }
            private set
            {
            }
        }
        private static csdl _Instance;
        private csdl()
        {
            DTOrder = new DataTable();
            DTOrder.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(String)),
                new DataColumn("NameSV", typeof(String)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("Birthday", typeof(DateTime)),
                new DataColumn("ID_Class", typeof(int))
            });
            // data lớp sinh hoạt
            DTTable = new DataTable();
            DTTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Class", typeof(int)),
                new DataColumn("NameClass", typeof(String)),

            });
            DataRow dr_ = DTTable.NewRow();
            dr_["ID_Class"] = "1";
            dr_["NameClass"] = "19TCLC_DT4";
            DataRow dr_2 = DTTable.NewRow();
            dr_2["ID_Class"] = "2";
            dr_2["NameClass"] = "19TCLC_DT5";
            DataRow dr_3 = DTTable.NewRow();
            dr_3["ID_Class"] = "3";
            dr_3["NameClass"] = "19TCLC_DT6";

            DTTable.Rows.Add(dr_);
            DTTable.Rows.Add(dr_2);
            DTTable.Rows.Add(dr_3);

        }

        public DataTable getSVbyClassID(int class_ID)
        {
            DataTable DTSV_classID = new DataTable();
            DTSV_classID.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(String)),
                new DataColumn("NameSV", typeof(String)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("Birthday", typeof(DateTime)),
                new DataColumn("ID_Class", typeof(int))
            });

            foreach (DataRow i in DTSV.Rows)
            {
                if (Convert.ToInt32(i["ID_Class"].ToString()) == class_ID)
                {
                    DataRow dr = DTSV_classID.NewRow();
                    dr["MSSV"] = i["MSSV"];
                    dr["NameSV"] = i["NameSV"];
                    dr["Gender"] = i["Gender"];
                    dr["Birthday"] = i["Birthday"];
                    dr["ID_Class"] = i["ID_Class"];
                    DTSV_classID.Rows.Add(dr);
                }
            }

            return DTSV_classID;
        }
     
        }
    }
}
