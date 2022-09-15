using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    internal class DAL
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-UID9DVVD;Initial Catalog=otmansteakhouse;Integrated Security=True");
    }
}
