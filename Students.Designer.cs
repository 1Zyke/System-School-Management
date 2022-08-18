namespace SchoolManagementSystem
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SMatricula2 = new System.Windows.Forms.TextBox();
            this.SSid = new System.Windows.Forms.Label();
            this.StNameTb = new System.Windows.Forms.TextBox();
            this.Snombre = new System.Windows.Forms.Label();
            this.SaveBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.EditBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BackBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DeleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.StudentsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.SCorreoTb = new System.Windows.Forms.TextBox();
            this.SSCorreo = new System.Windows.Forms.Label();
            this.STelefonoTb = new System.Windows.Forms.TextBox();
            this.SSTelefono = new System.Windows.Forms.Label();
            this.SFoto = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 49);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1082, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estudiantes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SMatricula2
            // 
            this.SMatricula2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMatricula2.Location = new System.Drawing.Point(263, 101);
            this.SMatricula2.Name = "SMatricula2";
            this.SMatricula2.Size = new System.Drawing.Size(157, 27);
            this.SMatricula2.TabIndex = 8;
            this.SMatricula2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SSid
            // 
            this.SSid.AutoSize = true;
            this.SSid.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSid.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SSid.Location = new System.Drawing.Point(259, 76);
            this.SSid.Name = "SSid";
            this.SSid.Size = new System.Drawing.Size(29, 22);
            this.SSid.TabIndex = 7;
            this.SSid.Text = "ID";
            this.SSid.Click += new System.EventHandler(this.label2_Click);
            // 
            // StNameTb
            // 
            this.StNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StNameTb.Location = new System.Drawing.Point(461, 101);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.Size = new System.Drawing.Size(157, 27);
            this.StNameTb.TabIndex = 10;
            this.StNameTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Snombre
            // 
            this.Snombre.AutoSize = true;
            this.Snombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Snombre.Location = new System.Drawing.Point(457, 76);
            this.Snombre.Name = "Snombre";
            this.Snombre.Size = new System.Drawing.Size(84, 22);
            this.Snombre.TabIndex = 9;
            this.Snombre.Text = "Nombre";
            this.Snombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AnimationHoverSpeed = 0.07F;
            this.SaveBtn.AnimationSpeed = 0.03F;
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SaveBtn.BorderColor = System.Drawing.Color.Black;
            this.SaveBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SaveBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.SaveBtn.CheckedForeColor = System.Drawing.Color.White;
            this.SaveBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.CheckedImage")));
            this.SaveBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Image = null;
            this.SaveBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveBtn.Location = new System.Drawing.Point(294, 155);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SaveBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveBtn.OnHoverImage = null;
            this.SaveBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SaveBtn.Radius = 20;
            this.SaveBtn.Size = new System.Drawing.Size(124, 41);
            this.SaveBtn.TabIndex = 18;
            this.SaveBtn.Text = "Agregar";
            this.SaveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveBtn.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.AnimationHoverSpeed = 0.07F;
            this.EditBtn.AnimationSpeed = 0.03F;
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EditBtn.BorderColor = System.Drawing.Color.Black;
            this.EditBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.EditBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.EditBtn.CheckedForeColor = System.Drawing.Color.White;
            this.EditBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.CheckedImage")));
            this.EditBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EditBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditBtn.FocusedColor = System.Drawing.Color.Empty;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Image = null;
            this.EditBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.EditBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditBtn.Location = new System.Drawing.Point(441, 155);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EditBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.EditBtn.OnHoverImage = null;
            this.EditBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditBtn.OnPressedColor = System.Drawing.Color.Black;
            this.EditBtn.Radius = 20;
            this.EditBtn.Size = new System.Drawing.Size(124, 41);
            this.EditBtn.TabIndex = 19;
            this.EditBtn.Text = "Editar";
            this.EditBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditBtn.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.AnimationHoverSpeed = 0.07F;
            this.BackBtn.AnimationSpeed = 0.03F;
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BackBtn.BorderColor = System.Drawing.Color.Black;
            this.BackBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BackBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.BackBtn.CheckedForeColor = System.Drawing.Color.White;
            this.BackBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.CheckedImage")));
            this.BackBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BackBtn.FocusedColor = System.Drawing.Color.Empty;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Image = null;
            this.BackBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.BackBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BackBtn.Location = new System.Drawing.Point(733, 155);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BackBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BackBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.BackBtn.OnHoverImage = null;
            this.BackBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BackBtn.OnPressedColor = System.Drawing.Color.Black;
            this.BackBtn.Radius = 20;
            this.BackBtn.Size = new System.Drawing.Size(124, 41);
            this.BackBtn.TabIndex = 21;
            this.BackBtn.Text = "Atrás";
            this.BackBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BackBtn.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AnimationHoverSpeed = 0.07F;
            this.DeleteBtn.AnimationSpeed = 0.03F;
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeleteBtn.BorderColor = System.Drawing.Color.Black;
            this.DeleteBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.DeleteBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.DeleteBtn.CheckedForeColor = System.Drawing.Color.White;
            this.DeleteBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.CheckedImage")));
            this.DeleteBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.DeleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Image = null;
            this.DeleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.DeleteBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DeleteBtn.Location = new System.Drawing.Point(588, 155);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.DeleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.DeleteBtn.OnHoverImage = null;
            this.DeleteBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DeleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.DeleteBtn.Radius = 20;
            this.DeleteBtn.Size = new System.Drawing.Size(124, 41);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.Text = "Eliminar";
            this.DeleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteBtn.Click += new System.EventHandler(this.gunaAdvenceButton4_Click);
            // 
            // StudentsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsDGV.BackgroundColor = System.Drawing.Color.White;
            this.StudentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentsDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentsDGV.EnableHeadersVisualStyles = false;
            this.StudentsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentsDGV.Location = new System.Drawing.Point(103, 291);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.RowHeadersVisible = false;
            this.StudentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsDGV.Size = new System.Drawing.Size(932, 360);
            this.StudentsDGV.TabIndex = 22;
            this.StudentsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StudentsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StudentsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StudentsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StudentsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StudentsDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.StudentsDGV.ThemeStyle.ReadOnly = false;
            this.StudentsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StudentsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.StudentsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(469, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Lista de Estudiantes";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SCorreoTb
            // 
            this.SCorreoTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCorreoTb.Location = new System.Drawing.Point(662, 101);
            this.SCorreoTb.Name = "SCorreoTb";
            this.SCorreoTb.Size = new System.Drawing.Size(157, 27);
            this.SCorreoTb.TabIndex = 25;
            // 
            // SSCorreo
            // 
            this.SSCorreo.AutoSize = true;
            this.SSCorreo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSCorreo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SSCorreo.Location = new System.Drawing.Point(658, 76);
            this.SSCorreo.Name = "SSCorreo";
            this.SSCorreo.Size = new System.Drawing.Size(73, 22);
            this.SSCorreo.TabIndex = 24;
            this.SSCorreo.Text = "Correo";
            // 
            // STelefonoTb
            // 
            this.STelefonoTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STelefonoTb.Location = new System.Drawing.Point(865, 101);
            this.STelefonoTb.Name = "STelefonoTb";
            this.STelefonoTb.Size = new System.Drawing.Size(157, 27);
            this.STelefonoTb.TabIndex = 27;
            // 
            // SSTelefono
            // 
            this.SSTelefono.AutoSize = true;
            this.SSTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSTelefono.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SSTelefono.Location = new System.Drawing.Point(861, 76);
            this.SSTelefono.Name = "SSTelefono";
            this.SSTelefono.Size = new System.Drawing.Size(87, 22);
            this.SSTelefono.TabIndex = 26;
            this.SSTelefono.Text = "Teléfono";
            // 
            // SFoto
            // 
            this.SFoto.AutoSize = true;
            this.SFoto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFoto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SFoto.Location = new System.Drawing.Point(61, 76);
            this.SFoto.Name = "SFoto";
            this.SFoto.Size = new System.Drawing.Size(50, 22);
            this.SFoto.TabIndex = 28;
            this.SFoto.Text = "Foto";
            this.SFoto.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(65, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 688);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.SFoto);
            this.Controls.Add(this.STelefonoTb);
            this.Controls.Add(this.SSTelefono);
            this.Controls.Add(this.SCorreoTb);
            this.Controls.Add(this.SSCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StudentsDGV);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.StNameTb);
            this.Controls.Add(this.Snombre);
            this.Controls.Add(this.SMatricula2);
            this.Controls.Add(this.SSid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SMatricula2;
        private System.Windows.Forms.Label SSid;
        private System.Windows.Forms.TextBox StNameTb;
        private System.Windows.Forms.Label Snombre;
        private Guna.UI.WinForms.GunaAdvenceButton SaveBtn;
        private Guna.UI.WinForms.GunaAdvenceButton EditBtn;
        private Guna.UI.WinForms.GunaAdvenceButton BackBtn;
        private Guna.UI.WinForms.GunaAdvenceButton DeleteBtn;
        private Guna.UI.WinForms.GunaDataGridView StudentsDGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SCorreoTb;
        private System.Windows.Forms.Label SSCorreo;
        private System.Windows.Forms.TextBox STelefonoTb;
        private System.Windows.Forms.Label SSTelefono;
        private System.Windows.Forms.Label SFoto;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}