using DA_Search.AllClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DA_Search.Form
{
    public partial class frmKhoaHocAdd : System.Web.UI.Page
    {
        private clsconnect clscon = new clsconnect();
        private SqlCommand sqlcm;
        private string st_type, st_sql;

        protected void Page_Load(object sender, EventArgs e)
        {
            st_type = Request.QueryString.Get("type").ToString();
            switch (st_type)
            {
                case "add":
                    {
                        break;
                    }
            }
        }
    }
}