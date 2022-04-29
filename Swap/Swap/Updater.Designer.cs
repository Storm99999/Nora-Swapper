
namespace Swap
{
    partial class Updater
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pdnctu = new System.Windows.Forms.Label();
            this.siticoneCircleProgressBar1 = new Siticone.UI.WinForms.SiticoneCircleProgressBar();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 50.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nora Updater";
            // 
            // pdnctu
            // 
            this.pdnctu.AutoSize = true;
            this.pdnctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.pdnctu.ForeColor = System.Drawing.Color.White;
            this.pdnctu.Location = new System.Drawing.Point(12, 412);
            this.pdnctu.Name = "pdnctu";
            this.pdnctu.Size = new System.Drawing.Size(362, 29);
            this.pdnctu.TabIndex = 1;
            this.pdnctu.Text = "Please do not close the Updater.";
            // 
            // siticoneCircleProgressBar1
            // 
            this.siticoneCircleProgressBar1.Location = new System.Drawing.Point(253, 111);
            this.siticoneCircleProgressBar1.Name = "siticoneCircleProgressBar1";
            this.siticoneCircleProgressBar1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleProgressBar1.ShadowDecoration.Parent = this.siticoneCircleProgressBar1;
            this.siticoneCircleProgressBar1.Size = new System.Drawing.Size(216, 216);
            this.siticoneCircleProgressBar1.TabIndex = 2;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siticoneCircleProgressBar1);
            this.Controls.Add(this.pdnctu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Updater";
            this.Text = "Updater";
            this.Load += new System.EventHandler(this.Updater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Siticone.UI.WinForms.SiticoneCircleProgressBar siticoneCircleProgressBar1;
        private System.Windows.Forms.Label pdnctu;
        private System.Windows.Forms.Label label1;
    }
}