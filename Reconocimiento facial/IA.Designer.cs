namespace Reconocimiento_facial
{
    partial class IA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IA));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_loadImgsBD = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_detectar = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnback = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.Color.White;
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(16, 25);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(261, 150);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 38;
            this.imageBox2.TabStop = false;
            this.imageBox2.Click += new System.EventHandler(this.imageBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_ultimo);
            this.groupBox1.Controls.Add(this.btn_loadImgsBD);
            this.groupBox1.Controls.Add(this.btn_anterior);
            this.groupBox1.Controls.Add(this.btn_siguiente);
            this.groupBox1.Controls.Add(this.btn_primero);
            this.groupBox1.Controls.Add(this.imageBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(515, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 384);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "lbl";
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.Location = new System.Drawing.Point(216, 352);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(35, 23);
            this.btn_ultimo.TabIndex = 40;
            this.btn_ultimo.Text = ">>I";
            this.btn_ultimo.UseVisualStyleBackColor = false;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_loadImgsBD
            // 
            this.btn_loadImgsBD.FlatAppearance.BorderSize = 0;
            this.btn_loadImgsBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadImgsBD.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadImgsBD.Location = new System.Drawing.Point(136, 352);
            this.btn_loadImgsBD.Name = "btn_loadImgsBD";
            this.btn_loadImgsBD.Size = new System.Drawing.Size(35, 23);
            this.btn_loadImgsBD.TabIndex = 44;
            this.btn_loadImgsBD.Text = "...";
            this.btn_loadImgsBD.UseVisualStyleBackColor = true;
            this.btn_loadImgsBD.Click += new System.EventHandler(this.btn_loadImgsBD_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.Transparent;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Location = new System.Drawing.Point(96, 352);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(35, 23);
            this.btn_anterior.TabIndex = 41;
            this.btn_anterior.Text = "<<";
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.Color.Transparent;
            this.btn_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguiente.Location = new System.Drawing.Point(176, 352);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(35, 23);
            this.btn_siguiente.TabIndex = 42;
            this.btn_siguiente.Text = ">>";
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.BackColor = System.Drawing.Color.Transparent;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primero.Location = new System.Drawing.Point(56, 352);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(35, 23);
            this.btn_primero.TabIndex = 43;
            this.btn_primero.Text = "I<<";
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(589, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Seleccionar Trabajador";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.White;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregar.Location = new System.Drawing.Point(593, 516);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(173, 29);
            this.btn_agregar.TabIndex = 41;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Rostros detectados:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(169, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 29);
            this.button1.TabIndex = 49;
            this.button1.Text = "Desconectar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_detectar
            // 
            this.btn_detectar.BackColor = System.Drawing.Color.White;
            this.btn_detectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_detectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_detectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_detectar.Location = new System.Drawing.Point(10, 516);
            this.btn_detectar.Name = "btn_detectar";
            this.btn_detectar.Size = new System.Drawing.Size(153, 29);
            this.btn_detectar.TabIndex = 48;
            this.btn_detectar.Text = "Detectar";
            this.btn_detectar.UseVisualStyleBackColor = false;
            this.btn_detectar.Click += new System.EventHandler(this.btn_detectar_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(10, 53);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(499, 457);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 28;
            this.imageBoxFrameGrabber.TabStop = false;
            this.imageBoxFrameGrabber.Click += new System.EventHandler(this.imageBoxFrameGrabber_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(515, 489);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 21);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnback
            // 
            this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnback.BackColor = System.Drawing.Color.White;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.Location = new System.Drawing.Point(755, 7);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(19, 17);
            this.btnback.TabIndex = 57;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.White;
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Upload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Upload.Location = new System.Drawing.Point(333, 516);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(158, 29);
            this.Upload.TabIndex = 58;
            this.Upload.Text = "Cargar Rostro";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // IA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_detectar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.MaximizeBox = false;
            this.Name = "IA";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Registro ";
            this.Load += new System.EventHandler(this.IA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_loadImgsBD;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_detectar;
        private System.Windows.Forms.Label label4;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}