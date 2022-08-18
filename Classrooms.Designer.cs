namespace SchoolManagementSystem
{
    partial class Classrooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classrooms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClassRoomsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.BackBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DeleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.EditBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Capacitylbl = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.Label();
            this.classnamelbl = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.IdCode = new System.Windows.Forms.TextBox();
            this.ide = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassRoomsDGV)).BeginInit();
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
            this.panel1.TabIndex = 5;
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
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aulas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(481, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 71;
            this.label7.Text = "Lista de Aulas";
            // 
            // ClassRoomsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ClassRoomsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassRoomsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassRoomsDGV.BackgroundColor = System.Drawing.Color.White;
            this.ClassRoomsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassRoomsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClassRoomsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassRoomsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClassRoomsDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassRoomsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClassRoomsDGV.EnableHeadersVisualStyles = false;
            this.ClassRoomsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClassRoomsDGV.Location = new System.Drawing.Point(103, 293);
            this.ClassRoomsDGV.Name = "ClassRoomsDGV";
            this.ClassRoomsDGV.RowHeadersVisible = false;
            this.ClassRoomsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassRoomsDGV.Size = new System.Drawing.Size(932, 360);
            this.ClassRoomsDGV.TabIndex = 70;
            this.ClassRoomsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ClassRoomsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ClassRoomsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClassRoomsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClassRoomsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClassRoomsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClassRoomsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ClassRoomsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClassRoomsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ClassRoomsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClassRoomsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ClassRoomsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ClassRoomsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClassRoomsDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.ClassRoomsDGV.ThemeStyle.ReadOnly = false;
            this.ClassRoomsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ClassRoomsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClassRoomsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ClassRoomsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ClassRoomsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ClassRoomsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClassRoomsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ClassRoomsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassRoomsDGV_CellContentClick);
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
            this.BackBtn.Location = new System.Drawing.Point(733, 157);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BackBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BackBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.BackBtn.OnHoverImage = null;
            this.BackBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BackBtn.OnPressedColor = System.Drawing.Color.Black;
            this.BackBtn.Radius = 20;
            this.BackBtn.Size = new System.Drawing.Size(124, 41);
            this.BackBtn.TabIndex = 69;
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
            this.DeleteBtn.Location = new System.Drawing.Point(588, 157);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.DeleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.DeleteBtn.OnHoverImage = null;
            this.DeleteBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.DeleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.DeleteBtn.Radius = 20;
            this.DeleteBtn.Size = new System.Drawing.Size(124, 41);
            this.DeleteBtn.TabIndex = 68;
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
            this.EditBtn.Location = new System.Drawing.Point(441, 157);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EditBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.EditBtn.OnHoverImage = null;
            this.EditBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditBtn.OnPressedColor = System.Drawing.Color.Black;
            this.EditBtn.Radius = 20;
            this.EditBtn.Size = new System.Drawing.Size(124, 41);
            this.EditBtn.TabIndex = 67;
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
            this.AddBtn.Location = new System.Drawing.Point(294, 157);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddBtn.OnHoverImage = null;
            this.AddBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddBtn.Radius = 20;
            this.AddBtn.Size = new System.Drawing.Size(124, 41);
            this.AddBtn.TabIndex = 66;
            this.AddBtn.Text = "Agregar";
            this.AddBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Capacitylbl
            // 
            this.Capacitylbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacitylbl.Location = new System.Drawing.Point(701, 101);
            this.Capacitylbl.Name = "Capacitylbl";
            this.Capacitylbl.Size = new System.Drawing.Size(157, 27);
            this.Capacitylbl.TabIndex = 61;
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.capacity.Location = new System.Drawing.Point(697, 76);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(118, 22);
            this.capacity.TabIndex = 60;
            this.capacity.Text = "Capacidad";
            // 
            // classnamelbl
            // 
            this.classnamelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classnamelbl.Location = new System.Drawing.Point(495, 101);
            this.classnamelbl.Name = "classnamelbl";
            this.classnamelbl.Size = new System.Drawing.Size(157, 27);
            this.classnamelbl.TabIndex = 59;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.name.Location = new System.Drawing.Point(491, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(84, 22);
            this.name.TabIndex = 58;
            this.name.Text = "Nombre";
            // 
            // IdCode
            // 
            this.IdCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCode.Location = new System.Drawing.Point(286, 101);
            this.IdCode.Name = "IdCode";
            this.IdCode.Size = new System.Drawing.Size(157, 27);
            this.IdCode.TabIndex = 73;
            // 
            // ide
            // 
            this.ide.AutoSize = true;
            this.ide.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ide.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ide.Location = new System.Drawing.Point(282, 76);
            this.ide.Name = "ide";
            this.ide.Size = new System.Drawing.Size(28, 22);
            this.ide.TabIndex = 72;
            this.ide.Text = "Id";
            // 
            // Classrooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 688);
            this.Controls.Add(this.IdCode);
            this.Controls.Add(this.ide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClassRoomsDGV);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Capacitylbl);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.classnamelbl);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Classrooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classrooms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassRoomsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaDataGridView ClassRoomsDGV;
        private Guna.UI.WinForms.GunaAdvenceButton BackBtn;
        private Guna.UI.WinForms.GunaAdvenceButton DeleteBtn;
        private Guna.UI.WinForms.GunaAdvenceButton EditBtn;
        private Guna.UI.WinForms.GunaAdvenceButton AddBtn;
        private System.Windows.Forms.TextBox Capacitylbl;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.TextBox classnamelbl;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox IdCode;
        private System.Windows.Forms.Label ide;
    }
}