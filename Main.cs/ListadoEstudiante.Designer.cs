
namespace Main.cs
{
    partial class ListadoEstudiante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.checkDeuda = new Guna.UI.WinForms.GunaCheckBox();
            this.dtgListado = new Guna.UI.WinForms.GunaDataGridView();
            this.comboCurso = new Guna.UI.WinForms.GunaComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.comboServicio = new Guna.UI.WinForms.GunaComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gunaPanel1.Controls.Add(this.checkDeuda);
            this.gunaPanel1.Controls.Add(this.dtgListado);
            this.gunaPanel1.Controls.Add(this.comboCurso);
            this.gunaPanel1.Controls.Add(this.label9);
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.txtBuscar);
            this.gunaPanel1.Controls.Add(this.comboServicio);
            this.gunaPanel1.Controls.Add(this.label10);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(995, 662);
            this.gunaPanel1.TabIndex = 0;
            // 
            // checkDeuda
            // 
            this.checkDeuda.BaseColor = System.Drawing.Color.White;
            this.checkDeuda.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkDeuda.CheckedOnColor = System.Drawing.Color.Black;
            this.checkDeuda.FillColor = System.Drawing.Color.White;
            this.checkDeuda.Location = new System.Drawing.Point(920, 234);
            this.checkDeuda.Name = "checkDeuda";
            this.checkDeuda.Size = new System.Drawing.Size(63, 20);
            this.checkDeuda.TabIndex = 53;
            this.checkDeuda.Text = "Deuda";
            this.checkDeuda.CheckedChanged += new System.EventHandler(this.checkDeuda_CheckedChanged_1);
            // 
            // dtgListado
            // 
            this.dtgListado.AllowUserToAddRows = false;
            this.dtgListado.AllowUserToDeleteRows = false;
            this.dtgListado.AllowUserToResizeColumns = false;
            this.dtgListado.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListado.BackgroundColor = System.Drawing.Color.White;
            this.dtgListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListado.ColumnHeadersHeight = 15;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgListado.EnableHeadersVisualStyles = false;
            this.dtgListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgListado.Location = new System.Drawing.Point(0, 283);
            this.dtgListado.Name = "dtgListado";
            this.dtgListado.RowHeadersVisible = false;
            this.dtgListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListado.Size = new System.Drawing.Size(995, 379);
            this.dtgListado.TabIndex = 52;
            this.dtgListado.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgListado.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgListado.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgListado.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgListado.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgListado.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgListado.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgListado.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgListado.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dtgListado.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgListado.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgListado.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgListado.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgListado.ThemeStyle.HeaderStyle.Height = 15;
            this.dtgListado.ThemeStyle.ReadOnly = false;
            this.dtgListado.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgListado.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgListado.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgListado.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgListado.ThemeStyle.RowsStyle.Height = 22;
            this.dtgListado.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgListado.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListado_CellDoubleClick_1);
            // 
            // comboCurso
            // 
            this.comboCurso.BackColor = System.Drawing.Color.Transparent;
            this.comboCurso.BaseColor = System.Drawing.Color.White;
            this.comboCurso.BorderColor = System.Drawing.Color.Silver;
            this.comboCurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurso.Enabled = false;
            this.comboCurso.FocusedColor = System.Drawing.Color.Empty;
            this.comboCurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCurso.ForeColor = System.Drawing.Color.Black;
            this.comboCurso.FormattingEnabled = true;
            this.comboCurso.Location = new System.Drawing.Point(621, 194);
            this.comboCurso.Name = "comboCurso";
            this.comboCurso.OnHoverItemBaseColor = System.Drawing.Color.Gray;
            this.comboCurso.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboCurso.Size = new System.Drawing.Size(121, 26);
            this.comboCurso.TabIndex = 51;
            this.comboCurso.SelectedIndexChanged += new System.EventHandler(this.comboCurso_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label9.Location = new System.Drawing.Point(581, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Curso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Main.cs.Properties.Resources.icons8_search_50px;
            this.pictureBox1.Location = new System.Drawing.Point(692, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BaseColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscar.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtBuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(227, 106);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(515, 41);
            this.txtBuscar.TabIndex = 48;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // comboServicio
            // 
            this.comboServicio.AccessibleName = "";
            this.comboServicio.BackColor = System.Drawing.Color.Transparent;
            this.comboServicio.BaseColor = System.Drawing.Color.White;
            this.comboServicio.BorderColor = System.Drawing.Color.Silver;
            this.comboServicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServicio.FocusedColor = System.Drawing.Color.Empty;
            this.comboServicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboServicio.ForeColor = System.Drawing.Color.Black;
            this.comboServicio.FormattingEnabled = true;
            this.comboServicio.Items.AddRange(new object[] {
            "",
            "Inicial",
            "Primario",
            "Secundario"});
            this.comboServicio.Location = new System.Drawing.Point(275, 194);
            this.comboServicio.Name = "comboServicio";
            this.comboServicio.OnHoverItemBaseColor = System.Drawing.Color.Gray;
            this.comboServicio.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboServicio.Size = new System.Drawing.Size(121, 26);
            this.comboServicio.TabIndex = 47;
            this.comboServicio.SelectedIndexChanged += new System.EventHandler(this.comboServicio_SelectedIndexChanged_1);
            // 
            // label10
            // 
            this.label10.AccessibleName = "comboServicio";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label10.Location = new System.Drawing.Point(223, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Servicio";
            // 
            // ListadoEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 662);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "ListadoEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoEstudiante";
            this.Load += new System.EventHandler(this.ListadoEstudiante_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtBuscar;
        private Guna.UI.WinForms.GunaComboBox comboServicio;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaComboBox comboCurso;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaDataGridView dtgListado;
        private Guna.UI.WinForms.GunaCheckBox checkDeuda;
    }
}