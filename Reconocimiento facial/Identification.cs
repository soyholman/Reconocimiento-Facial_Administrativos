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
using System.Net.Mail;
using System.Net;
using System.Media;
using System.Threading;

namespace Reconocimiento_facial
{
    public partial class Identification : MetroFramework.Forms.MetroForm
    {
        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        int w = 0;
        int h = 0;
        #endregion
        //Microsoft Azure
        const string subscriptionKey = "6b7cb2d9555f41439b7b5c86495a65e4";
        const string uriBase = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect";
        public int heigth, width;
        public string[] Labels;
        public string[] Labelsi;
        DB dbc = new DB();
        int con = 0;
        //DECLARANDO TODAS LAS VARIABLES, vectores y  haarcascades
        Image<Bgr, Byte> currentFrame;

        Capture grabber;
        HaarCascade face;

        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> resul = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> labeliden = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;
        string id, ids = null;




        private void btnof_Click(object sender, EventArgs e)
        {


        }


        private void Desconectar()
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
            imageBox1.ImageLocation = "img/1.png";
            label1.Text = string.Empty;
            lblid.Text = string.Empty;
            lblcommd.Text = "";
            lblclase.Text = "";
            lblactive.Text = string.Empty;
            button4.Text = "Detectar";
        }

        public Identification()
        {

            //Thread t = new Thread(new ThreadStart(splash));
            //t.Start();
            //InitializeComponent();
            //string str = string.Empty;
            //for (int i = 1; i < 100000; i++)
            //{

            //    str += i.ToString();
            //}
            //t.Abort();

            InitializeComponent();

            heigth = this.Height; width = this.Width;
            //CARGAMOS LA DETECCION DE LAS CARAS POR  haarcascades 
            face = new HaarCascade("haarcascade_frontalface_alt2.xml");

            try
            {
                dbc.ObtenerBytesImagen();
                //carga de caras y etiquetas para cada imagen               
                string[] Labels = dbc.Name;
                string[] Labelid = dbc.id;
                NumLabels = dbc.TotalUser;
                ContTrain = NumLabels;

                for (int tf = 0; tf < NumLabels; tf++)
                {
                    con = tf;
                    Bitmap bmp = new Bitmap(dbc.ConvertByteToImg(con));
                    //LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(bmp));//cargo la foto con ese nombre

                    labels.Add(Labels[tf]);//cargo el nombre que se encuentre en la posicion del tf
                    labeliden.Add(Labelid[tf]);


                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "No hay ningun rosto registrado).", "Cargar rostros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void splash()
        {

            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Reconocimiento Facial(Demo)";
            Application.Run(frm);


        }
        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["Reconocimiento_facial.Properties.Settings.FacesConnectionString"].ConnectionString);

        private void btn_detectar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (button4.Text)
            {
                case "Detectar":
                    Reconocer();
                    button4.Text = "Desconectar";
                    break;
                case "Desconectar":
                    Desconectar();
                    lblcommd.Text = "";
                    lblclase.Text = "";
                    break;
            }


        }

        public static string hello;
        public void logear()
        {


            string cy;



            SqlCommand da = new SqlCommand("SELECT IdImage,Code,Name FROM UserFaces WHERE  Name=@par", c);
            c.Open();
            da.Parameters.AddWithValue("@par", label1.Text);

            SqlDataReader reader = da.ExecuteReader();


            if (reader.Read())
            {

                hello = reader["IdImage"].ToString();





            }







        }







        Menu u = new Menu();
        public static string del;
        private void button1_Click_1(object sender, EventArgs e)
        {



            LinqDataDataContext linqdata = new LinqDataDataContext();

            try
            {

                string lginuser = (from x in linqdata.Admin where x.User == txtnombre.Text.ToString() select x.User).FirstOrDefault().ToString();

                string lginpassword = (from x in linqdata.Admin where x.User == lginuser && x.contrasena == txtcodigo.Text.ToString() select x.contrasena).FirstOrDefault().ToString();

                if (lginuser.ToString() == txtnombre.Text.ToString() && lginpassword.ToString() == txtcodigo.Text.ToString())
                {
                    MessageBox.Show("correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    new Menu().Show();


                    this.Hide();
                    Desconectar();


                }
                else
                {

                    MessageBox.Show("error");

                }

            }




            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        public static string g;


        private void xuiFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_LocationChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {


        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {

        }
        public int nj;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void xuiFormDesign1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + f2);
        }

        private void xuiButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void Reconocer()
        {
            try
            {
                //Iniciar el dispositivo de captura
                grabber = new Capture();
                grabber.QueryFrame();
                //Iniciar el evento FrameGraber
                Application.Idle += new EventHandler(FrameGrabber);
            }
            catch (Exception ex)
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrameGrabber(object sender, EventArgs e)
        {




            lblactive.Text = "0";
            NamePersons.Add("");
            try
            {
                currentFrame = grabber.QueryFrame().Resize(400, 300, Emgu.CV.CvEnum.INTER.CV_INTER_NN);
                currentFrame._Flip(FLIP.HORIZONTAL);
                //Convertir a escala de grises
                gray = currentFrame.Convert<Gray, Byte>();

                //Detector de Rostros
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.3, 6, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DEFAULT, new Size());

                //Accion para cada elemento detectado
                foreach (MCvAvgComp f in facesDetected[facesDetected.Length - 1])
                {

                    resul = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_NN);
                    //Dibujar el cuadro para el rostro
                    currentFrame.Draw(f.rect, new Bgr(Color.FromArgb(0, 255, 0)), 1);




                    if (trainingImages.ToArray().Length != 0)
                    {



                        //Clase para reconocimiento con el nùmero de imagenes
                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                        //Clase Eligen para reconocimiento de rostro

                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, ref termCrit);
                        EigenObjectRecognizer recognize2 = new EigenObjectRecognizer(trainingImages.ToArray(), labeliden.ToArray(), 3000, ref termCrit);
                        var fa = new Image<Gray, byte>[trainingImages.Count]; //currentFrame.Convert<Bitmap>();


                        id = recognize2.Recognize(resul);
                        name = recognizer.Recognize(resul);
                        //Dibujar el nombre para cada rostro detectado y reconocido
                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.ForestGreen));



                        NamePersons.Add("");
                        //Establecer el nùmero de rostros detectados
                        lblactive.Text = "personas : " + facesDetected[0].Length.ToString();
                        label1.Text = name;
                        lblid.Text = id;

                        if (name == "")
                        {
                            currentFrame.Draw("Rostro Desconocido", ref font, new Point(f.rect.X, f.rect.Y - 5), new Bgr(Color.Red));

                            label1.Text = string.Empty;
                            lblid.Text = string.Empty;
                            lblcommd.Text = "";
                            lblclase.Text = string.Empty;
                            lblactive.Text = string.Empty;
                            lblid.Text="";
                            timer2.Stop();

                        }


                        else if (name != "")
                        {

                            timer2.Start();
                            try
                            {


                                //string asignatura = (from x in data.procedimiento(id.ToString(), Convert.ToString(label6.Text), Convert.ToString(label4.Text)) select x.Asignatura).FirstOrDefault().ToString();
                                //string entrar = (from x in data.procedimiento(id.ToString(), Convert.ToString(label6.Text), Convert.ToString(label4.Text)) select x.Inicio).FirstOrDefault().ToString();
                                //string i = (from x in data.procedimiento(id.ToString(), Convert.ToString(label6.Text), Convert.ToString(label4.Text)) select x.Fin).FirstOrDefault().ToString();

                                //lblclase.Text = "Clase a impartirse:" + asignatura.ToString() + ",Horario de:" + entrar.ToString() + "a:" + i.ToString();

                              

                            }
                            catch (Exception ex)
                            {


                                lblclase.Text = "NO TIENE CLASE ASIGNADA A ESTA HORA:";


                            }


                        }


                    }




                    //Nombres concatenados de todos los rostros reconocidos
                    for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
                    {
                        names = names + NamePersons[nnn] + ", ";
                        ids = ids + NamePersons[nnn] + ", ";

                    }

                    //Mostrar los rostros procesados y reconocidos
                    imageBox1.Image = currentFrame;
                    name = "";
                    id = "";
                    //Borrar la lista de nombres            
                    NamePersons.Clear();

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label4.Text = DateTime.Now.ToString("HH:mm:ss");
            this.labelDay.Text = DateTime.Now.ToString("dd/MM/yyy");
            DateTime day = DateTime.Parse(this.labelDay.Text);
            byte days = (byte)day.DayOfWeek;
            label6.Text = days.ToString();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)


