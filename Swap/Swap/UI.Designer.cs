
namespace Swap
{
    partial class UI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paidLabel = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.emotes1 = new Swap.Emotes();
            this.backblings1 = new Swap.Backblings();
            this.pickAxes1 = new Swap.PickAxes();
            this.skins1 = new Swap.Skins();
            this.siticoneCirclePictureBox7 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneCirclePictureBox5 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneCirclePictureBox4 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneCirclePictureBox6 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneCirclePictureBox3 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneCirclePictureBox2 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneCirclePictureBox1 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.news1 = new Swap.News();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.paidLabel);
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 39);
            this.panel1.TabIndex = 10;
            // 
            // paidLabel
            // 
            this.paidLabel.AutoSize = true;
            this.paidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidLabel.ForeColor = System.Drawing.Color.White;
            this.paidLabel.Location = new System.Drawing.Point(11, 5);
            this.paidLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paidLabel.Name = "paidLabel";
            this.paidLabel.Size = new System.Drawing.Size(81, 31);
            this.paidLabel.TabIndex = 1;
            this.paidLabel.Text = "Paid:";
            this.paidLabel.Click += new System.EventHandler(this.paidLabel_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(1060, 5);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(36, 29);
            this.siticoneButton1.TabIndex = 0;
            this.siticoneButton1.Text = "X";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-3, 503);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1110, 24);
            this.bunifuSeparator1.TabIndex = 11;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // emotes1
            // 
            this.emotes1.BackColor = System.Drawing.Color.Transparent;
            this.emotes1.Location = new System.Drawing.Point(0, 34);
            this.emotes1.Margin = new System.Windows.Forms.Padding(2);
            this.emotes1.Name = "emotes1";
            this.emotes1.Size = new System.Drawing.Size(1112, 488);
            this.emotes1.TabIndex = 9;
            this.emotes1.Load += new System.EventHandler(this.emotes1_Load);
            // 
            // backblings1
            // 
            this.backblings1.BackColor = System.Drawing.Color.Transparent;
            this.backblings1.Location = new System.Drawing.Point(0, 34);
            this.backblings1.Margin = new System.Windows.Forms.Padding(2);
            this.backblings1.Name = "backblings1";
            this.backblings1.Size = new System.Drawing.Size(1094, 458);
            this.backblings1.TabIndex = 8;
            // 
            // pickAxes1
            // 
            this.pickAxes1.BackColor = System.Drawing.Color.Transparent;
            this.pickAxes1.Location = new System.Drawing.Point(0, 34);
            this.pickAxes1.Margin = new System.Windows.Forms.Padding(2);
            this.pickAxes1.Name = "pickAxes1";
            this.pickAxes1.Size = new System.Drawing.Size(1094, 458);
            this.pickAxes1.TabIndex = 7;
            this.pickAxes1.Load += new System.EventHandler(this.pickAxes1_Load);
            // 
            // skins1
            // 
            this.skins1.BackColor = System.Drawing.Color.Transparent;
            this.skins1.Location = new System.Drawing.Point(0, 43);
            this.skins1.Margin = new System.Windows.Forms.Padding(2);
            this.skins1.Name = "skins1";
            this.skins1.Size = new System.Drawing.Size(1093, 449);
            this.skins1.TabIndex = 5;
            this.skins1.Load += new System.EventHandler(this.skins1_Load);
            // 
            // siticoneCirclePictureBox7
            // 
            this.siticoneCirclePictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneCirclePictureBox7.Image = global::Swap.Properties.Resources.LOADING;
            this.siticoneCirclePictureBox7.Location = new System.Drawing.Point(554, 526);
            this.siticoneCirclePictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneCirclePictureBox7.Name = "siticoneCirclePictureBox7";
            this.siticoneCirclePictureBox7.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox7.ShadowDecoration.Parent = this.siticoneCirclePictureBox7;
            this.siticoneCirclePictureBox7.Size = new System.Drawing.Size(56, 50);
            this.siticoneCirclePictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox7.TabIndex = 13;
            this.siticoneCirclePictureBox7.TabStop = false;
            this.siticoneCirclePictureBox7.Click += new System.EventHandler(this.siticoneCirclePictureBox7_Click_1);
            // 
            // siticoneCirclePictureBox5
            // 
            this.siticoneCirclePictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneCirclePictureBox5.Image = global::Swap.Properties.Resources.cooltext387764161242128;
            this.siticoneCirclePictureBox5.Location = new System.Drawing.Point(612, 526);
            this.siticoneCirclePictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneCirclePictureBox5.Name = "siticoneCirclePictureBox5";
            this.siticoneCirclePictureBox5.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox5.ShadowDecoration.Parent = this.siticoneCirclePictureBox5;
            this.siticoneCirclePictureBox5.Size = new System.Drawing.Size(56, 50);
            this.siticoneCirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox5.TabIndex = 12;
            this.siticoneCirclePictureBox5.TabStop = false;
            this.siticoneCirclePictureBox5.Click += new System.EventHandler(this.siticoneCirclePictureBox5_Click_1);
            // 
            // siticoneCirclePictureBox4
            // 
            this.siticoneCirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneCirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox4.Image")));
            this.siticoneCirclePictureBox4.Location = new System.Drawing.Point(672, 526);
            this.siticoneCirclePictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneCirclePictureBox4.Name = "siticoneCirclePictureBox4";
            this.siticoneCirclePictureBox4.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox4.ShadowDecoration.Parent = this.siticoneCirclePictureBox4;
            this.siticoneCirclePictureBox4.Size = new System.Drawing.Size(56, 50);
            this.siticoneCirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox4.TabIndex = 5;
            this.siticoneCirclePictureBox4.TabStop = false;
            this.siticoneCirclePictureBox4.Click += new System.EventHandler(this.siticoneCirclePictureBox4_Click_1);
            // 
            // siticoneCirclePictureBox6
            // 
            this.siticoneCirclePictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneCirclePictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox6.Image")));
            this.siticoneCirclePictureBox6.Location = new System.Drawing.Point(438, 526);
            this.siticoneCirclePictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneCirclePictureBox6.Name = "siticoneCirclePictureBox6";
            this.siticoneCirclePictureBox6.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox6.ShadowDecoration.Parent = this.siticoneCirclePictureBox6;
            this.siticoneCirclePictureBox6.Size = new System.Drawing.Size(52, 50);
            this.siticoneCirclePictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox6.TabIndex = 6;
            this.siticoneCirclePictureBox6.TabStop = false;
            this.siticoneCirclePictureBox6.Click += new System.EventHandler(this.siticoneCirclePictureBox6_Click);
            // 
            // siticoneCirclePictureBox3
            // 
            this.siticoneCirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneCirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox3.Image")));
            this.siticoneCirclePictureBox3.Location = new System.Drawing.Point(494, 526);
            this.siticoneCirclePictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneCirclePictureBox3.Name = "siticoneCirclePictureBox3";
            this.siticoneCirclePictureBox3.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox3.ShadowDecoration.Parent = this.siticoneCirclePictureBox3;
            this.siticoneCirclePictureBox3.Size = new System.Drawing.Size(56, 50);
            this.siticoneCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox3.TabIndex = 2;
            this.siticoneCirclePictureBox3.TabStop = false;
            this.siticoneCirclePictureBox3.Click += new System.EventHandler(this.siticoneCirclePictureBox3_Click);
            // 
            // siticoneCirclePictureBox2
            // 
            this.siticoneCirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox2.Image")));
            this.siticoneCirclePictureBox2.Location = new System.Drawing.Point(378, 526);
            this.siticoneCirclePictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneCirclePictureBox2.Name = "siticoneCirclePictureBox2";
            this.siticoneCirclePictureBox2.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox2.ShadowDecoration.Parent = this.siticoneCirclePictureBox2;
            this.siticoneCirclePictureBox2.Size = new System.Drawing.Size(56, 50);
            this.siticoneCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox2.TabIndex = 1;
            this.siticoneCirclePictureBox2.TabStop = false;
            this.siticoneCirclePictureBox2.Click += new System.EventHandler(this.siticoneCirclePictureBox2_Click);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox1.Image")));
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(322, 526);
            this.siticoneCirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(52, 50);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox1.TabIndex = 0;
            this.siticoneCirclePictureBox1.TabStop = false;
            this.siticoneCirclePictureBox1.Click += new System.EventHandler(this.siticoneCirclePictureBox1_Click);
            // 
            // news1
            // 
            this.news1.BackColor = System.Drawing.Color.Transparent;
            this.news1.Location = new System.Drawing.Point(0, 35);
            this.news1.Name = "news1";
            this.news1.Size = new System.Drawing.Size(1094, 461);
            this.news1.TabIndex = 14;
            this.news1.Visible = false;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1102, 587);
            this.Controls.Add(this.news1);
            this.Controls.Add(this.siticoneCirclePictureBox7);
            this.Controls.Add(this.siticoneCirclePictureBox5);
            this.Controls.Add(this.siticoneCirclePictureBox4);
            this.Controls.Add(this.siticoneCirclePictureBox6);
            this.Controls.Add(this.siticoneCirclePictureBox3);
            this.Controls.Add(this.siticoneCirclePictureBox2);
            this.Controls.Add(this.siticoneCirclePictureBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.emotes1);
            this.Controls.Add(this.backblings1);
            this.Controls.Add(this.pickAxes1);
            this.Controls.Add(this.skins1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nora Swapper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox3;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox2;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private Skins skins1;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox4;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox6;
        private PickAxes pickAxes1;
        private Backblings backblings1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Label paidLabel;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox5;
        private Emotes emotes1;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox7;
        private News news1;
    }
}

