namespace EliteSider
{
    partial class SideBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBar));
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(174, 266);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SideBar";
            this.Opacity = 0.4;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rassa SideBar";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.SideBar_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SideBar_MouseDoubleClick);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBar_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SideBar_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}