using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Runtime.InteropServices;
using System.Net.Http;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Reconocimiento_facial
{
    public class DB
    {

        private
        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["Reconocimiento_facial.Properties.Settings.FacesConnectionString"].ConnectionString);

        public string[] Name;
        public string[] id;
  
        private byte[] face;
        public List<byte[]> Face = new List<byte[]>();
        public int TotalUser;

        public DB()
        {

            SqlConnection conn= new SqlConnection(ConfigurationManager.ConnectionStrings["Reconocimiento_facial.Properties.Settings.FacesConnectionString"].ConnectionString);


            conn.Open();

        }

        public bool Login(string Name, string Code, byte[] abImagen)
        {
            c .Open();
       
            SqlCommand comm = new SqlCommand("SELECT IdImage,Name FROM UserFaces where  Name='" + Name + "'AND " + "' Face='" + abImagen + " '", c);
       

            int iResultado = comm.ExecuteNonQuery();
            c.Close();
            return Convert.ToBoolean(iResultado);
        }




     


      



        public bool GuardarImagen(int docente, byte[] abImagen)
        {
            c.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO  UserFaces (id_docente,Face) VALUES ('" + docente + "',@Face)", c);
            SqlParameter parImagen = new SqlParameter("@Face", SqlDbType.VarBinary, abImagen.Length);

            parImagen.Value = abImagen;
            comm.Parameters.Add(parImagen);
            int iResultado = comm.ExecuteNonQuery();

       c.Close();
            return Convert.ToBoolean(iResultado);

        }
        public bool Guardar(int id_docente, int id_estado,TimeSpan fechae, string fechas, string now)
        {
         c.Open();
      SqlCommand comm = new SqlCommand("INSERT INTO  asistencia (id_docente,id_estado ,FechaE , FechaS,Fecha ) VALUES ( '" + id_docente + "', '" + id_estado + "', '" + fechae + "', '" + fechas + "', '" + now + "' )", c);


            
            
            int iResultado = comm.ExecuteNonQuery();

           c.Close();
            return Convert.ToBoolean(iResultado);

        }


        public bool Currentsave(string day)
        {
           c.Open();
         SqlCommand comm = new  SqlCommand("update Current set dia = @day  where Id = 1)", c);
            comm.CommandType = CommandType.Text;
         
      
           comm.Parameters.AddWithValue("@dia", day);
            



            int iResultado = comm.ExecuteNonQuery();

           c.Close();
            return Convert.ToBoolean(iResultado);

        }




        public DataTable ObtenerBytesImagen()
        {
            string sql = "SELECT distinct  dbo.UserFaces.IdImage, dbo.Docentes.Nombre as n, dbo.Docentes.id_docente,dbo.UserFaces.Face FROM dbo.UserFaces INNER JOIN  dbo.Docentes ON dbo.UserFaces.id_docente = dbo.Docentes.id_docente";
           SqlDataAdapter adaptador = new SqlDataAdapter(sql, c);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            int cont = dt.Rows.Count;
            Name = new string[cont];
            id = new string[cont];
            
            for (int i = 0; i < cont; i++)
            {
               
                Name[i] = dt.Rows[i]["n"].ToString();
                id[i] = dt.Rows[i]["id_docente"].ToString();
                face = (byte[])dt.Rows[i]["Face"];
                Face.Add(face);
            }
            TotalUser = dt.Rows.Count;
            c.Close();
            return dt;
        }

        public void ConvertImgToBinary(int docente, Image Img)
        {
            Bitmap bmp = new Bitmap(Img);
            MemoryStream MyStream = new MemoryStream();
            bmp.Save(MyStream, System.Drawing.Imaging.ImageFormat.Bmp);

            byte[] abImagen = MyStream.ToArray();
            GuardarImagen(docente, abImagen);
        }

        public void ConvertImgy(    int id_docente, int id_estado,TimeSpan fechae, string fechas,string fecha)
        {
      

          
            Guardar(id_docente, id_estado,fechae,fechas,fecha);
        }

        public void Current( string day)
        {



           Currentsave(day);
        }




        public void l(string Name, string Code, Image Img)
        {
            Bitmap bmp = new Bitmap(Img);
            MemoryStream MyStream = new MemoryStream();
            byte[] abImagen = MyStream.ToArray();
            Login(Name, Code, abImagen);
        }




        public Image ConvertByteToImg(int con)
        {

            


                Image FetImg;
                byte[] img = Face[con];
                MemoryStream ms = new MemoryStream(img);
                FetImg = Image.FromStream(ms);
                ms.Close();
                return FetImg;
         

        }

    }
}
