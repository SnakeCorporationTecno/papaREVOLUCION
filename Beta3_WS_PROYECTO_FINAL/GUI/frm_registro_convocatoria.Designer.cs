namespace Beta3_WS_PROYECTO_FINAL.GUI
{
    partial class frm_registro_convocatoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar_convocatoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nom_conv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fechainicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechafin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Femenil = new System.Windows.Forms.RadioButton();
            this.rb_Varonil = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_tipoconvocatoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cancelarpersona_registroconv = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_registrarpersona_registroconv = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.EP_convo = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_convo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cerrar_convocatoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 28);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de convocatoria";
            // 
            // btn_cerrar_convocatoria
            // 
            this.btn_cerrar_convocatoria.Activecolor = System.Drawing.Color.Transparent;
            this.btn_cerrar_convocatoria.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_convocatoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar_convocatoria.BorderRadius = 0;
            this.btn_cerrar_convocatoria.ButtonText = "X";
            this.btn_cerrar_convocatoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cerrar_convocatoria.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.btn_cerrar_convocatoria.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_convocatoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cerrar_convocatoria.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cerrar_convocatoria.Iconimage = null;
            this.btn_cerrar_convocatoria.Iconimage_right = null;
            this.btn_cerrar_convocatoria.Iconimage_right_Selected = null;
            this.btn_cerrar_convocatoria.Iconimage_Selected = null;
            this.btn_cerrar_convocatoria.IconMarginLeft = 0;
            this.btn_cerrar_convocatoria.IconMarginRight = 0;
            this.btn_cerrar_convocatoria.IconRightVisible = true;
            this.btn_cerrar_convocatoria.IconRightZoom = 0D;
            this.btn_cerrar_convocatoria.IconVisible = true;
            this.btn_cerrar_convocatoria.IconZoom = 90D;
            this.btn_cerrar_convocatoria.IsTab = false;
            this.btn_cerrar_convocatoria.Location = new System.Drawing.Point(559, 0);
            this.btn_cerrar_convocatoria.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btn_cerrar_convocatoria.Name = "btn_cerrar_convocatoria";
            this.btn_cerrar_convocatoria.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_cerrar_convocatoria.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cerrar_convocatoria.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cerrar_convocatoria.selected = false;
            this.btn_cerrar_convocatoria.Size = new System.Drawing.Size(45, 28);
            this.btn_cerrar_convocatoria.TabIndex = 22;
            this.btn_cerrar_convocatoria.Text = "X";
            this.btn_cerrar_convocatoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cerrar_convocatoria.Textcolor = System.Drawing.Color.White;
            this.btn_cerrar_convocatoria.TextFont = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_cerrar_convocatoria.Click += new System.EventHandler(this.btn_cerrar_convocatoria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la convocatoria";
            // 
            // txt_Nom_conv
            // 
            this.txt_Nom_conv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom_conv.Location = new System.Drawing.Point(18, 75);
            this.txt_Nom_conv.Name = "txt_Nom_conv";
            this.txt_Nom_conv.Size = new System.Drawing.Size(176, 27);
            this.txt_Nom_conv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de finalizacion";
            // 
            // dtp_fechainicio
            // 
            this.dtp_fechainicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechainicio.Location = new System.Drawing.Point(270, 78);
            this.dtp_fechainicio.Name = "dtp_fechainicio";
            this.dtp_fechainicio.Size = new System.Drawing.Size(316, 27);
            this.dtp_fechainicio.TabIndex = 8;
            // 
            // dtp_fechafin
            // 
            this.dtp_fechafin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechafin.Location = new System.Drawing.Point(271, 135);
            this.dtp_fechafin.Name = "dtp_fechafin";
            this.dtp_fechafin.Size = new System.Drawing.Size(315, 27);
            this.dtp_fechafin.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Femenil);
            this.groupBox1.Controls.Add(this.rb_Varonil);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(21, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 52);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rb_Femenil
            // 
            this.rb_Femenil.AutoSize = true;
            this.rb_Femenil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Femenil.Location = new System.Drawing.Point(96, 16);
            this.rb_Femenil.Name = "rb_Femenil";
            this.rb_Femenil.Size = new System.Drawing.Size(87, 25);
            this.rb_Femenil.TabIndex = 1;
            this.rb_Femenil.TabStop = true;
            this.rb_Femenil.Text = "Femenil";
            this.rb_Femenil.UseVisualStyleBackColor = true;
            // 
            // rb_Varonil
            // 
            this.rb_Varonil.AutoSize = true;
            this.rb_Varonil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Varonil.Location = new System.Drawing.Point(6, 16);
            this.rb_Varonil.Name = "rb_Varonil";
            this.rb_Varonil.Size = new System.Drawing.Size(81, 25);
            this.rb_Varonil.TabIndex = 0;
            this.rb_Varonil.TabStop = true;
            this.rb_Varonil.Text = "Varonil";
            this.rb_Varonil.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Categoria";
            // 
            // cb_tipoconvocatoria
            // 
            this.cb_tipoconvocatoria.FormattingEnabled = true;
            this.cb_tipoconvocatoria.Items.AddRange(new object[] {
            "Fut7",
            "Futbol de campo",
            "Futbol profesional"});
            this.cb_tipoconvocatoria.Location = new System.Drawing.Point(274, 194);
            this.cb_tipoconvocatoria.Name = "cb_tipoconvocatoria";
            this.cb_tipoconvocatoria.Size = new System.Drawing.Size(237, 21);
            this.cb_tipoconvocatoria.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo de convocatoria";
            // 
            // btn_cancelarpersona_registroconv
            // 
            this.btn_cancelarpersona_registroconv.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cancelarpersona_registroconv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cancelarpersona_registroconv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelarpersona_registroconv.BorderRadius = 0;
            this.btn_cancelarpersona_registroconv.ButtonText = "Cancelar";
            this.btn_cancelarpersona_registroconv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarpersona_registroconv.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancelarpersona_registroconv.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancelarpersona_registroconv.Iconimage = null;
            this.btn_cancelarpersona_registroconv.Iconimage_right = null;
            this.btn_cancelarpersona_registroconv.Iconimage_right_Selected = null;
            this.btn_cancelarpersona_registroconv.Iconimage_Selected = null;
            this.btn_cancelarpersona_registroconv.IconMarginLeft = 0;
            this.btn_cancelarpersona_registroconv.IconMarginRight = 0;
            this.btn_cancelarpersona_registroconv.IconRightVisible = true;
            this.btn_cancelarpersona_registroconv.IconRightZoom = 0D;
            this.btn_cancelarpersona_registroconv.IconVisible = true;
            this.btn_cancelarpersona_registroconv.IconZoom = 90D;
            this.btn_cancelarpersona_registroconv.IsTab = false;
            this.btn_cancelarpersona_registroconv.Location = new System.Drawing.Point(162, 233);
            this.btn_cancelarpersona_registroconv.Name = "btn_cancelarpersona_registroconv";
            this.btn_cancelarpersona_registroconv.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cancelarpersona_registroconv.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.btn_cancelarpersona_registroconv.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancelarpersona_registroconv.selected = false;
            this.btn_cancelarpersona_registroconv.Size = new System.Drawing.Size(124, 32);
            this.btn_cancelarpersona_registroconv.TabIndex = 49;
            this.btn_cancelarpersona_registroconv.Text = "Cancelar";
            this.btn_cancelarpersona_registroconv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelarpersona_registroconv.Textcolor = System.Drawing.Color.White;
            this.btn_cancelarpersona_registroconv.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarpersona_registroconv.Click += new System.EventHandler(this.btn_cancelarpersona_registroconv_Click);
            // 
            // btn_registrarpersona_registroconv
            // 
            this.btn_registrarpersona_registroconv.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_registrarpersona_registroconv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_registrarpersona_registroconv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrarpersona_registroconv.BorderRadius = 0;
            this.btn_registrarpersona_registroconv.ButtonText = "Registrar";
            this.btn_registrarpersona_registroconv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrarpersona_registroconv.DisabledColor = System.Drawing.Color.Gray;
            this.btn_registrarpersona_registroconv.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_registrarpersona_registroconv.Iconimage = null;
            this.btn_registrarpersona_registroconv.Iconimage_right = null;
            this.btn_registrarpersona_registroconv.Iconimage_right_Selected = null;
            this.btn_registrarpersona_registroconv.Iconimage_Selected = null;
            this.btn_registrarpersona_registroconv.IconMarginLeft = 0;
            this.btn_registrarpersona_registroconv.IconMarginRight = 0;
            this.btn_registrarpersona_registroconv.IconRightVisible = true;
            this.btn_registrarpersona_registroconv.IconRightZoom = 0D;
            this.btn_registrarpersona_registroconv.IconVisible = true;
            this.btn_registrarpersona_registroconv.IconZoom = 90D;
            this.btn_registrarpersona_registroconv.IsTab = false;
            this.btn_registrarpersona_registroconv.Location = new System.Drawing.Point(300, 233);
            this.btn_registrarpersona_registroconv.Name = "btn_registrarpersona_registroconv";
            this.btn_registrarpersona_registroconv.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_registrarpersona_registroconv.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(114)))));
            this.btn_registrarpersona_registroconv.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_registrarpersona_registroconv.selected = false;
            this.btn_registrarpersona_registroconv.Size = new System.Drawing.Size(124, 32);
            this.btn_registrarpersona_registroconv.TabIndex = 48;
            this.btn_registrarpersona_registroconv.Text = "Registrar";
            this.btn_registrarpersona_registroconv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_registrarpersona_registroconv.Textcolor = System.Drawing.Color.White;
            this.btn_registrarpersona_registroconv.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarpersona_registroconv.Click += new System.EventHandler(this.btn_registrarpersona_registroconv_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 9;
            this.bunifuElipse1.TargetControl = this.btn_cancelarpersona_registroconv;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 9;
            this.bunifuElipse2.TargetControl = this.btn_registrarpersona_registroconv;
            // 
            // EP_convo
            // 
            this.EP_convo.ContainerControl = this;
            // 
            // frm_registro_convocatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 288);
            this.Controls.Add(this.btn_cancelarpersona_registroconv);
            this.Controls.Add(this.btn_registrarpersona_registroconv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_tipoconvocatoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_fechafin);
            this.Controls.Add(this.dtp_fechainicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nom_conv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_registro_convocatoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_registro_convocatoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_convo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cerrar_convocatoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nom_conv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_fechainicio;
        private System.Windows.Forms.DateTimePicker dtp_fechafin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Femenil;
        private System.Windows.Forms.RadioButton rb_Varonil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_tipoconvocatoria;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancelarpersona_registroconv;
        private Bunifu.Framework.UI.BunifuFlatButton btn_registrarpersona_registroconv;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ErrorProvider EP_convo;
    }
}