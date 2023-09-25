namespace acceso
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            User = new TextBox();
            Contraseña = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            Text1 = new Label();
            Text2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(397, 64);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // User
            // 
            User.BackColor = Color.White;
            User.BorderStyle = BorderStyle.None;
            User.ForeColor = Color.Silver;
            User.Location = new Point(411, 269);
            User.Margin = new Padding(3, 4, 3, 4);
            User.Multiline = true;
            User.Name = "User";
            User.Size = new Size(246, 35);
            User.TabIndex = 1;
            User.TextAlign = HorizontalAlignment.Center;
            // 
            // Contraseña
            // 
            Contraseña.BorderStyle = BorderStyle.None;
            Contraseña.ForeColor = Color.Silver;
            Contraseña.Location = new Point(411, 322);
            Contraseña.Margin = new Padding(3, 4, 3, 4);
            Contraseña.Multiline = true;
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(246, 30);
            Contraseña.TabIndex = 2;
            Contraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.DimGray;
            checkBox1.Location = new Point(585, 359);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 33);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Mostrar";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(467, 388);
            button1.Name = "button1";
            button1.Size = new Size(147, 34);
            button1.TabIndex = 4;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(436, 496);
            button2.Name = "button2";
            button2.Size = new Size(200, 31);
            button2.TabIndex = 5;
            button2.Text = "Registrarme";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Text1
            // 
            Text1.AutoSize = true;
            Text1.BackColor = Color.Transparent;
            Text1.Location = new Point(327, 269);
            Text1.Name = "Text1";
            Text1.Size = new Size(56, 18);
            Text1.TabIndex = 6;
            Text1.Text = "Usuario";
            // 
            // Text2
            // 
            Text2.AutoSize = true;
            Text2.Location = new Point(327, 322);
            Text2.Name = "Text2";
            Text2.Size = new Size(78, 18);
            Text2.TabIndex = 7;
            Text2.Text = "Contraseña";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Location = new Point(1043, 3);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 661);
            Controls.Add(button3);
            Controls.Add(Text2);
            Controls.Add(Text1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(Contraseña);
            Controls.Add(User);
            Controls.Add(pictureBox1);
            Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Firebrick;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox User;
        private TextBox Contraseña;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Label Text1;
        private Label Text2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private Button button3;
    }
}