namespace Beta3_WS_PROYECTO_FINAL.GUI.UC
{
    partial class UC_estadisticas
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
            this.lbl_estadisticasUC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_estadisticasUC
            // 
            this.lbl_estadisticasUC.AutoSize = true;
            this.lbl_estadisticasUC.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.lbl_estadisticasUC.Location = new System.Drawing.Point(26, 18);
            this.lbl_estadisticasUC.Name = "lbl_estadisticasUC";
            this.lbl_estadisticasUC.Size = new System.Drawing.Size(211, 42);
            this.lbl_estadisticasUC.TabIndex = 1;
            this.lbl_estadisticasUC.Text = "Estadísticas";
            // 
            // UC_estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_estadisticasUC);
            this.Name = "UC_estadisticas";
            this.Size = new System.Drawing.Size(1230, 490);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_estadisticasUC;
    }
}