        {

            // string saveou = (from x in d.asistencia where x.IdImage == int.parse(label5.text.tostring()) && x.dia == labelday.text.tostring() select x.id).firstordefault().tostring();

            //  string anvi = (from x in d.Asistencia_View where x.IdImage == int.Parse(user) && x.Inicio == new TimeSpan(long.Parse(label5.Text.ToString())) select x.id_Horario).FirstOrDefault().ToString();



        }

        private void button3_Click(object sender, EventArgs e)
        {














            //LinqDataDataContext d = new LinqDataDataContext();
            //string saveout = (from x in d.asistencia where x.IdImage == int.Parse(label5.Text.ToString()) && x.Dia == labelDay.Text.ToString() select x.IdImage).FirstOrDefault().ToString();
            //string saveou = (from x in d.asistencia where x.IdImage == int.Parse(label5.Text.ToString()) && x.Dia == labelDay.Text.ToString() select x.Id).FirstOrDefault().ToString();

            //if (saveout.ToString() == label5.Text.ToString())
            //{



            //}
            //else
            //{


            //    MessageBox.Show("No puede registrar salida sin antes registrar entrada");
            //}



        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Ingreso().Show();
            this.Hide();
            Desconectar();
        }

        public DateTime f2 = DateTime.Now;

        private void lblclase_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void labelDay_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        System.Media.SoundPlayer sonido = new System.Media.SoundPlayer();

