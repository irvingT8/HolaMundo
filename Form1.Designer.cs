namespace HolaMundo
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
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtConfirmPassword = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Contraseña:";
            label1.Click += label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(36, 92);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(71, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 146);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "Confirmar contraseña";
            label2.Click += label2_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(36, 197);
            txtConfirmPassword.Margin = new Padding(2, 2, 2, 2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(71, 23);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(36, 274);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 25);
            button1.TabIndex = 4;
            button1.Text = "Validar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 5;
            label3.Text = "Validador de Contraseña";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 416);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtConfirmPassword;
        private Button button1;
        private Label label3;
    }
}
