namespace Main.cs
{
    partial class Main
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.Gunabtn = new Guna.UI.WinForms.GunaImageButton();
            this.btnListado = new Guna.UI.WinForms.GunaButton();
            this.btnAgregar = new Guna.UI.WinForms.GunaButton();
            this.btnAdmin = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2_Top = new Guna.UI.WinForms.GunaPanel();
            this.Gunapict = new Guna.UI.WinForms.GunaPictureBox();
            this.Gunalb = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel2_Container = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gunapict)).BeginInit();
            this.gunaPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.Gunabtn);
            this.gunaPanel1.Controls.Add(this.btnListado);
            this.gunaPanel1.Controls.Add(this.btnAgregar);
            this.gunaPanel1.Controls.Add(this.btnAdmin);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(205, 754);
            this.gunaPanel1.TabIndex = 4;
            // 
            // Gunabtn
            // 
            this.Gunabtn.BackgroundImage = global::Main.cs.Properties.Resources._removal_ai__c4fd010a_edd8_42fd_b0dd_fac6bb2ef2e3;
            this.Gunabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gunabtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Gunabtn.Image = null;
            this.Gunabtn.ImageSize = new System.Drawing.Size(64, 64);
            this.Gunabtn.Location = new System.Drawing.Point(0, 0);
            this.Gunabtn.Name = "Gunabtn";
            this.Gunabtn.OnHoverImage = null;
            this.Gunabtn.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.Gunabtn.Size = new System.Drawing.Size(205, 122);
            this.Gunabtn.TabIndex = 12;
            this.Gunabtn.Click += new System.EventHandler(this.Gunabtn_Click);
            // 
            // btnListado
            // 
            this.btnListado.AnimationHoverSpeed = 0.07F;
            this.btnListado.AnimationSpeed = 0.03F;
            this.btnListado.BaseColor = System.Drawing.Color.Transparent;
            this.btnListado.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnListado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnListado.FocusedColor = System.Drawing.Color.Empty;
            this.btnListado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListado.ForeColor = System.Drawing.Color.Black;
            this.btnListado.Image = global::Main.cs.Properties.Resources.listing_option;
            this.btnListado.ImageSize = new System.Drawing.Size(20, 20);
            this.btnListado.Location = new System.Drawing.Point(3, 271);
            this.btnListado.Name = "btnListado";
            this.btnListado.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btnListado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnListado.OnHoverForeColor = System.Drawing.Color.White;
            this.btnListado.OnHoverImage = null;
            this.btnListado.OnPressedColor = System.Drawing.Color.Black;
            this.btnListado.Size = new System.Drawing.Size(199, 42);
            this.btnListado.TabIndex = 9;
            this.btnListado.Text = "Listado";
            this.btnListado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AnimationHoverSpeed = 0.07F;
            this.btnAgregar.AnimationSpeed = 0.03F;
            this.btnAgregar.BaseColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::Main.cs.Properties.Resources.plus_symbol_in_a_rounded_black_square;
            this.btnAgregar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregar.Location = new System.Drawing.Point(3, 219);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnHoverImage = null;
            this.btnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregar.Size = new System.Drawing.Size(199, 42);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AnimationHoverSpeed = 0.07F;
            this.btnAdmin.AnimationSpeed = 0.03F;
            this.btnAdmin.BaseColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdmin.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Image = global::Main.cs.Properties.Resources.user_shape;
            this.btnAdmin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdmin.Location = new System.Drawing.Point(3, 171);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdmin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdmin.OnHoverImage = null;
            this.btnAdmin.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdmin.Size = new System.Drawing.Size(199, 42);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // gunaPanel2_Top
            // 
            this.gunaPanel2_Top.Controls.Add(this.Gunapict);
            this.gunaPanel2_Top.Controls.Add(this.Gunalb);
            this.gunaPanel2_Top.Controls.Add(this.gunaControlBox3);
            this.gunaPanel2_Top.Controls.Add(this.gunaControlBox1);
            this.gunaPanel2_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2_Top.ForeColor = System.Drawing.Color.Black;
            this.gunaPanel2_Top.Location = new System.Drawing.Point(205, 0);
            this.gunaPanel2_Top.Name = "gunaPanel2_Top";
            this.gunaPanel2_Top.Size = new System.Drawing.Size(995, 41);
            this.gunaPanel2_Top.TabIndex = 5;
            this.gunaPanel2_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // Gunapict
            // 
            this.Gunapict.BaseColor = System.Drawing.Color.White;
            this.Gunapict.Location = new System.Drawing.Point(4, 3);
            this.Gunapict.Name = "Gunapict";
            this.Gunapict.Size = new System.Drawing.Size(57, 36);
            this.Gunapict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gunapict.TabIndex = 41;
            this.Gunapict.TabStop = false;
            // 
            // Gunalb
            // 
            this.Gunalb.AutoSize = true;
            this.Gunalb.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Gunalb.ForeColor = System.Drawing.Color.DimGray;
            this.Gunalb.Location = new System.Drawing.Point(67, 3);
            this.Gunalb.Name = "Gunalb";
            this.Gunalb.Size = new System.Drawing.Size(0, 32);
            this.Gunalb.TabIndex = 39;
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
            this.gunaControlBox3.Location = new System.Drawing.Point(905, 3);
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
            this.gunaControlBox1.Location = new System.Drawing.Point(947, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Silver;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 6;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel2_Top;
            // 
            // gunaPanel2_Container
            // 
            this.gunaPanel2_Container.Controls.Add(this.gunaPictureBox3);
            this.gunaPanel2_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2_Container.Location = new System.Drawing.Point(205, 41);
            this.gunaPanel2_Container.Name = "gunaPanel2_Container";
            this.gunaPanel2_Container.Size = new System.Drawing.Size(995, 713);
            this.gunaPanel2_Container.TabIndex = 6;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPictureBox3.Image = global::Main.cs.Properties.Resources._2881;
            this.gunaPictureBox3.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(995, 713);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox3.TabIndex = 12;
            this.gunaPictureBox3.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 754);
            this.Controls.Add(this.gunaPanel2_Container);
            this.Controls.Add(this.gunaPanel2_Top);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante_Form";
            this.Load += new System.EventHandler(this.Estudiante_Form_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2_Top.ResumeLayout(false);
            this.gunaPanel2_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gunapict)).EndInit();
            this.gunaPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2_Top;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaButton btnAdmin;
        private Guna.UI.WinForms.GunaButton btnListado;
        private Guna.UI.WinForms.GunaButton btnAgregar;
        private Guna.UI.WinForms.GunaLabel Gunalb;
        private Guna.UI.WinForms.GunaPictureBox Gunapict;
        private Guna.UI.WinForms.GunaImageButton Gunabtn;
        private Guna.UI.WinForms.GunaPanel gunaPanel2_Container;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
    }
}