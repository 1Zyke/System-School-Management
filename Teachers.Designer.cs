namespace SchoolManagementSystem
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DeleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.EditBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TeachersDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.TCorreo = new System.Windows.Forms.Label();
            this.TcorreoTb = new System.Windows.Forms.TextBox();
            this.TnombreTb = new System.Windows.Forms.TextBox();
            this.Tnombre = new System.Windows.Forms.Label();
            this.TCodeTb = new System.Windows.Forms.TextBox();
            this.Tcode = new System.Windows.Forms.Label();
            this.tTelefonoTb = new System.Windows.Forms.TextBox();
            this.TTelefono = new System.Windows.Forms.Label();
            this.TMateriaTb = new System.Windows.Forms.TextBox();
            this.Tmateriaa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profesores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(473, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Lista de Profesores";
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
            this.BackBtn.TabIndex = 37;
            this.BackBtn.Text = "Atrás";
            this.BackBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.DeleteBtn.TabIndex = 36;
            this.DeleteBtn.Text = "Eliminar";
            this.DeleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.EditBtn.TabIndex = 35;
            this.EditBtn.Text = "Editar";
            this.EditBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AnimationHoverSpeed = 0.07F;
            this.AddBtn.AnimationSpeed = 0.03F;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddBtn.BorderColor = System.Drawing.Color.Black;
            this.AddBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddBtn.CheckedForeColor = System.Drawing.Color.White;
            this.AddBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.CheckedImage")));
            this.AddBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = null;
            this.AddBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.AddBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddBtn.Location = new System.Drawing.Point(294, 155);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddBtn.OnHoverImage = null;
            this.AddBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddBtn.Radius = 20;
            this.AddBtn.Size = new System.Drawing.Size(124, 41);
            this.AddBtn.TabIndex = 34;
            this.AddBtn.Text = "Agregar";
            this.AddBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TeachersDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TeachersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeachersDGV.BackgroundColor = System.Drawing.Color.White;
            this.TeachersDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeachersDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TeachersDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TeachersDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TeachersDGV.EnableHeadersVisualStyles = false;
            this.TeachersDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeachersDGV.Location = new System.Drawing.Point(107, 287);
            this.TeachersDGV.Name = "TeachersDGV";
            this.TeachersDGV.RowHeadersVisible = false;
            this.TeachersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeachersDGV.Size = new System.Drawing.Size(932, 360);
            this.TeachersDGV.TabIndex = 40;
            this.TeachersDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TeachersDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeachersDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TeachersDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TeachersDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TeachersDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TeachersDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.TeachersDGV.ThemeStyle.ReadOnly = false;
            this.TeachersDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TeachersDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TeachersDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TeachersDGV.ThemeStyle.RowsStyle.Height = 22;
            this.TeachersDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeachersDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TeachersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersDGV_CellContentClick);
            // 
            // TCorreo
            // 
            this.TCorreo.AutoSize = true;
            this.TCorreo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCorreo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TCorreo.Location = new System.Drawing.Point(474, 72);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(73, 22);
            this.TCorreo.TabIndex = 28;
            this.TCorreo.Text = "Correo";
            // 
            // TcorreoTb
            // 
            this.TcorreoTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcorreoTb.Location = new System.Drawing.Point(478, 97);
            this.TcorreoTb.Name = "TcorreoTb";
            this.TcorreoTb.Size = new System.Drawing.Size(157, 27);
            this.TcorreoTb.TabIndex = 29;
            // 
            // TnombreTb
            // 
            this.TnombreTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TnombreTb.Location = new System.Drawing.Point(272, 97);
            this.TnombreTb.Name = "TnombreTb";
            this.TnombreTb.Size = new System.Drawing.Size(157, 27);
            this.TnombreTb.TabIndex = 27;
            // 
            // Tnombre
            // 
            this.Tnombre.AutoSize = true;
            this.Tnombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Tnombre.Location = new System.Drawing.Point(268, 72);
            this.Tnombre.Name = "Tnombre";
            this.Tnombre.Size = new System.Drawing.Size(84, 22);
            this.Tnombre.TabIndex = 26;
            this.Tnombre.Text = "Nombre";
            // 
            // TCodeTb
            // 
            this.TCodeTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCodeTb.Location = new System.Drawing.Point(74, 97);
            this.TCodeTb.Name = "TCodeTb";
            this.TCodeTb.Size = new System.Drawing.Size(157, 27);
            this.TCodeTb.TabIndex = 25;
            // 
            // Tcode
            // 
            this.Tcode.AutoSize = true;
            this.Tcode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Tcode.Location = new System.Drawing.Point(70, 72);
            this.Tcode.Name = "Tcode";
            this.Tcode.Size = new System.Drawing.Size(28, 22);
            this.Tcode.TabIndex = 24;
            this.Tcode.Text = "Id";
            // 
            // tTelefonoTb
            // 
            this.tTelefonoTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTelefonoTb.Location = new System.Drawing.Point(684, 97);
            this.tTelefonoTb.Name = "tTelefonoTb";
            this.tTelefonoTb.Size = new System.Drawing.Size(157, 27);
            this.tTelefonoTb.TabIndex = 42;
            // 
            // TTelefono
            // 
            this.TTelefono.AutoSize = true;
            this.TTelefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTelefono.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TTelefono.Location = new System.Drawing.Point(680, 72);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(87, 22);
            this.TTelefono.TabIndex = 41;
            this.TTelefono.Text = "Teléfono";
            // 
            // TMateriaTb
            // 
            this.TMateriaTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMateriaTb.Location = new System.Drawing.Point(880, 97);
            this.TMateriaTb.Name = "TMateriaTb";
            this.TMateriaTb.Size = new System.Drawing.Size(157, 27);
            this.TMateriaTb.TabIndex = 44;
            // 
            // Tmateriaa
            // 
            this.Tmateriaa.AutoSize = true;
            this.Tmateriaa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tmateriaa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Tmateriaa.Location = new System.Drawing.Point(876, 72);
            this.Tmateriaa.Name = "Tmateriaa";
            this.Tmateriaa.Size = new System.Drawing.Size(81, 22);
            this.Tmateriaa.TabIndex = 43;
            this.Tmateriaa.Text = "Materia";
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 688);
            this.Controls.Add(this.TMateriaTb);
            this.Controls.Add(this.Tmateriaa);
            this.Controls.Add(this.tTelefonoTb);
            this.Controls.Add(this.TTelefono);
            this.Controls.Add(this.TeachersDGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TcorreoTb);
            this.Controls.Add(this.TCorreo);
            this.Controls.Add(this.TnombreTb);
            this.Controls.Add(this.Tnombre);
            this.Controls.Add(this.TCodeTb);
            this.Controls.Add(this.Tcode);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaAdvenceButton BackBtn;
        private Guna.UI.WinForms.GunaAdvenceButton DeleteBtn;
        private Guna.UI.WinForms.GunaAdvenceButton EditBtn;
        private Guna.UI.WinForms.GunaAdvenceButton AddBtn;
        private System.Windows.Forms.Label Tname;
        private Guna.UI.WinForms.GunaDataGridView TeachersDGV;
        private System.Windows.Forms.Label TCorreo;
        private System.Windows.Forms.TextBox TcorreoTb;
        private System.Windows.Forms.TextBox TnombreTb;
        private System.Windows.Forms.Label Tnombre;
        private System.Windows.Forms.TextBox TCodeTb;
        private System.Windows.Forms.Label Tcode;
        private System.Windows.Forms.TextBox tTelefonoTb;
        private System.Windows.Forms.Label TTelefono;
        private System.Windows.Forms.TextBox TMateriaTb;
        private System.Windows.Forms.Label Tmateriaa;
    }
}