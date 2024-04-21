namespace ProjetoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxLogin = new PictureBox();
            labelLogin = new Label();
            labelSenha = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonCadastrar = new Button();
            buttonSair = new Button();
            buttonEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = (Image)resources.GetObject("pictureBoxLogin.Image");
            pictureBoxLogin.Location = new Point(12, 21);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(288, 237);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.TabIndex = 0;
            pictureBoxLogin.TabStop = false;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Calisto MT", 13.8F);
            labelLogin.Location = new Point(307, 59);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(91, 26);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "LOGIN";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Calisto MT", 13.8F);
            labelSenha.Location = new Point(307, 124);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(95, 26);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "SENHA";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial Narrow", 10.2F);
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(408, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonFace;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Arial Narrow", 10.2F);
            textBox2.ForeColor = SystemColors.ControlText;
            textBox2.Location = new Point(408, 123);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(228, 27);
            textBox2.TabIndex = 3;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(81, 283);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(153, 29);
            buttonCadastrar.TabIndex = 1;
            buttonCadastrar.Text = "CADASTAR";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click_1;
            // 
            // buttonSair
            // 
            buttonSair.Font = new Font("Calisto MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSair.Location = new Point(544, 188);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(92, 29);
            buttonSair.TabIndex = 1;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Font = new Font("Calisto MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEntrar.Location = new Point(408, 188);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(92, 29);
            buttonEntrar.TabIndex = 1;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(648, 343);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelSenha);
            Controls.Add(labelLogin);
            Controls.Add(buttonCadastrar);
            Controls.Add(buttonEntrar);
            Controls.Add(buttonSair);
            Controls.Add(pictureBoxLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogin;
        private Button button1;
        private Label labelLogin;
        private Label labelSenha;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonCadastrar;
        private Button buttonSair;
        private Button buttonEntrar;
    }
}
