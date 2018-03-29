namespace Beta3_WS_PROYECTO_FINAL.GUI.UC.RegAdmin
{
    partial class frm_RegAdmin
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbn_mujer_jugador = new System.Windows.Forms.RadioButton();
            this.rbn_hombre_jugador = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_matricula_persona = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numero_persona = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_correo_persona = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apeMat_persona = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apePat_persona = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_persona = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelarpersona_registro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_siguientepersona_registro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(351, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 64;
            this.label8.Text = "Matrícula:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbn_mujer_jugador);
            this.groupBox1.Controls.Add(this.rbn_hombre_jugador);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(96, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 42);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // rbn_mujer_jugador
            // 
            this.rbn_mujer_jugador.AutoSize = true;
            this.rbn_mujer_jugador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_mujer_jugador.Location = new System.Drawing.Point(115, 11);
            this.rbn_mujer_jugador.Name = "rbn_mujer_jugador";
            this.rbn_mujer_jugador.Size = new System.Drawing.Size(71, 25);
            this.rbn_mujer_jugador.TabIndex = 13;
            this.rbn_mujer_jugador.TabStop = true;
            this.rbn_mujer_jugador.Text = "Mujer";
            this.rbn_mujer_jugador.UseVisualStyleBackColor = true;
            // 
            // rbn_hombre_jugador
            // 
            this.rbn_hombre_jugador.AutoSize = true;
            this.rbn_hombre_jugador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_hombre_jugador.Location = new System.Drawing.Point(19, 11);
            this.rbn_hombre_jugador.Name = "rbn_hombre_jugador";
            this.rbn_hombre_jugador.Size = new System.Drawing.Size(90, 25);
            this.rbn_hombre_jugador.TabIndex = 12;
            this.rbn_hombre_jugador.TabStop = true;
            this.rbn_hombre_jugador.Text = "Hombre";
            this.rbn_hombre_jugador.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 61;
            this.label7.Text = "Género:";
            // 
            // txt_matricula_persona
            // 
            this.txt_matricula_persona.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txt_matricula_persona.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_matricula_persona.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_matricula_persona.BorderThickness = 3;
            this.txt_matricula_persona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matricula_persona.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_matricula_persona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_matricula_persona.isPassword = false;
            this.txt_matricula_persona.Location = new System.Drawing.Point(351, 157);
            this.txt_matricula_persona.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matricula_persona.Name = "txt_matricula_persona";
            this.txt_matricula_persona.Size = new System.Drawing.Size(311, 31);
            this.txt_matricula_persona.TabIndex = 60;
            this.txt_matricula_persona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(351, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "Numero de teléfono:";
            // 
            // txt_numero_persona
            // 
            this.txt_numero_persona.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txt_numero_persona.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_numero_persona.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_numero_persona.BorderThickness = 3;
            this.txt_numero_persona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_numero_persona.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_numero_persona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_numero_persona.isPassword = false;
            this.txt_numero_persona.Location = new System.Drawing.Point(351, 95);
            this.txt_numero_persona.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero_persona.Name = "txt_numero_persona";
            this.txt_numero_persona.Size = new System.Drawing.Size(311, 31);
            this.txt_numero_persona.TabIndex = 58;
            this.txt_numero_persona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(350, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Correo electrónico:";
            // 
            // txt_correo_persona
            // 
            this.txt_correo_persona.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txt_correo_persona.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_correo_persona.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_correo_persona.BorderThickness = 3;
            this.txt_correo_persona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_correo_persona.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_correo_persona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_correo_persona.isPassword = false;
            this.txt_correo_persona.Location = new System.Drawing.Point(350, 37);
            this.txt_correo_persona.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo_persona.Name = "txt_correo_persona";
            this.txt_correo_persona.Size = new System.Drawing.Size(311, 31);
            this.txt_correo_persona.TabIndex = 56;
            this.txt_correo_persona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Apellido materno:";
            // 
            // txt_apeMat_persona
            // 
            this.txt_apeMat_persona.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txt_apeMat_persona.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_apeMat_persona.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_apeMat_persona.BorderThickness = 3;
            this.txt_apeMat_persona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apeMat_persona.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_apeMat_persona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_apeMat_persona.isPassword = false;
            this.txt_apeMat_persona.Location = new System.Drawing.Point(17, 157);
            this.txt_apeMat_persona.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apeMat_persona.Name = "txt_apeMat_persona";
            this.txt_apeMat_persona.Size = new System.Drawing.Size(311, 31);
            this.txt_apeMat_persona.TabIndex = 54;
            this.txt_apeMat_persona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Apellido paterno:";
            // 
            // txt_apePat_persona
            // 
            this.txt_apePat_persona.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txt_apePat_persona.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_apePat_persona.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_apePat_persona.BorderThickness = 3;
            this.txt_apePat_persona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apePat_persona.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_apePat_persona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_apePat_persona.isPassword = false;
            this.txt_apePat_persona.Location = new System.Drawing.Point(17, 95);
            this.txt_apePat_persona.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apePat_persona.Name = "txt_apePat_persona";
            this.txt_apePat_persona.Size = new System.Drawing.Size(311, 31);
            this.txt_apePat_persona.TabIndex = 52;
            this.txt_apePat_persona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre(s):";
            // 
            // txt_nombre_persona
            // 
            this.txt_nombre_persona.BorderColorFocused = System.Drawing.Color.LightSteelBlue;
            this.txt_nombre_persona.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre_persona.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre_persona.BorderThickness = 3;
            this.txt_nombre_persona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre_persona.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_nombre_persona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre_persona.isPassword = false;
            this.txt_nombre_persona.Location = new System.Drawing.Point(14, 37);
            this.txt_nombre_persona.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_persona.Name = "txt_nombre_persona";
            this.txt_nombre_persona.Size = new System.Drawing.Size(314, 31);
            this.txt_nombre_persona.TabIndex = 50;
            this.txt_nombre_persona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 267);
            this.panel1.TabIndex = 65;
            // 
            // btn_cancelarpersona_registro
            // 
            this.btn_cancelarpersona_registro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cancelarpersona_registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cancelarpersona_registro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelarpersona_registro.BorderRadius = 0;
            this.btn_cancelarpersona_registro.ButtonText = "Cancelar";
            this.btn_cancelarpersona_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarpersona_registro.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancelarpersona_registro.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancelarpersona_registro.Iconimage = null;
            this.btn_cancelarpersona_registro.Iconimage_right = null;
            this.btn_cancelarpersona_registro.Iconimage_right_Selected = null;
            this.btn_cancelarpersona_registro.Iconimage_Selected = null;
            this.btn_cancelarpersona_registro.IconMarginLeft = 0;
            this.btn_cancelarpersona_registro.IconMarginRight = 0;
            this.btn_cancelarpersona_registro.IconRightVisible = true;
            this.btn_cancelarpersona_registro.IconRightZoom = 0D;
            this.btn_cancelarpersona_registro.IconVisible = true;
            this.btn_cancelarpersona_registro.IconZoom = 90D;
            this.btn_cancelarpersona_registro.IsTab = false;
            this.btn_cancelarpersona_registro.Location = new System.Drawing.Point(376, 197);
            this.btn_cancelarpersona_registro.Name = "btn_cancelarpersona_registro";
            this.btn_cancelarpersona_registro.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cancelarpersona_registro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.btn_cancelarpersona_registro.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancelarpersona_registro.selected = false;
            this.btn_cancelarpersona_registro.Size = new System.Drawing.Size(124, 32);
            this.btn_cancelarpersona_registro.TabIndex = 67;
            this.btn_cancelarpersona_registro.Text = "Cancelar";
            this.btn_cancelarpersona_registro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelarpersona_registro.Textcolor = System.Drawing.Color.White;
            this.btn_cancelarpersona_registro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_siguientepersona_registro
            // 
            this.btn_siguientepersona_registro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_siguientepersona_registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_siguientepersona_registro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_siguientepersona_registro.BorderRadius = 0;
            this.btn_siguientepersona_registro.ButtonText = "Siguiente";
            this.btn_siguientepersona_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguientepersona_registro.DisabledColor = System.Drawing.Color.Gray;
            this.btn_siguientepersona_registro.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_siguientepersona_registro.Iconimage = null;
            this.btn_siguientepersona_registro.Iconimage_right = null;
            this.btn_siguientepersona_registro.Iconimage_right_Selected = null;
            this.btn_siguientepersona_registro.Iconimage_Selected = null;
            this.btn_siguientepersona_registro.IconMarginLeft = 0;
            this.btn_siguientepersona_registro.IconMarginRight = 0;
            this.btn_siguientepersona_registro.IconRightVisible = true;
            this.btn_siguientepersona_registro.IconRightZoom = 0D;
            this.btn_siguientepersona_registro.IconVisible = true;
            this.btn_siguientepersona_registro.IconZoom = 90D;
            this.btn_siguientepersona_registro.IsTab = false;
            this.btn_siguientepersona_registro.Location = new System.Drawing.Point(514, 197);
            this.btn_siguientepersona_registro.Name = "btn_siguientepersona_registro";
            this.btn_siguientepersona_registro.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_siguientepersona_registro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(114)))));
            this.btn_siguientepersona_registro.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_siguientepersona_registro.selected = false;
            this.btn_siguientepersona_registro.Size = new System.Drawing.Size(124, 32);
            this.btn_siguientepersona_registro.TabIndex = 66;
            this.btn_siguientepersona_registro.Text = "Siguiente";
            this.btn_siguientepersona_registro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_siguientepersona_registro.Textcolor = System.Drawing.Color.White;
            this.btn_siguientepersona_registro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frm_RegAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 267);
            this.Controls.Add(this.btn_cancelarpersona_registro);
            this.Controls.Add(this.btn_siguientepersona_registro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_matricula_persona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_numero_persona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_correo_persona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_apeMat_persona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_apePat_persona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre_persona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_RegAdmin";
            this.Text = "frm_RegAdmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbn_mujer_jugador;
        private System.Windows.Forms.RadioButton rbn_hombre_jugador;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_matricula_persona;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_numero_persona;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_correo_persona;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_apeMat_persona;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_apePat_persona;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_nombre_persona;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancelarpersona_registro;
        private Bunifu.Framework.UI.BunifuFlatButton btn_siguientepersona_registro;
    }
}