        private void timer2_Tick(object sender, EventArgs e)
        {



            try
            {

           

            LinqDataDataContext d = new LinqDataDataContext();


            TimeSpan entrada = TimeSpan.Parse(label4.Text);




            TimeSpan tiempo = entrada;
            TimeSpan resultado = tiempo + TimeSpan.FromMinutes(0);
            int time = TimeSpan.Compare(entrada, TimeSpan.Parse("08:11:00"));


            try
            {


                string day = (from x in d.procedimiento2(Convert.ToInt32(lblid.Text), labelDay.Text.ToString()) select x.Fecha).FirstOrDefault().ToString();


                    if (labelDay.Text == day.ToString())
            {

                if (time < 0)
                            {


                                SqlCommand cmd = new SqlCommand();
                                cmd.CommandType = CommandType.Text;
                                c.Open();
                    cmd.CommandText = " Update asistencia Set FechaS=@fecha2 where id_docente=@ID AND Fecha=@fecha";

                    cmd.Parameters.AddWithValue("@fecha2", entrada);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(lblid.Text));
                    cmd.Parameters.AddWithValue("@fecha", labelDay.Text);
                   
                    cmd.Connection = c;
                                cmd.ExecuteNonQuery();
                                c.Close();

                                lblcommd.ForeColor = Color.Blue;
                                lblcommd.Text = "Usted:" + name + "_ha registrado salida";
                                sonido.Stream = Properties.Resources.Sound;
                                sonido.Play();
                                timer2.Stop();



                            }
                            else if (time > 0)
                            {




                                SqlCommand cmd = new SqlCommand();
                                cmd.CommandType = CommandType.Text;
                                c.Open();
                                cmd.CommandText = "Update asistencia Set FechaS=@fecha2 where id_docente=@ID AND Fecha=@fecha";

                            cmd.Parameters.AddWithValue("@fecha2", entrada);
                            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(lblid.Text));
                            cmd.Parameters.AddWithValue("@fecha", labelDay.Text);
                               cmd.Connection = c;
                                cmd.ExecuteNonQuery();
                                c.Close();

                                lblcommd.Enabled = Visible;
                                lblcommd.ForeColor = Color.Indigo;
                                lblcommd.Text = "Usted:" + name + "_ha registrado salida";
                                sonido.Stream = Properties.Resources.Sound;
                                sonido.Play();
                                timer2.Stop();
            
                            }

                            timer2.Stop();

                        






                        timer2.Stop();




                }
                    

            }

