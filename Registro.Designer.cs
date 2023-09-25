namespace acceso
{
    partial class Registro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            pictureBox1 = new PictureBox();
            User = new TextBox();
            Correo = new TextBox();
            Contraseña = new TextBox();
            botonRegister = new Button();
            Tex1_1 = new Label();
            Text2_2 = new Label();
            Text3_3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // User
            // 
            User.BorderStyle = BorderStyle.None;
            User.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            User.ForeColor = Color.DarkGray;
            User.Location = new Point(411, 237);
            User.Margin = new Padding(3, 4, 3, 4);
            User.Multiline = true;
            User.Name = "User";
            User.Size = new Size(246, 39);
            User.TabIndex = 2;
            User.TextAlign = HorizontalAlignment.Center;
            // 
            // Correo
            // 
            Correo.BorderStyle = BorderStyle.None;
            Correo.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Correo.ForeColor = Color.DarkGray;
            Correo.Location = new Point(329, 300);
            Correo.Margin = new Padding(3, 4, 3, 4);
            Correo.Multiline = true;
            Correo.Name = "Correo";
            Correo.Size = new Size(419, 42);
            Correo.TabIndex = 3;
            Correo.TextAlign = HorizontalAlignment.Center;
            // 
            // Contraseña
            // 
            Contraseña.BorderStyle = BorderStyle.None;
            Contraseña.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Contraseña.ForeColor = Color.DarkGray;
            Contraseña.Location = new Point(411, 365);
            Contraseña.Margin = new Padding(3, 4, 3, 4);
            Contraseña.Multiline = true;
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(246, 40);
            Contraseña.TabIndex = 4;
            Contraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // botonRegister
            // 
            botonRegister.BackColor = Color.Gainsboro;
            botonRegister.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            botonRegister.Location = new Point(427, 439);
            botonRegister.Name = "botonRegister";
            botonRegister.Size = new Size(197, 39);
            botonRegister.TabIndex = 5;
            botonRegister.Text = "Registrarme";
            botonRegister.UseVisualStyleBackColor = false;
            botonRegister.Click += button1_Click;
            // 
            // Tex1_1
            // 
            Tex1_1.AutoSize = true;
            Tex1_1.BackColor = Color.Transparent;
            Tex1_1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Tex1_1.Location = new Point(329, 246);
            Tex1_1.Name = "Tex1_1";
            Tex1_1.Size = new Size(55, 17);
            Tex1_1.TabIndex = 6;
            Tex1_1.Text = "Usuario";
            // 
            // Text2_2
            // 
            Text2_2.AutoSize = true;
            Text2_2.BackColor = Color.Transparent;
            Text2_2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Text2_2.Location = new Point(259, 309);
            Text2_2.Name = "Text2_2";
            Text2_2.Size = new Size(49, 17);
            Text2_2.TabIndex = 7;
            Text2_2.Text = "Correo";
            // 
            // Text3_3
            // 
            Text3_3.AutoSize = true;
            Text3_3.BackColor = Color.Transparent;
            Text3_3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Text3_3.Location = new Point(307, 375);
            Text3_3.Name = "Text3_3";
            Text3_3.Size = new Size(77, 17);
            Text3_3.TabIndex = 8;
            Text3_3.Text = "Contraseña";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new Point(1032, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 661);
            Controls.Add(button1);
            Controls.Add(Text3_3);
            Controls.Add(Text2_2);
            Controls.Add(Tex1_1);
            Controls.Add(botonRegister);
            Controls.Add(Contraseña);
            Controls.Add(Correo);
            Controls.Add(User);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox User;
        private TextBox Correo;
        private TextBox Contraseña;
        private Button botonRegister;
        private Label Tex1_1;
        private Label Text2_2;
        private Label Text3_3;
        private ErrorProvider errorProvider1;
        private Button button1;
    }
}