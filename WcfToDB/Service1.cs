using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WcfToDB
{
    
    public class Service1 : IService1
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-69Q4I0L\\SQLEXPRESS; Initial Catalog = Market; Integrated Security = SSPI;");

        

        

        public int MusteriEkle(Musteri m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler VALUES (@AdSoyad,@Yas,@Cinsiyet)", con);
                cmd.Parameters.AddWithValue("@AdSoyad", m.adSoyad);
                cmd.Parameters.AddWithValue("@Yas", m.yas);
                cmd.Parameters.AddWithValue("@Cinsiyet", m.cinsiuet);

                con.Open();
                cmd.CommandType = CommandType.Text;
                
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                if (con != null)
                    con.Close();
                
                    
                
            }
        }

        public DataTable MusteriGetir(Musteri m)
        {
            try
            {
                SqlDataAdapter dA = new SqlDataAdapter("SELECT * FROM Musteriler", con);
                DataSet dS = new DataSet();
                dS.Tables.Add("Musteriler");
                dA.Fill(dS.Tables["Musteriler"]);

                con.Open();
                return dS.Tables["Musteriler"];

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {

                if (con != null)
                    con.Close();
            }
        }

        public int MusteriSil(Musteri m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Musteriler WHERE MusID = " + m.musID + "", con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                return cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

      
    }
}
