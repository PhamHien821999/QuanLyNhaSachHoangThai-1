using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLy.DAL
{
  public  class Connection
    {
        SqlConnection con;

        public SqlConnection getConnection()
        {
            string st = ConfigurationManager.ConnectionStrings["ManagerBook"].ToString();
            con = new SqlConnection(st);
            return con;
        }

        public DataTable LoadData(string sql)
        {
            getConnection().Open();
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            DataTable dtThAccount = new DataTable();
            da.Fill(dtThAccount);
            getConnection().Close();
            return dtThAccount;
            
        }



    }

}
