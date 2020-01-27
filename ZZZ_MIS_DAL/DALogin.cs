using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZZ_MIS_DAL
{
    public class DALogin
    {
        

        public static void GetLoginByKorisnickoImeAndLozinka(DSLogin.LoginPodaciDataTable dtLogin, string korisnickoIme, string lozinka)
        {
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Login_SelectByKorisnickoImeAndLozinka", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if(korisnickoIme!="")
                cmd.Parameters.Add("@korisnickoIme", SqlDbType.NVarChar).Value = korisnickoIme;
                if(lozinka!="")
                cmd.Parameters.Add("@lozinka", SqlDbType.NVarChar).Value = lozinka;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtLogin);
                
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
