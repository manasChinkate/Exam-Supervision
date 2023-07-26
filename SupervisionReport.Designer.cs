namespace ExamSupervisionSystem
{
    partial class SupervisionReport
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
            this.Loadbutton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // Loadbutton1
            // 
            this.Loadbutton1.Activecolor = System.Drawing.Color.White;
            this.Loadbutton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Loadbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(149)))), ((int)(((byte)(226)))));
            this.Loadbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loadbutton1.BorderRadius = 0;
            this.Loadbutton1.ButtonText = "Load Report";
            this.Loadbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loadbutton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Loadbutton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbutton1.Iconcolor = System.Drawing.Color.Transparent;
            this.Loadbutton1.Iconimage = null;
            this.Loadbutton1.Iconimage_right = null;
            this.Loadbutton1.Iconimage_right_Selected = null;
            this.Loadbutton1.Iconimage_Selected = null;
            this.Loadbutton1.IconMarginLeft = 0;
            this.Loadbutton1.IconMarginRight = 0;
            this.Loadbutton1.IconRightVisible = true;
            this.Loadbutton1.IconRightZoom = 0D;
            this.Loadbutton1.IconVisible = true;
            this.Loadbutton1.IconZoom = 90D;
            this.Loadbutton1.IsTab = false;
            this.Loadbutton1.Location = new System.Drawing.Point(25, 13);
            this.Loadbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Loadbutton1.Name = "Loadbutton1";
            this.Loadbutton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(149)))), ((int)(((byte)(226)))));
            this.Loadbutton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.Loadbutton1.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.Loadbutton1.selected = false;
            this.Loadbutton1.Size = new System.Drawing.Size(183, 34);
            this.Loadbutton1.TabIndex = 92;
            this.Loadbutton1.Text = "Load Report";
            this.Loadbutton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Loadbutton1.Textcolor = System.Drawing.Color.White;
            this.Loadbutton1.TextFont = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbutton1.Click += new System.EventHandler(this.Loadbutton1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ExamSupervisionSystem.SupervisionReport1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(746, 246);
            this.reportViewer1.TabIndex = 93;
            // 
            // SupervisionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Loadbutton1);
            this.Name = "SupervisionReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupervisionReport";
            this.Load += new System.EventHandler(this.SupervisionReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton Loadbutton1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}