using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.UI;

using Emgu.CV.CvEnum;

using Emgu.CV.Structure;

using System.Diagnostics;

using System.Runtime.InteropServices;
namespace Reconocimiento_facial
{
    public partial class IA : MetroFramework.Forms.MetroForm
    {
        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        int w = 0;
        int h = 0;
        #endregion

        public int heigth, width;

        public string[] Labels;
        DB dbc = new DB();
        int con = 0, ini = 0;
        //DECLARANDO TODAS LAS VARIABLES, vectores y  haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
       
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
        Image<Gray, byte> result, TrainedFace = null, gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
   
        List<string> labels1 = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;



        private void btn_siguiente_Click(object sender, EventArgs e)
        {
   
            if (ini < NumLabels - 1)
            {
                ini++;
                pictureBox1.Image = dbc.ConvertByteToImg(ini);
                label4.Text = dbc.Name[ini];
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (ini > 0)
            {
                ini--;
                pictureBox1.Image = dbc.ConvertByteToImg(ini);
                label4.Text = dbc.Name[ini];
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {

            ini = NumLabels - 1;
            pictureBox1.Image = dbc.ConvertByteToImg(ini);
            label4.Text = dbc.Name[ini];
        }

        private void btn_loadImgsBD_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            pictureBox1.Image = dbc.ConvertByteToImg(0);
            label4.Text = dbc.Name[0];
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {                
            grabber = new Capture();
            grabber.QueryFrame();


            //DialogResult Dialog = MessageBox.Show("Desea registrar este Usuario?", "Añadir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //    if (Dialog.Equals(DialogResult.OK))
            //    {
            //    try
            //    {


            //        //Trained face counter
            //        ContTrain = ContTrain + 1;

            //        //Get a gray frame from capture device
            //        gray = grabber.QueryGrayFrame().Resize(400, 300, INTER.CV_INTER_CUBIC);

            //        //Face Detector
            //        MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size());

            //        //Action for each element detected
            //        foreach (MCvAvgComp f in facesDetected[0])
            //        {
            //            TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
            //            break;
            //        }

            //        //resize face detected image for force to compare the same size with the 
            //        //test image with cubic interpolation type method
            //        TrainedFace = result.Resize(100, 100, INTER.CV_INTER_CUBIC);
            //        trainingImages.Add(TrainedFace);


            //        //Show face added in gray scale
            //        imageBox2.Image = TrainedFace;
            //        dbc.ConvertImgToBinary(int.Parse(comboBox1.SelectedValue.ToString()), imageBox2.Image.Bitmap);

            //        MessageBox.Show("Agregado correctamente", "Capturado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    Application.Idle -= new EventHandler(FrameGrabber);//Detenemos el evento de captura
            //    grabber.Dispose();//Dejamos de usar la clase para capturar usar los dispositivos
            //    imageBoxFrameGrabber.ImageLocation = "img/1.png";//reiniciamos la imagen del control
            //    btn_detectar.Enabled = true;
            //    button1.Enabled = false;
            //    }
            //    catch(Exception ex)
            //    {


            //        MessageBox.Show("No se ha capturado rostro");
            //    }
            //}
            //    else
            //    {

            //        this.Refresh();
            //    }

            try
            {
                DialogResult Dialog = MessageBox.Show("Desea registrar este Usuario?", "Añadir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (Dialog.Equals(DialogResult.OK))
                {
                    //Trained face counter
                    ContTrain = ContTrain + 1;

                    //Get a gray frame from capture device
                    gray = grabber.QueryGrayFrame().Resize(400, 300, INTER.CV_INTER_NN);

                    //Face Detector
                    MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DEFAULT, new Size());

                    //Action for each element detected
                    foreach (MCvAvgComp f in facesDetected[0])
                    {
                        TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                        break;
                    }

                    //resize face detected image for force to compare the same size with the 
                    //test image with cubic interpolation type method
                    TrainedFace = result.Resize(100, 100, INTER.CV_INTER_NN);
                    trainingImages.Add(TrainedFace);


                    //Show face added in gray scale
                    imageBox2.Image = TrainedFace;
                    dbc.ConvertImgToBinary(int.Parse(comboBox1.SelectedValue.ToString()), imageBox2.Image.Bitmap);

                    MessageBox.Show("Agregado correctamente", "Capturado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                        Application.Idle -= new EventHandler(FrameGrabber);//Detenemos el evento de captura
                        grabber.Dispose();//Dejamos de usar la clase para capturar usar los dispositivos
                        imageBoxFrameGrabber.ImageLocation = "img/1.png";//reiniciamos la imagen del control      
                    }
                else
                {

                    this.Refresh();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor mire fijamente a la camara y evite moverse", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            imageBox2.Image = null;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Idle -= new EventHandler(FrameGrabber);//Detenemos el evento de captura
                grabber.Dispose();//Dejamos de usar la clase para capturar usar los dispositivos
                imageBoxFrameGrabber.ImageLocation = "img/1.png";//reiniciamos la imagen del control
                btn_detectar.Enabled = true;
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Hide();
            new Menu().Show();
        

   
          
        }
    
        private void imageBoxFrameGrabber_Click(object sender, EventArgs e)
        {
           
        }

        private void imageBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = dbc.ConvertByteToImg(0);
            label4.Text = dbc.Name[0];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

            try
            {
                Application.Idle -= new EventHandler(FrameGrabber);//Detenemos el evento de captura
                grabber.Dispose();//Dejamos de usar la clase para capturar usar los dispositivos
                imageBoxFrameGrabber.ImageLocation = "img/1.png";//reiniciamos la imagen del control
                btn_detectar.Enabled = true;
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            new Menu().Show();
            this.Hide();
        }


        private void DetectFaces()
        {
            Image<Gray, byte> grayframe = currentFrame.Convert<Gray, byte>();

            try
            {

                //detect faces from the gray-scale image and store into an array of type 'var',i.e 'MCvAvgComp[]'
               
                MCvAvgComp[][] faces = grayframe.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                if (faces.Length > 0)
                {




                    //Set The Face Number
                    //FaceCollection = Directory.GetFiles(@"Face Collection\", "*.bmp");
                    //int FaceNo = FaceCollection.Length;

                    //A Bitmap Array to hold the extracted faces



                    //draw a green rectangle on each detected face in image
                    foreach (MCvAvgComp face in faces[0])
                    {
                        //locate the detected face & mark with a rectangle
                        result = currentFrame.Copy(face.rect).Convert<Gray, byte>().Resize(640, 480, INTER.CV_INTER_CUBIC);
                        currentFrame.Draw(face.rect, new Bgr(Color.FromArgb(0, 255, 0)), 1);
                    




                    }
                    //Display the detected faces in imagebox
                    imageBoxFrameGrabber.Image = currentFrame;



                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
           



        


        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image InputImg = Image.FromFile(openFileDialog1.FileName);
               currentFrame = new Image<Bgr, byte>(new Bitmap(InputImg));
                imageBoxFrameGrabber.Image = currentFrame;

                DetectFaces();
            }

           

                
                
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {





            //MessageBox.Show("Agregado correctamente", "Capturado", MessageBoxButtons.OK, MessageBoxIcon.Information);





            //Image<Gray, byte> grayframe = currentFrame.Convert<Gray, byte>();



            //MCvAvgComp[][] faces =grayframe.DetectHaarCascade(face, 1.2, 10,
            //                       Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
            //                        new Size());
           
         
          

            //    //draw a green rectangle on each detected face in image
            //    foreach (MCvAvgComp face in faces[0])
            //    {
            //        //locate the detected face & mark with a rectangle
            //        TrainedFace = currentFrame.Copy(face.rect).Convert<Gray, byte>();
       
       

            //    break;

            //    }
            ////Display the detected faces in imagebox

            //trainingImages.Add(TrainedFace);


            //    //Show face added in gray scale
            //    imageBox2.Image = TrainedFace;
               
            //    dbc.ConvertImgToBinary(int.Parse(comboBox1.SelectedValue.ToString()), imageBox2.Image.Bitmap);





            
        }
        private void btn_detectar_Click(object sender, EventArgs e)
        {
            try
            {
                //Inicia la Captura            
                grabber = new Capture();
                grabber.QueryFrame();

                //Inicia el evento FrameGraber
                Application.Idle += new EventHandler(FrameGrabber);
                this.button1.Enabled = true;
                btn_detectar.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string name;

        public IA()
        {
            InitializeComponent();

            heigth = this.Height; width = this.Width;
            //CARGAMOS LA DETECCION DE LAS CARAS POR  haarcascades 
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                dbc.ObtenerBytesImagen();//carga de caras previus trainned y etiquetas para cada imagen                
                Labels = dbc.Name; //Labelsinfo.Split('%');//separo los nombres de los usuarios 
                NumLabels = dbc.TotalUser;// Convert.ToInt32(Labels[0]);//extraigo el total de usuarios registrados
                ContTrain = NumLabels;


                for (int tf = 0; tf < NumLabels; tf++)//recorro el numero de nombres registrados
                {
                    con = tf;
                    Bitmap bmp = new Bitmap(dbc.ConvertByteToImg(con));
                    //LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(bmp));//cargo la foto con ese nombre
                    labels.Add(Labels[tf]);//cargo el nombre que se encuentre en la posicion del tf

                }
            }
            catch (Exception e)
            {//Si la variable NumLabels es 0 me presenta el msj
                MessageBox.Show(e + " No hay ningún rostro en la Base de Datos, por favor añadir por lo menos una cara", "Cragar caras en tu Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            NamePersons.Add("");
            try
            {

                //Obtener la secuencia del dispositivo de captura
                try
                {
                    currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    currentFrame._Flip(FLIP.HORIZONTAL);
                }
                catch (Exception)
                {
                    imageBoxFrameGrabber.Image = null;
                }

                DetectFaces();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        LinqDataDataContext data = new  LinqDataDataContext();
        private void IA_Load(object sender, EventArgs e)
        {
            var  h= (from x in data.Info_docente select x).ToList();
            imageBoxFrameGrabber.ImageLocation = "img/1.png";
         //   var docente = (from x in data.Docentes where !(from j in h select j).Contains(x.id_docente) select x);
            comboBox1.DisplayMember = "Docente";     
            comboBox1.ValueMember= "id_docente";
            comboBox1.DataSource = h;
        }
    }
}
