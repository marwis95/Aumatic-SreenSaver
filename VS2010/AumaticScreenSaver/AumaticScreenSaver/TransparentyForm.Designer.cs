namespace AumaticScreenSaver
{
    partial class TransparentyForm
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
            this.SuspendLayout();
            // 
            // LineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LineForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LineForm";
            this.Load += new System.EventHandler(this.LineForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LineForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LineForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LineForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

    }
}