            catch(Exception ex)



                {
              

                if (time > 0)
                {



                    dbc.ConvertImgy(Convert.ToInt32(lblid.Text), 1, entrada, null, labelDay.Text);

                    //mail.To.Add(new MailAddress(Dropgmail.SelectedValue.ToString()));

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("ucnseguimientoav@gmail.com");
                        //mail.To.Add(new MailAddress("msandoval@ucn.edu.ni"));
                        mail.To.Add(new MailAddress("hmorales@ucn.edu.ni"));

                        //mail.To.Add(new MailAddress("asiscentral@ucn.edu.ni"));

                    mail.Subject = "Notificación de marcadas Tardes de trabajadores/"+labelDay.Text;
                    mail.Body = "Nombre:" + label1.Text + ",Hora de entrada:" + entrada + ",Fecha:" + labelDay.Text;



                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    System.Net.NetworkCredential credential = new System.Net.NetworkCredential();
                    credential.UserName = "ucnseguimientoav@gmail.com";
                    credential.Password = "seguimiento";
                    smtp.Credentials = credential;
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    lblcommd.ForeColor = Color.Green;
                    lblcommd.Text = "Usted:" + name + "_ha registrado entrada";
                    sonido.Stream = Properties.Resources.Sound;
                    sonido.Play();

                }
                else if (time < 0)
                {


                    lblcommd.ForeColor = Color.Green;
                    lblcommd.Text = "Usted:" + name + "_ha registrado entrada";
                    dbc.ConvertImgy(Convert.ToInt32(lblid.Text), 2, entrada, null, labelDay.Text);

                    sonido.Stream = Properties.Resources.Sound;
                    sonido.Play();
                }




            }

            timer2.Stop();



            }
            catch(Exception ex)
            {


            }







        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(lblid.Text);
            TimeSpan entrada = TimeSpan.Parse(label4.Text);


            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            c.Open();
            cmd.CommandText = " Update asistencia Set FechaS=@fecha2 where id_docente=@ID AND Fecha=@fecha";

            cmd.Parameters.AddWithValue("@fecha2", entrada);
            cmd.Parameters.AddWithValue("@ID", idd);
            cmd.Parameters.AddWithValue("@fecha", labelDay.Text);

            cmd.Connection = c;
            cmd.ExecuteNonQuery();
            c.Close();

            lblcommd.ForeColor = Color.Blue;
            lblcommd.Text = "Usted:" + name + "_ha registrado salida";
            sonido.Stream = Properties.Resources.Sound;
            sonido.Play();
            timer2.Stop();


        }

        public static int j;
        public static DateTime ki;
        LinqDataDataContext data = new LinqDataDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {


            Reconocer();



        }

        void v()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            c.Open();
            cmd.CommandText = " Update fecha Set dy=@fecha2 where Id=1";

            cmd.Parameters.AddWithValue("@fecha2", DateTime.Now.ToString("dd/MM/yy"));
            cmd.Connection = c;
            cmd.ExecuteNonQuery();
            c.Close();





        }
    }
}
