using RearViewMirror;
using motion; 

namespace RearViewMirror
{
    partial class Viewer
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
            this.cameraWindow = new motion.CameraWindow();
            this.SuspendLayout();
            // 
            // cameraWindow
            // 
            this.cameraWindow.Camera = null;
            this.cameraWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraWindow.Location = new System.Drawing.Point(0, 0);
            this.cameraWindow.Name = "cameraWindow";
            this.cameraWindow.Size = new System.Drawing.Size(292, 249);
            this.cameraWindow.TabIndex = 0;
            this.cameraWindow.TabStop = false;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 249);
            this.ControlBox = false;
            this.Controls.Add(this.cameraWindow);
            this.Name = "Viewer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Viewer";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private motion.CameraWindow cameraWindow;
    }
}