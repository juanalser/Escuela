
namespace Main.cs
{
    partial class Almacen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btGuardar = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2_Top = new Guna.UI.WinForms.GunaPanel();
            this.dtgMontos = new System.Windows.Forms.DataGridView();
            this.Gunalb = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.dtgAlmacen = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel2_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Controls.Add(this.btGuardar);
            this.gunaPanel1.Controls.Add(this.gunaPanel2_Top);
            this.gunaPanel1.Controls.Add(this.dtgAlmacen);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(995, 342);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Location = new System.Drawing.Point(837, 49);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(153, 155);
            this.gunaPanel2.TabIndex = 83;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(10, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(135, 15);
            this.gunaLabel1.TabIndex = 82;
            this.gunaLabel1.Text = "Estudiante Seleccionado";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btGuardar
            // 
            this.btGuardar.AnimationHoverSpeed = 0.07F;
            this.btGuardar.AnimationSpeed = 0.03F;
            this.btGuardar.BaseColor = System.Drawing.Color.Transparent;
            this.btGuardar.BorderColor = System.Drawing.Color.Black;
            this.btGuardar.BorderSize = 1;
            this.btGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btGuardar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btGuardar.Image = null;
            this.btGuardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btGuardar.Location = new System.Drawing.Point(837, 210);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btGuardar.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.btGuardar.OnHoverForeColor = System.Drawing.Color.Black;
            this.btGuardar.OnHoverImage = null;
            this.btGuardar.OnPressedColor = System.Drawing.Color.Gray;
            this.btGuardar.Size = new System.Drawing.Size(153, 127);
            this.btGuardar.TabIndex = 50;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // gunaPanel2_Top
            // 
            this.gunaPanel2_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2_Top.Controls.Add(this.dtgMontos);
            this.gunaPanel2_Top.Controls.Add(this.Gunalb);
            this.gunaPanel2_Top.Controls.Add(this.gunaControlBox3);
            this.gunaPanel2_Top.Controls.Add(this.gunaControlBox1);
            this.gunaPanel2_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2_Top.ForeColor = System.Drawing.Color.Black;
            this.gunaPanel2_Top.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2_Top.Name = "gunaPanel2_Top";
            this.gunaPanel2_Top.Size = new System.Drawing.Size(993, 43);
            this.gunaPanel2_Top.TabIndex = 81;
            // 
            // dtgMontos
            // 
            this.dtgMontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMontos.Location = new System.Drawing.Point(429, 10);
            this.dtgMontos.Name = "dtgMontos";
            this.dtgMontos.Size = new System.Drawing.Size(24, 25);
            this.dtgMontos.TabIndex = 82;
            this.dtgMontos.Visible = false;
            // 
            // Gunalb
            // 
            this.Gunalb.AutoSize = true;
            this.Gunalb.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Gunalb.ForeColor = System.Drawing.Color.DimGray;
            this.Gunalb.Location = new System.Drawing.Point(12, 3);
            this.Gunalb.Name = "Gunalb";
            this.Gunalb.Size = new System.Drawing.Size(259, 32);
            this.Gunalb.TabIndex = 40;
            this.Gunalb.Text = "Estudiantes Archivados";
            this.Gunalb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(901, 3);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.DarkGray;
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox3.TabIndex = 8;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(943, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Silver;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 6;
            // 
            // dtgAlmacen
            // 
            this.dtgAlmacen.AllowUserToAddRows = false;
            this.dtgAlmacen.AllowUserToDeleteRows = false;
            this.dtgAlmacen.AllowUserToResizeColumns = false;
            this.dtgAlmacen.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgAlmacen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAlmacen.BackgroundColor = System.Drawing.Color.White;
            this.dtgAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAlmacen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgAlmacen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAlmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgAlmacen.ColumnHeadersHeight = 15;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAlmacen.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgAlmacen.EnableHeadersVisualStyles = false;
            this.dtgAlmacen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgAlmacen.Location = new System.Drawing.Point(3, 49);
            this.dtgAlmacen.Name = "dtgAlmacen";
            this.dtgAlmacen.ReadOnly = true;
            this.dtgAlmacen.RowHeadersVisible = false;
            this.dtgAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlmacen.Size = new System.Drawing.Size(828, 288);
            this.dtgAlmacen.TabIndex = 55;
            this.dtgAlmacen.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgAlmacen.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgAlmacen.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgAlmacen.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgAlmacen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgAlmacen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgAlmacen.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgAlmacen.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgAlmacen.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dtgAlmacen.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgAlmacen.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgAlmacen.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgAlmacen.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgAlmacen.ThemeStyle.HeaderStyle.Height = 15;
            this.dtgAlmacen.ThemeStyle.ReadOnly = true;
            this.dtgAlmacen.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgAlmacen.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgAlmacen.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgAlmacen.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgAlmacen.ThemeStyle.RowsStyle.Height = 22;
            this.dtgAlmacen.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgAlmacen.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgAlmacen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlmacen_CellContentClick_1);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel2_Top;
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 342);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Almacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.Almacen_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel2_Top.ResumeLayout(false);
            this.gunaPanel2_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlmacen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaDataGridView dtgAlmacen;
        private Guna.UI.WinForms.GunaPanel gunaPanel2_Top;
        private Guna.UI.WinForms.GunaLabel Gunalb;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaButton btGuardar;
        private System.Windows.Forms.DataGridView dtgMontos;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}