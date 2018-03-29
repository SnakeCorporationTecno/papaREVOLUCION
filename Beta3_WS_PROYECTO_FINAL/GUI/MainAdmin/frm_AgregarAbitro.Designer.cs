namespace Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin
{
    partial class frm_AgregarAbitro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.frm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_nombreArbitro = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apePat_Arbitro = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apeMat_Arbitro = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbn_hombre_arbitro = new System.Windows.Forms.RadioButton();
            this.rbn_mujer_Arbitro = new System.Windows.Forms.RadioButton();
            this.btn_cancelarpersona_registroArb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_registrarpersona_registroArb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 408);
            this.panel1.TabIndex = 0;
            // 
            // frm
            // 
            this.frm.ElipseRadius = 15;
            this.frm.TargetControl = this;
            // 
            // txt_nombreArbitro
            // 
            this.txt_nombreArbitro.BorderColorFocused = System.Drawing.Color.DeepPink;
            this.txt_nombreArbitro.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombreArbitro.BorderColorMouseHover = System.Drawing.Color.MediumVioletRed;
            this.txt_nombreArbitro.BorderThickness = 3;
            this.txt_nombreArbitro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombreArbitro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_nombreArbitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombreArbitro.isPassword = false;
            this.txt_nombreArbitro.Location = new System.Drawing.Point(27, 40);
            this.txt_nombreArbitro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreArbitro.Name = "txt_nombreArbitro";
            this.txt_nombreArbitro.Size = new System.Drawing.Size(370, 37);
            this.txt_nombreArbitro.TabIndex = 1;
            this.txt_nombreArbitro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido paterno";
            // 
            // txt_apePat_Arbitro
            // 
            this.txt_apePat_Arbitro.BorderColorFocused = System.Drawing.Color.DeepPink;
            this.txt_apePat_Arbitro.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_apePat_Arbitro.BorderColorMouseHover = System.Drawing.Color.MediumVioletRed;
            this.txt_apePat_Arbitro.BorderThickness = 3;
            this.txt_apePat_Arbitro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apePat_Arbitro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_apePat_Arbitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_apePat_Arbitro.isPassword = false;
            this.txt_apePat_Arbitro.Location = new System.Drawing.Point(27, 120);
            this.txt_apePat_Arbitro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apePat_Arbitro.Name = "txt_apePat_Arbitro";
            this.txt_apePat_Arbitro.Size = new System.Drawing.Size(370, 37);
            this.txt_apePat_Arbitro.TabIndex = 3;
            this.txt_apePat_Arbitro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido materno";
            // 
            // txt_apeMat_Arbitro
            // 
            this.txt_apeMat_Arbitro.BorderColorFocused = System.Drawing.Color.DeepPink;
            this.txt_apeMat_Arbitro.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_apeMat_Arbitro.BorderColorMouseHover = System.Drawing.Color.MediumVioletRed;
            this.txt_apeMat_Arbitro.BorderThickness = 3;
            this.txt_apeMat_Arbitro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apeMat_Arbitro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_apeMat_Arbitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_apeMat_Arbitro.isPassword = false;
            this.txt_apeMat_Arbitro.Location = new System.Drawing.Point(27, 199);
            this.txt_apeMat_Arbitro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apeMat_Arbitro.Name = "txt_apeMat_Arbitro";
            this.txt_apeMat_Arbitro.Size = new System.Drawing.Size(370, 37);
            this.txt_apeMat_Arbitro.TabIndex = 5;
            this.txt_apeMat_Arbitro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbn_mujer_Arbitro);
            this.groupBox1.Controls.Add(this.rbn_hombre_arbitro);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 84);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // rbn_hombre_arbitro
            // 
            this.rbn_hombre_arbitro.AutoSize = true;
            this.rbn_hombre_arbitro.Location = new System.Drawing.Point(31, 37);
            this.rbn_hombre_arbitro.Name = "rbn_hombre_arbitro";
            this.rbn_hombre_arbitro.Size = new System.Drawing.Size(101, 26);
            this.rbn_hombre_arbitro.TabIndex = 0;
            this.rbn_hombre_arbitro.TabStop = true;
            this.rbn_hombre_arbitro.Text = "Hombre";
            this.rbn_hombre_arbitro.UseVisualStyleBackColor = true;
            // 
            // rbn_mujer_Arbitro
            // 
            this.rbn_mujer_Arbitro.AutoSize = true;
            this.rbn_mujer_Arbitro.Location = new System.Drawing.Point(162, 37);
            this.rbn_mujer_Arbitro.Name = "rbn_mujer_Arbitro";
            this.rbn_mujer_Arbitro.Size = new System.Drawing.Size(78, 26);
            this.rbn_mujer_Arbitro.TabIndex = 1;
            this.rbn_mujer_Arbitro.TabStop = true;
            this.rbn_mujer_Arbitro.Text = "Mujer";
            this.rbn_mujer_Arbitro.UseVisualStyleBackColor = true;
            // 
            // btn_cancelarpersona_registroArb
            // 
            this.btn_cancelarpersona_registroArb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cancelarpersona_registroArb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cancelarpersona_registroArb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelarpersona_registroArb.BorderRadius = 0;
            this.btn_cancelarpersona_registroArb.ButtonText = "Cancelar";
            this.btn_cancelarpersona_registroArb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarpersona_registroArb.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancelarpersona_registroArb.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancelarpersona_registroArb.Iconimage = null;
            this.btn_cancelarpersona_registroArb.Iconimage_right = null;
            this.btn_cancelarpersona_registroArb.Iconimage_right_Selected = null;
            this.btn_cancelarpersona_registroArb.Iconimage_Selected = null;
            this.btn_cancelarpersona_registroArb.IconMarginLeft = 0;
            this.btn_cancelarpersona_registroArb.IconMarginRight = 0;
            this.btn_cancelarpersona_registroArb.IconRightVisible = true;
            this.btn_cancelarpersona_registroArb.IconRightZoom = 0D;
            this.btn_cancelarpersona_registroArb.IconVisible = true;
            this.btn_cancelarpersona_registroArb.IconZoom = 90D;
            this.btn_cancelarpersona_registroArb.IsTab = false;
            this.btn_cancelarpersona_registroArb.Location = new System.Drawing.Point(87, 336);
            this.btn_cancelarpersona_registroArb.Name = "btn_cancelarpersona_registroArb";
            this.btn_cancelarpersona_registroArb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cancelarpersona_registroArb.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.btn_cancelarpersona_registroArb.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancelarpersona_registroArb.selected = false;
            this.btn_cancelarpersona_registroArb.Size = new System.Drawing.Size(124, 32);
            this.btn_cancelarpersona_registroArb.TabIndex = 51;
            this.btn_cancelarpersona_registroArb.Text = "Cancelar";
            this.btn_cancelarpersona_registroArb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelarpersona_registroArb.Textcolor = System.Drawing.Color.White;
            this.btn_cancelarpersona_registroArb.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_registrarpersona_registroArb
            // 
            this.btn_registrarpersona_registroArb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_registrarpersona_registroArb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_registrarpersona_registroArb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrarpersona_registroArb.BorderRadius = 0;
            this.btn_registrarpersona_registroArb.ButtonText = "Registrar";
            this.btn_registrarpersona_registroArb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrarpersona_registroArb.DisabledColor = System.Drawing.Color.Gray;
            this.btn_registrarpersona_registroArb.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_registrarpersona_registroArb.Iconimage = null;
            this.btn_registrarpersona_registroArb.Iconimage_right = null;
            this.btn_registrarpersona_registroArb.Iconimage_right_Selected = null;
            this.btn_registrarpersona_registroArb.Iconimage_Selected = null;
            this.btn_registrarpersona_registroArb.IconMarginLeft = 0;
            this.btn_registrarpersona_registroArb.IconMarginRight = 0;
            this.btn_registrarpersona_registroArb.IconRightVisible = true;
            this.btn_registrarpersona_registroArb.IconRightZoom = 0D;
            this.btn_registrarpersona_registroArb.IconVisible = true;
            this.btn_registrarpersona_registroArb.IconZoom = 90D;
            this.btn_registrarpersona_registroArb.IsTab = false;
            this.btn_registrarpersona_registroArb.Location = new System.Drawing.Point(225, 336);
            this.btn_registrarpersona_registroArb.Name = "btn_registrarpersona_registroArb";
            this.btn_registrarpersona_registroArb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_registrarpersona_registroArb.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(114)))));
            this.btn_registrarpersona_registroArb.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_registrarpersona_registroArb.selected = false;
            this.btn_registrarpersona_registroArb.Size = new System.Drawing.Size(124, 32);
            this.btn_registrarpersona_registroArb.TabIndex = 50;
            this.btn_registrarpersona_registroArb.Text = "Registrar";
            this.btn_registrarpersona_registroArb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_registrarpersona_registroArb.Textcolor = System.Drawing.Color.White;
            this.btn_registrarpersona_registroArb.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 9;
            this.bunifuElipse1.TargetControl = this.btn_cancelarpersona_registroArb;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 9;
            this.bunifuElipse2.TargetControl = this.btn_registrarpersona_registroArb;
            // 
            // frm_AgregarAbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 408);
            this.Controls.Add(this.btn_cancelarpersona_registroArb);
            this.Controls.Add(this.btn_registrarpersona_registroArb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_apeMat_Arbitro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_apePat_Arbitro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombreArbitro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AgregarAbitro";
            this.Text = "frm_AgregarAbitro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse frm;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_nombreArbitro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbn_mujer_Arbitro;
        private System.Windows.Forms.RadioButton rbn_hombre_arbitro;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_apeMat_Arbitro;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_apePat_Arbitro;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancelarpersona_registroArb;
        private Bunifu.Framework.UI.BunifuFlatButton btn_registrarpersona_registroArb;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}