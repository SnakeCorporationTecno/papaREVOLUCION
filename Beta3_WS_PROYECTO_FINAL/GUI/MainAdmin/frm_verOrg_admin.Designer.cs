namespace Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin
{
    partial class frm_verOrg_admin
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
            this.btn_cerrar_vOrg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_deletOrg_vDOrg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_editOrg_vOrg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_reOrg_vOrg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cerrar_vOrg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 34);
            this.panel1.TabIndex = 14;
            // 
            // btn_cerrar_vOrg
            // 
            this.btn_cerrar_vOrg.Activecolor = System.Drawing.Color.Transparent;
            this.btn_cerrar_vOrg.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_vOrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar_vOrg.BorderRadius = 0;
            this.btn_cerrar_vOrg.ButtonText = "X";
            this.btn_cerrar_vOrg.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cerrar_vOrg.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.btn_cerrar_vOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_vOrg.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_cerrar_vOrg.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cerrar_vOrg.Iconimage = null;
            this.btn_cerrar_vOrg.Iconimage_right = null;
            this.btn_cerrar_vOrg.Iconimage_right_Selected = null;
            this.btn_cerrar_vOrg.Iconimage_Selected = null;
            this.btn_cerrar_vOrg.IconMarginLeft = 0;
            this.btn_cerrar_vOrg.IconMarginRight = 0;
            this.btn_cerrar_vOrg.IconRightVisible = true;
            this.btn_cerrar_vOrg.IconRightZoom = 0D;
            this.btn_cerrar_vOrg.IconVisible = true;
            this.btn_cerrar_vOrg.IconZoom = 90D;
            this.btn_cerrar_vOrg.IsTab = false;
            this.btn_cerrar_vOrg.Location = new System.Drawing.Point(773, -1);
            this.btn_cerrar_vOrg.Margin = new System.Windows.Forms.Padding(8);
            this.btn_cerrar_vOrg.Name = "btn_cerrar_vOrg";
            this.btn_cerrar_vOrg.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_cerrar_vOrg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_cerrar_vOrg.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cerrar_vOrg.selected = false;
            this.btn_cerrar_vOrg.Size = new System.Drawing.Size(45, 35);
            this.btn_cerrar_vOrg.TabIndex = 22;
            this.btn_cerrar_vOrg.Text = "X";
            this.btn_cerrar_vOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cerrar_vOrg.Textcolor = System.Drawing.Color.DimGray;
            this.btn_cerrar_vOrg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_cerrar_vOrg.Click += new System.EventHandler(this.btn_cerrar_vOrg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Administrador de Organizadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar director técnico:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(307, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 31);
            this.textBox1.TabIndex = 12;
            // 
            // btn_deletOrg_vDOrg
            // 
            this.btn_deletOrg_vDOrg.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_deletOrg_vDOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_deletOrg_vDOrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deletOrg_vDOrg.BorderRadius = 0;
            this.btn_deletOrg_vDOrg.ButtonText = "Eliminar organizador";
            this.btn_deletOrg_vDOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletOrg_vDOrg.DisabledColor = System.Drawing.Color.Gray;
            this.btn_deletOrg_vDOrg.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_deletOrg_vDOrg.Iconimage = null;
            this.btn_deletOrg_vDOrg.Iconimage_right = null;
            this.btn_deletOrg_vDOrg.Iconimage_right_Selected = null;
            this.btn_deletOrg_vDOrg.Iconimage_Selected = null;
            this.btn_deletOrg_vDOrg.IconMarginLeft = 0;
            this.btn_deletOrg_vDOrg.IconMarginRight = 0;
            this.btn_deletOrg_vDOrg.IconRightVisible = true;
            this.btn_deletOrg_vDOrg.IconRightZoom = 0D;
            this.btn_deletOrg_vDOrg.IconVisible = true;
            this.btn_deletOrg_vDOrg.IconZoom = 90D;
            this.btn_deletOrg_vDOrg.IsTab = false;
            this.btn_deletOrg_vDOrg.Location = new System.Drawing.Point(590, 65);
            this.btn_deletOrg_vDOrg.Name = "btn_deletOrg_vDOrg";
            this.btn_deletOrg_vDOrg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_deletOrg_vDOrg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.btn_deletOrg_vDOrg.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_deletOrg_vDOrg.selected = false;
            this.btn_deletOrg_vDOrg.Size = new System.Drawing.Size(213, 28);
            this.btn_deletOrg_vDOrg.TabIndex = 11;
            this.btn_deletOrg_vDOrg.Text = "Eliminar organizador";
            this.btn_deletOrg_vDOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_deletOrg_vDOrg.Textcolor = System.Drawing.Color.White;
            this.btn_deletOrg_vDOrg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_editOrg_vOrg
            // 
            this.btn_editOrg_vOrg.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_editOrg_vOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_editOrg_vOrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editOrg_vOrg.BorderRadius = 0;
            this.btn_editOrg_vOrg.ButtonText = "Editar organizador";
            this.btn_editOrg_vOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editOrg_vOrg.DisabledColor = System.Drawing.Color.Gray;
            this.btn_editOrg_vOrg.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_editOrg_vOrg.Iconimage = null;
            this.btn_editOrg_vOrg.Iconimage_right = null;
            this.btn_editOrg_vOrg.Iconimage_right_Selected = null;
            this.btn_editOrg_vOrg.Iconimage_Selected = null;
            this.btn_editOrg_vOrg.IconMarginLeft = 0;
            this.btn_editOrg_vOrg.IconMarginRight = 0;
            this.btn_editOrg_vOrg.IconRightVisible = true;
            this.btn_editOrg_vOrg.IconRightZoom = 0D;
            this.btn_editOrg_vOrg.IconVisible = true;
            this.btn_editOrg_vOrg.IconZoom = 90D;
            this.btn_editOrg_vOrg.IsTab = false;
            this.btn_editOrg_vOrg.Location = new System.Drawing.Point(318, 65);
            this.btn_editOrg_vOrg.Name = "btn_editOrg_vOrg";
            this.btn_editOrg_vOrg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_editOrg_vOrg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_editOrg_vOrg.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_editOrg_vOrg.selected = false;
            this.btn_editOrg_vOrg.Size = new System.Drawing.Size(213, 28);
            this.btn_editOrg_vOrg.TabIndex = 10;
            this.btn_editOrg_vOrg.Text = "Editar organizador";
            this.btn_editOrg_vOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_editOrg_vOrg.Textcolor = System.Drawing.Color.White;
            this.btn_editOrg_vOrg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_reOrg_vOrg
            // 
            this.btn_reOrg_vOrg.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_reOrg_vOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_reOrg_vOrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reOrg_vOrg.BorderRadius = 0;
            this.btn_reOrg_vOrg.ButtonText = "Registrar nevo organizador";
            this.btn_reOrg_vOrg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reOrg_vOrg.DisabledColor = System.Drawing.Color.Gray;
            this.btn_reOrg_vOrg.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_reOrg_vOrg.Iconimage = null;
            this.btn_reOrg_vOrg.Iconimage_right = null;
            this.btn_reOrg_vOrg.Iconimage_right_Selected = null;
            this.btn_reOrg_vOrg.Iconimage_Selected = null;
            this.btn_reOrg_vOrg.IconMarginLeft = 0;
            this.btn_reOrg_vOrg.IconMarginRight = 0;
            this.btn_reOrg_vOrg.IconRightVisible = true;
            this.btn_reOrg_vOrg.IconRightZoom = 0D;
            this.btn_reOrg_vOrg.IconVisible = true;
            this.btn_reOrg_vOrg.IconZoom = 90D;
            this.btn_reOrg_vOrg.IsTab = false;
            this.btn_reOrg_vOrg.Location = new System.Drawing.Point(26, 65);
            this.btn_reOrg_vOrg.Name = "btn_reOrg_vOrg";
            this.btn_reOrg_vOrg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_reOrg_vOrg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_reOrg_vOrg.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_reOrg_vOrg.selected = false;
            this.btn_reOrg_vOrg.Size = new System.Drawing.Size(213, 28);
            this.btn_reOrg_vOrg.TabIndex = 9;
            this.btn_reOrg_vOrg.Text = "Registrar nevo organizador";
            this.btn_reOrg_vOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reOrg_vOrg.Textcolor = System.Drawing.Color.White;
            this.btn_reOrg_vOrg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reOrg_vOrg.Click += new System.EventHandler(this.btn_reOrg_vOrg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 218);
            this.dataGridView1.TabIndex = 8;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 9;
            this.bunifuElipse1.TargetControl = this.btn_deletOrg_vDOrg;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 9;
            this.bunifuElipse2.TargetControl = this.btn_editOrg_vOrg;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 9;
            this.bunifuElipse3.TargetControl = this.btn_reOrg_vOrg;
            // 
            // frm_verOrg_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_deletOrg_vDOrg);
            this.Controls.Add(this.btn_editOrg_vOrg);
            this.Controls.Add(this.btn_reOrg_vOrg);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_verOrg_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_verOrg_admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cerrar_vOrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_deletOrg_vDOrg;
        private Bunifu.Framework.UI.BunifuFlatButton btn_editOrg_vOrg;
        private Bunifu.Framework.UI.BunifuFlatButton btn_reOrg_vOrg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}