namespace Beta3_WS_PROYECTO_FINAL.GUI.UC
{
    partial class UC_inicio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_inicio));
            this.transparentControl1 = new TransControl_src.TransparentControl();
            this.grp_calendarioMAIN = new System.Windows.Forms.GroupBox();
            this.grp_partidosMAIN = new System.Windows.Forms.GroupBox();
            this.transparentControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transparentControl1
            // 
            this.transparentControl1.Controls.Add(this.grp_calendarioMAIN);
            this.transparentControl1.Controls.Add(this.grp_partidosMAIN);
            this.transparentControl1.Location = new System.Drawing.Point(0, 39);
            this.transparentControl1.MinimumSize = new System.Drawing.Size(100, 75);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Opacity = 0.7D;
            this.transparentControl1.Size = new System.Drawing.Size(1230, 388);
            this.transparentControl1.TabIndex = 0;
            this.transparentControl1.Text = "transparentControl1";
            this.transparentControl1.Transparent = true;
            this.transparentControl1.TransparentColor = System.Drawing.SystemColors.MenuText;
            // 
            // grp_calendarioMAIN
            // 
            this.grp_calendarioMAIN.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.grp_calendarioMAIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_calendarioMAIN.Location = new System.Drawing.Point(735, 21);
            this.grp_calendarioMAIN.Name = "grp_calendarioMAIN";
            this.grp_calendarioMAIN.Size = new System.Drawing.Size(472, 320);
            this.grp_calendarioMAIN.TabIndex = 1;
            this.grp_calendarioMAIN.TabStop = false;
            this.grp_calendarioMAIN.Text = "Calendario";
            // 
            // grp_partidosMAIN
            // 
            this.grp_partidosMAIN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_partidosMAIN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grp_partidosMAIN.Location = new System.Drawing.Point(29, 21);
            this.grp_partidosMAIN.Name = "grp_partidosMAIN";
            this.grp_partidosMAIN.Size = new System.Drawing.Size(666, 320);
            this.grp_partidosMAIN.TabIndex = 0;
            this.grp_partidosMAIN.TabStop = false;
            this.grp_partidosMAIN.Text = "Partidos";
            // 
            // UC_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.transparentControl1);
            this.Name = "UC_inicio";
            this.Size = new System.Drawing.Size(1230, 490);
            this.transparentControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TransControl_src.TransparentControl transparentControl1;
        private System.Windows.Forms.GroupBox grp_calendarioMAIN;
        private System.Windows.Forms.GroupBox grp_partidosMAIN;
    }
}
