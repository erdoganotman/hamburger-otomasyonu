using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntitiyLayer;
namespace DataAccessLayer
{
    public class DALSiparis
    {
      public static List<Entity> siparislisetesi()
        {
            List<Entity> deger = new List<Entity>();
            SqlCommand cmd = new SqlCommand("select * from siparis",DAL.baglanti);
            if (cmd.Connection.State != System.Data.ConnectionState.Open)
            {
                cmd.Connection.Open();

            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Entity ent=new Entity();
                ent.Siparis_id=int.Parse(dr["siparis_id"].ToString());
                ent.Siparis_adı=dr["siparis_adı"].ToString();
                ent.Siparis_adeti=int.Parse(dr["siparis_adeti"].ToString());
                ent.Siparis_ucreti=int.Parse(dr["siparis_ucreti"].ToString()) ;
                ent.Masano = int.Parse(dr["masano"].ToString());
                deger.Add(ent);

            }
                dr.Close();
            return deger;
            }
        public static int siparisekle(Entity n)
        {
            SqlCommand add = new SqlCommand("Insert into siparis (siparis_adı,siparis_ucreti,Siparis_adeti,masano) values (@p1,@p2,@p3,@p4)", DAL.baglanti);
            if (add.Connection.State != System.Data.ConnectionState.Open)
            {
                add.Connection.Open();
            }
            
            add.Parameters.AddWithValue("@p1", n.Siparis_adı);
            add.Parameters.AddWithValue("@p2", n.Siparis_ucreti);
            add.Parameters.AddWithValue("@p3", n.Siparis_adeti);
            add.Parameters.AddWithValue("@p4",n.Masano);
            
            return add.ExecuteNonQuery();
        }

        public static bool siparissil(int p)
        {
            SqlCommand del = new SqlCommand("delete from siparis where siparis_id=@p1", DAL.baglanti);
            if (del.Connection.State != System.Data.ConnectionState.Open)
            {
                del.Connection.Open();
            }
            del.Parameters.AddWithValue("@p1", p);
            return del.ExecuteNonQuery()>0;
        }


        }
}

