namespace ProjetoLogin.Apresentacao
{
    partial class Cadastrar
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
            labelEmail = new Label();
            labelSenha = new Label();
            labelConfirmarSenha = new Label();
            textBoxEmail = new TextBox();
            textBoxSenha = new TextBox();
            textBoxConfirmarSenha = new TextBox();
            ButtonCadastrar = new Button();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(89, 43);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(61, 23);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSenha.Location = new Point(89, 134);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(62, 23);
            labelSenha.TabIndex = 1;
            labelSenha.Text = "Senha";
            labelSenha.Click += labelSenha_Click;
            // 
            // labelConfirmarSenha
            // 
            labelConfirmarSenha.AutoSize = true;
            labelConfirmarSenha.Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConfirmarSenha.Location = new Point(89, 227);
            labelConfirmarSenha.Name = "labelConfirmarSenha";
            labelConfirmarSenha.Size = new Size(156, 23);
            labelConfirmarSenha.TabIndex = 2;
            labelConfirmarSenha.Text = "Confirmar Senha";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 10.2F);
            textBoxEmail.ForeColor = SystemColors.ButtonFace;
            textBoxEmail.Location = new Point(89, 66);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(315, 30);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxSenha
            // 
            textBoxSenha.BorderStyle = BorderStyle.FixedSingle;
            textBoxSenha.Font = new Font("Segoe UI", 10.2F);
            textBoxSenha.ForeColor = SystemColors.ButtonFace;
            textBoxSenha.Location = new Point(89, 157);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(185, 30);
            textBoxSenha.TabIndex = 3;
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.BorderStyle = BorderStyle.FixedSingle;
            textBoxConfirmarSenha.Font = new Font("Segoe UI", 10.2F);
            textBoxConfirmarSenha.ForeColor = SystemColors.ButtonFace;
            textBoxConfirmarSenha.Location = new Point(89, 250);
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.PasswordChar = '*';
            textBoxConfirmarSenha.Size = new Size(185, 30);
            textBoxConfirmarSenha.TabIndex = 3;
            // 
            // ButtonCadastrar
            // 
            ButtonCadastrar.Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCadastrar.Location = new Point(288, 309);
            ButtonCadastrar.Name = "ButtonCadastrar";
            ButtonCadastrar.Size = new Size(116, 54);
            ButtonCadastrar.TabIndex = 4;
            ButtonCadastrar.Text = "Cadastrar";
            ButtonCadastrar.UseVisualStyleBackColor = true;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 406);
            Controls.Add(ButtonCadastrar);
            Controls.Add(textBoxConfirmarSenha);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxEmail);
            Controls.Add(labelConfirmarSenha);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Cadastrar";
            Text = "Cadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmail;
        private Label labelSenha;
        private Label labelConfirmarSenha;
        private TextBox textBoxEmail;
        private TextBox textBoxSenha;
        private TextBox textBoxConfirmarSenha;
        private Button ButtonCadastrar;
    }
}