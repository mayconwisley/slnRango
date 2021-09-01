
namespace Rango
{
    partial class FrmVisualizar
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
            this.RpwRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RpwRelatorio
            // 
            this.RpwRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RpwRelatorio.Location = new System.Drawing.Point(0, 0);
            this.RpwRelatorio.Name = "RpwRelatorio";
            this.RpwRelatorio.ServerReport.BearerToken = null;
            this.RpwRelatorio.ShowFindControls = false;
            this.RpwRelatorio.ShowRefreshButton = false;
            this.RpwRelatorio.ShowStopButton = false;
            this.RpwRelatorio.Size = new System.Drawing.Size(873, 679);
            this.RpwRelatorio.TabIndex = 0;
            // 
            // FrmVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 679);
            this.Controls.Add(this.RpwRelatorio);
            this.MinimizeBox = false;
            this.Name = "FrmVisualizar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar";
            this.Load += new System.EventHandler(this.FrmVisualizar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpwRelatorio;
    }
}