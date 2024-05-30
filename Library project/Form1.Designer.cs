namespace Library_project
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
            lstvLibros = new ListView();
            clmnTitulo = new ColumnHeader();
            clmnAutor = new ColumnHeader();
            clmnPaginas = new ColumnHeader();
            clmnPrice = new ColumnHeader();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtPaginas = new TextBox();
            btnaddbook = new Button();
            btnExportJSON = new Button();
            btnExportWord = new Button();
            btnExportExcel = new Button();
            btnChargingtxt = new Button();
            btnSavetxt = new Button();
            lbltitle = new Label();
            lblAuthor = new Label();
            lblPages = new Label();
            lstvTotalLibrosPorSucursal = new ListView();
            clmnSucursal = new ColumnHeader();
            clmnTitle = new ColumnHeader();
            clmnAuthor = new ColumnHeader();
            clmnPages = new ColumnHeader();
            clmnPrecio = new ColumnHeader();
            btnEliminarLibro = new Button();
            btnMoverLibro = new Button();
            comboBoxSucursales = new ComboBox();
            lblNombreUsuario = new Label();
            lblCorreoUsuario = new Label();
            lblPrecio = new Label();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // lstvLibros
            // 
            lstvLibros.Columns.AddRange(new ColumnHeader[] { clmnTitulo, clmnAutor, clmnPaginas, clmnPrice });
            lstvLibros.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstvLibros.Location = new Point(271, 9);
            lstvLibros.Name = "lstvLibros";
            lstvLibros.Size = new Size(772, 404);
            lstvLibros.TabIndex = 15;
            lstvLibros.UseCompatibleStateImageBehavior = false;
            lstvLibros.View = View.Details;
            lstvLibros.MouseDoubleClick += lstvLibros_MouseDoubleClick;
            // 
            // clmnTitulo
            // 
            clmnTitulo.Text = "Title";
            clmnTitulo.Width = 150;
            // 
            // clmnAutor
            // 
            clmnAutor.Text = "Autor";
            clmnAutor.Width = 150;
            // 
            // clmnPaginas
            // 
            clmnPaginas.Text = "Pages";
            clmnPaginas.Width = 150;
            // 
            // clmnPrice
            // 
            clmnPrice.Text = "Price";
            clmnPrice.Width = 150;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(82, 41);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(151, 34);
            txtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(96, 94);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(137, 36);
            txtAutor.TabIndex = 1;
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(96, 146);
            txtPaginas.Multiline = true;
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(137, 37);
            txtPaginas.TabIndex = 2;
            // 
            // btnaddbook
            // 
            btnaddbook.BackColor = Color.FromArgb(128, 255, 128);
            btnaddbook.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddbook.ForeColor = Color.Black;
            btnaddbook.Location = new Point(15, 327);
            btnaddbook.Name = "btnaddbook";
            btnaddbook.Size = new Size(219, 34);
            btnaddbook.TabIndex = 3;
            btnaddbook.Text = "Add book";
            btnaddbook.UseVisualStyleBackColor = false;
            btnaddbook.Click += btnaddbook_Click;
            // 
            // btnExportJSON
            // 
            btnExportJSON.BackColor = SystemColors.GrayText;
            btnExportJSON.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportJSON.Location = new Point(143, 452);
            btnExportJSON.Name = "btnExportJSON";
            btnExportJSON.Size = new Size(122, 42);
            btnExportJSON.TabIndex = 5;
            btnExportJSON.Text = "Export JSON";
            btnExportJSON.UseVisualStyleBackColor = false;
            btnExportJSON.Click += btnExportJSON_Click;
            // 
            // btnExportWord
            // 
            btnExportWord.BackColor = SystemColors.Highlight;
            btnExportWord.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportWord.Location = new Point(12, 500);
            btnExportWord.Name = "btnExportWord";
            btnExportWord.Size = new Size(122, 44);
            btnExportWord.TabIndex = 6;
            btnExportWord.Text = "Export Word";
            btnExportWord.UseVisualStyleBackColor = false;
            btnExportWord.Click += btnExportWord_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Lime;
            btnExportExcel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportExcel.Location = new Point(143, 408);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(122, 38);
            btnExportExcel.TabIndex = 8;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnChargingtxt
            // 
            btnChargingtxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChargingtxt.Location = new Point(12, 452);
            btnChargingtxt.Name = "btnChargingtxt";
            btnChargingtxt.Size = new Size(125, 42);
            btnChargingtxt.TabIndex = 9;
            btnChargingtxt.Text = "Charging txt";
            btnChargingtxt.UseVisualStyleBackColor = true;
            btnChargingtxt.Click += btnChargingtxt_Click;
            // 
            // btnSavetxt
            // 
            btnSavetxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavetxt.Location = new Point(12, 408);
            btnSavetxt.Name = "btnSavetxt";
            btnSavetxt.Size = new Size(125, 38);
            btnSavetxt.TabIndex = 10;
            btnSavetxt.Text = "Save txt";
            btnSavetxt.UseVisualStyleBackColor = true;
            btnSavetxt.Click += btnSavetxt_Click;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(15, 50);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(50, 25);
            lbltitle.TabIndex = 15;
            lbltitle.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(12, 102);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(72, 25);
            lblAuthor.TabIndex = 16;
            lblAuthor.Text = "Author";
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPages.Location = new Point(15, 155);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(62, 25);
            lblPages.TabIndex = 17;
            lblPages.Text = "Pages";
            // 
            // lstvTotalLibrosPorSucursal
            // 
            lstvTotalLibrosPorSucursal.Columns.AddRange(new ColumnHeader[] { clmnSucursal, clmnTitle, clmnAuthor, clmnPages, clmnPrecio });
            lstvTotalLibrosPorSucursal.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstvTotalLibrosPorSucursal.Location = new Point(271, 433);
            lstvTotalLibrosPorSucursal.Name = "lstvTotalLibrosPorSucursal";
            lstvTotalLibrosPorSucursal.Size = new Size(772, 412);
            lstvTotalLibrosPorSucursal.TabIndex = 21;
            lstvTotalLibrosPorSucursal.UseCompatibleStateImageBehavior = false;
            lstvTotalLibrosPorSucursal.View = View.Details;
            lstvTotalLibrosPorSucursal.SelectedIndexChanged += lstvTotalLibrosPorSucursal_SelectedIndexChanged;
            // 
            // clmnSucursal
            // 
            clmnSucursal.Text = "Sucursal";
            clmnSucursal.Width = 150;
            // 
            // clmnTitle
            // 
            clmnTitle.Text = "Title";
            clmnTitle.Width = 150;
            // 
            // clmnAuthor
            // 
            clmnAuthor.Text = "Author";
            clmnAuthor.Width = 150;
            // 
            // clmnPages
            // 
            clmnPages.Text = "Pages";
            clmnPages.Width = 150;
            // 
            // clmnPrecio
            // 
            clmnPrecio.Text = "Price";
            clmnPrecio.Width = 150;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarLibro.Location = new Point(1099, 587);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(131, 42);
            btnEliminarLibro.TabIndex = 23;
            btnEliminarLibro.Text = "Delete book";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnMoverLibro
            // 
            btnMoverLibro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoverLibro.Location = new Point(1099, 635);
            btnMoverLibro.Name = "btnMoverLibro";
            btnMoverLibro.Size = new Size(131, 42);
            btnMoverLibro.TabIndex = 24;
            btnMoverLibro.Text = "Move Books";
            btnMoverLibro.UseVisualStyleBackColor = true;
            btnMoverLibro.Click += btnMoverLibro_Click;
            // 
            // comboBoxSucursales
            // 
            comboBoxSucursales.FormattingEnabled = true;
            comboBoxSucursales.Location = new Point(1068, 433);
            comboBoxSucursales.Name = "comboBoxSucursales";
            comboBoxSucursales.Size = new Size(173, 28);
            comboBoxSucursales.TabIndex = 25;
            comboBoxSucursales.SelectedIndexChanged += comboBoxSucursales_SelectedIndexChanged;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(1059, 9);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(62, 25);
            lblNombreUsuario.TabIndex = 28;
            lblNombreUsuario.Text = "Name";
            // 
            // lblCorreoUsuario
            // 
            lblCorreoUsuario.AutoSize = true;
            lblCorreoUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreoUsuario.Location = new Point(1059, 41);
            lblCorreoUsuario.Name = "lblCorreoUsuario";
            lblCorreoUsuario.Size = new Size(58, 25);
            lblCorreoUsuario.TabIndex = 29;
            lblCorreoUsuario.Text = "Email";
            lblCorreoUsuario.Click += Form1_Load;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(23, 215);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(54, 25);
            lblPrecio.TabIndex = 30;
            lblPrecio.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(96, 206);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(137, 34);
            txtPrice.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1401, 846);
            Controls.Add(txtPrice);
            Controls.Add(lblPrecio);
            Controls.Add(lblCorreoUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(comboBoxSucursales);
            Controls.Add(btnMoverLibro);
            Controls.Add(btnEliminarLibro);
            Controls.Add(lstvTotalLibrosPorSucursal);
            Controls.Add(lblPages);
            Controls.Add(lblAuthor);
            Controls.Add(lbltitle);
            Controls.Add(lstvLibros);
            Controls.Add(btnSavetxt);
            Controls.Add(btnChargingtxt);
            Controls.Add(btnExportExcel);
            Controls.Add(btnExportWord);
            Controls.Add(btnExportJSON);
            Controls.Add(btnaddbook);
            Controls.Add(txtPaginas);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Name = "Form1";
            Text = "Form1";
            Click += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtPaginas;
        private Button btnaddbook;
        private Button btnExportJSON;
        private Button btnExportWord;
        private Button btnExportExcel;
        private Button btnChargingtxt;
        private Button btnSavetxt;
        private ListView lstvLibros;
        private ColumnHeader columnHeaderTitulo;
        private ColumnHeader columnHeaderAutor;
        private ColumnHeader columnHeaderPaginas;
        private ColumnHeader clmnTitulo;
        private ColumnHeader clmnAutor;
        private ColumnHeader clmnPaginas;
        private Label lbltitle;
        private Label lblAuthor;
        private Label lblPages;
        private ListView lstvTotalLibrosPorSucursal;
        private Button btnEliminarLibro;
        private Button btnMoverLibro;
        private ComboBox comboBoxSucursales;
        private Label lblNombreUsuario;
        private Label lblCorreoUsuario;
        private Label lblPrecio;
        private TextBox txtPrice;
        private ColumnHeader clmnPrice;
        private ColumnHeader clmnSucursal;
        private ColumnHeader clmnTitle;
        private ColumnHeader clmnAuthor;
        private ColumnHeader clmnPages;
        private ColumnHeader clmnPrecio;
    }
}
