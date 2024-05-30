namespace Library_project
{
    partial class FormBienvenida
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
            btnContinuar = new Button();
            lblBienvenida = new Label();
            lblNombre = new Label();
            lblCorreo = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.InactiveCaption;
            btnContinuar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinuar.Location = new Point(320, 280);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(145, 53);
            btnContinuar.TabIndex = 0;
            btnContinuar.Text = "Continue";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(320, 60);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(99, 28);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Welcome";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(108, 148);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 28);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Name";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(112, 221);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(64, 28);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(205, 142);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(309, 34);
            txtNombre.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(205, 215);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(309, 34);
            txtCorreo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.library;
            pictureBox1.Location = new Point(548, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 175);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(819, 461);
            Controls.Add(pictureBox1);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(lblCorreo);
            Controls.Add(lblNombre);
            Controls.Add(lblBienvenida);
            Controls.Add(btnContinuar);
            Name = "FormBienvenida";
            Text = "FormBienvenida";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContinuar;
        private Label lblBienvenida;
        private Label lblNombre;
        private Label lblCorreo;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private PictureBox pictureBox1;
    }
}