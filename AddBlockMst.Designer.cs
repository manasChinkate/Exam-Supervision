namespace ExamSupervisionSystem
{
    partial class AddBlockMst
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbnumber = new System.Windows.Forms.TextBox();
            this.txtrnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btndelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnaddblock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 179);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Block No:";
            // 
            // txtbnumber
            // 
            this.txtbnumber.Location = new System.Drawing.Point(303, 134);
            this.txtbnumber.Name = "txtbnumber";
            this.txtbnumber.Size = new System.Drawing.Size(171, 20);
            this.txtbnumber.TabIndex = 5;
            this.txtbnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbnumber_KeyPress);
            // 
            // txtrnumber
            // 
            this.txtrnumber.Location = new System.Drawing.Point(303, 192);
            this.txtrnumber.Name = "txtrnumber";
            this.txtrnumber.Size = new System.Drawing.Size(171, 20);
            this.txtrnumber.TabIndex = 7;
            this.txtrnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrnumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Room No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(222, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "BLOCK DETAILS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 70);
            this.panel1.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(597, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 29);
            this.button4.TabIndex = 35;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndelete
            // 
            this.btndelete.Activecolor = System.Drawing.Color.White;
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.BorderRadius = 0;
            this.btndelete.ButtonText = " DELETE";
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btndelete.Iconimage = null;
            this.btndelete.Iconimage_right = null;
            this.btndelete.Iconimage_right_Selected = null;
            this.btndelete.Iconimage_Selected = null;
            this.btndelete.IconMarginLeft = 0;
            this.btndelete.IconMarginRight = 0;
            this.btndelete.IconRightVisible = true;
            this.btndelete.IconRightZoom = 0D;
            this.btndelete.IconVisible = true;
            this.btndelete.IconZoom = 90D;
            this.btndelete.IsTab = false;
            this.btndelete.Location = new System.Drawing.Point(412, 281);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.btndelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btndelete.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.btndelete.selected = false;
            this.btndelete.Size = new System.Drawing.Size(123, 35);
            this.btndelete.TabIndex = 65;
            this.btndelete.Text = " DELETE";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Textcolor = System.Drawing.Color.White;
            this.btndelete.TextFont = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Activecolor = System.Drawing.Color.White;
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdate.BorderRadius = 0;
            this.btnupdate.ButtonText = " UPDATE";
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnupdate.Iconimage = null;
            this.btnupdate.Iconimage_right = null;
            this.btnupdate.Iconimage_right_Selected = null;
            this.btnupdate.Iconimage_Selected = null;
            this.btnupdate.IconMarginLeft = 0;
            this.btnupdate.IconMarginRight = 0;
            this.btnupdate.IconRightVisible = true;
            this.btnupdate.IconRightZoom = 0D;
            this.btnupdate.IconVisible = true;
            this.btnupdate.IconZoom = 90D;
            this.btnupdate.IsTab = false;
            this.btnupdate.Location = new System.Drawing.Point(252, 281);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.btnupdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnupdate.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.btnupdate.selected = false;
            this.btnupdate.Size = new System.Drawing.Size(123, 35);
            this.btnupdate.TabIndex = 64;
            this.btnupdate.Text = " UPDATE";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdate.Textcolor = System.Drawing.Color.White;
            this.btnupdate.TextFont = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnaddblock
            // 
            this.btnaddblock.Activecolor = System.Drawing.Color.White;
            this.btnaddblock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnaddblock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.btnaddblock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddblock.BorderRadius = 0;
            this.btnaddblock.ButtonText = " ADD BLOCK";
            this.btnaddblock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddblock.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnaddblock.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddblock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnaddblock.Iconimage = null;
            this.btnaddblock.Iconimage_right = null;
            this.btnaddblock.Iconimage_right_Selected = null;
            this.btnaddblock.Iconimage_Selected = null;
            this.btnaddblock.IconMarginLeft = 0;
            this.btnaddblock.IconMarginRight = 0;
            this.btnaddblock.IconRightVisible = true;
            this.btnaddblock.IconRightZoom = 0D;
            this.btnaddblock.IconVisible = true;
            this.btnaddblock.IconZoom = 90D;
            this.btnaddblock.IsTab = false;
            this.btnaddblock.Location = new System.Drawing.Point(98, 281);
            this.btnaddblock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnaddblock.Name = "btnaddblock";
            this.btnaddblock.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.btnaddblock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnaddblock.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.btnaddblock.selected = false;
            this.btnaddblock.Size = new System.Drawing.Size(123, 35);
            this.btnaddblock.TabIndex = 63;
            this.btnaddblock.Text = " ADD BLOCK";
            this.btnaddblock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnaddblock.Textcolor = System.Drawing.Color.White;
            this.btnaddblock.TextFont = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddblock.Click += new System.EventHandler(this.btnaddblock_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AddBlockMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 547);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnaddblock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtrnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBlockMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBlockMst";
            this.Load += new System.EventHandler(this.AddBlockMst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbnumber;
        private System.Windows.Forms.TextBox txtrnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuFlatButton btndelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnaddblock;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}