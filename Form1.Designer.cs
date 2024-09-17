namespace kopapirollo_form_20240917
{
    partial class form
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
            this.lbgep = new System.Windows.Forms.Label();
            this.lbjkos = new System.Windows.Forms.Label();
            this.txgep = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.játékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újJátékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbjatekos = new System.Windows.Forms.ComboBox();
            this.lbgpont = new System.Windows.Forms.Label();
            this.lbjpont = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbgep
            // 
            this.lbgep.AutoSize = true;
            this.lbgep.Location = new System.Drawing.Point(78, 105);
            this.lbgep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbgep.Name = "lbgep";
            this.lbgep.Size = new System.Drawing.Size(34, 13);
            this.lbgep.TabIndex = 1;
            this.lbgep.Text = "Gép:";
            // 
            // lbjkos
            // 
            this.lbjkos.AutoSize = true;
            this.lbjkos.Location = new System.Drawing.Point(272, 105);
            this.lbjkos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbjkos.Name = "lbjkos";
            this.lbjkos.Size = new System.Drawing.Size(55, 13);
            this.lbjkos.TabIndex = 2;
            this.lbjkos.Text = "Játékos:";
            // 
            // txgep
            // 
            this.txgep.Enabled = false;
            this.txgep.Location = new System.Drawing.Point(121, 105);
            this.txgep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txgep.Name = "txgep";
            this.txgep.Size = new System.Drawing.Size(116, 20);
            this.txgep.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.játékToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // játékToolStripMenuItem
            // 
            this.játékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újJátékToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.játékToolStripMenuItem.Name = "játékToolStripMenuItem";
            this.játékToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.játékToolStripMenuItem.Text = "Játék";
            this.játékToolStripMenuItem.Click += new System.EventHandler(this.játékToolStripMenuItem_Click);
            // 
            // újJátékToolStripMenuItem
            // 
            this.újJátékToolStripMenuItem.Name = "újJátékToolStripMenuItem";
            this.újJátékToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újJátékToolStripMenuItem.Text = "Új játék";
            this.újJátékToolStripMenuItem.Click += new System.EventHandler(this.újJátékToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // cbjatekos
            // 
            this.cbjatekos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbjatekos.Enabled = false;
            this.cbjatekos.FormattingEnabled = true;
            this.cbjatekos.Items.AddRange(new object[] {
            "Kő",
            "Papír",
            "Olló"});
            this.cbjatekos.Location = new System.Drawing.Point(335, 105);
            this.cbjatekos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbjatekos.Name = "cbjatekos";
            this.cbjatekos.Size = new System.Drawing.Size(103, 21);
            this.cbjatekos.TabIndex = 5;
            this.cbjatekos.SelectedIndexChanged += new System.EventHandler(this.cbjatekos_SelectedIndexChanged);
            // 
            // lbgpont
            // 
            this.lbgpont.AutoSize = true;
            this.lbgpont.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbgpont.ForeColor = System.Drawing.Color.Red;
            this.lbgpont.Location = new System.Drawing.Point(208, 179);
            this.lbgpont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbgpont.Name = "lbgpont";
            this.lbgpont.Size = new System.Drawing.Size(29, 31);
            this.lbgpont.TabIndex = 6;
            this.lbgpont.Text = "0";
            // 
            // lbjpont
            // 
            this.lbjpont.AutoSize = true;
            this.lbjpont.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbjpont.ForeColor = System.Drawing.Color.Red;
            this.lbjpont.Location = new System.Drawing.Point(298, 179);
            this.lbjpont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbjpont.Name = "lbjpont";
            this.lbjpont.Size = new System.Drawing.Size(29, 31);
            this.lbjpont.TabIndex = 7;
            this.lbjpont.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(258, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 242);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbjpont);
            this.Controls.Add(this.lbgpont);
            this.Controls.Add(this.cbjatekos);
            this.Controls.Add(this.txgep);
            this.Controls.Add(this.lbjkos);
            this.Controls.Add(this.lbgep);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kő - papír - olló játék";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.form_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbgep;
        private System.Windows.Forms.Label lbjkos;
        private System.Windows.Forms.TextBox txgep;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem játékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újJátékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbjatekos;
        private System.Windows.Forms.Label lbgpont;
        private System.Windows.Forms.Label lbjpont;
        private System.Windows.Forms.Label label3;
    }
}

