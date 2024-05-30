namespace Library_project
{
    partial class FormActionBook
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
            lblTitle = new Label();
            lblPrice = new Label();
            btnPrice = new Button();
            btnToLend = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(77, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(64, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(77, 113);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(64, 21);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "label2";
            // 
            // btnPrice
            // 
            btnPrice.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrice.Location = new Point(32, 180);
            btnPrice.Name = "btnPrice";
            btnPrice.Size = new Size(129, 38);
            btnPrice.TabIndex = 2;
            btnPrice.Text = "To Buy";
            btnPrice.UseVisualStyleBackColor = true;
            btnPrice.Click += btnPrice_Click;
            // 
            // btnToLend
            // 
            btnToLend.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToLend.Location = new Point(32, 249);
            btnToLend.Name = "btnToLend";
            btnToLend.Size = new Size(129, 42);
            btnToLend.TabIndex = 3;
            btnToLend.Text = "To Lend";
            btnToLend.UseVisualStyleBackColor = true;
            btnToLend.Click += btnToLend_Click;
            // 
            // FormActionBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(935, 504);
            Controls.Add(btnToLend);
            Controls.Add(btnPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblTitle);
            Name = "FormActionBook";
            Text = "FormActionBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPrice;
        private Button btnPrice;
        private Button btnToLend;
    }
}