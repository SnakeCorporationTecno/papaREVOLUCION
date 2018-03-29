namespace Beta3_WS_PROYECTO_FINAL.GUI.UC
{
    partial class UC_equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_equipos));
            this.transparentControl1 = new TransControl_src.TransparentControl();
            this.SuspendLayout();
            // 
            // transparentControl1
            // 
            this.transparentControl1.Location = new System.Drawing.Point(0, 34);
            this.transparentControl1.MinimumSize = new System.Drawing.Size(100, 75);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Opacity = 0.8D;
            this.transparentControl1.Size = new System.Drawing.Size(1230, 422);
            this.transparentControl1.TabIndex = 2;
            this.transparentControl1.Text = "transparentControl1";
            this.transparentControl1.Transparent = true;
            this.transparentControl1.TransparentColor = System.Drawing.Color.Black;
            // 
            // UC_equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.transparentControl1);
            this.Name = "UC_equipos";
            this.Size = new System.Drawing.Size(1230, 490);
            this.ResumeLayout(false);

        }

        #endregion

        private TransControl_src.TransparentControl transparentControl1;
    }
}
