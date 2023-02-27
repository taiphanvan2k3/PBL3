namespace GUI
{
    partial class frmExam
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
            this.calendar1 = new GUI.MyUserControls.Calendar();
            this.panelGradient1 = new GUI.MyCustomControl.PanelGradient();
            this.SuspendLayout();
            // 
            // calendar1
            // 
            this.calendar1.Location = new System.Drawing.Point(184, 0);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(1240, 643);
            this.calendar1.TabIndex = 1;
            // 
            // panelGradient1
            // 
            this.panelGradient1.BackColor = System.Drawing.Color.White;
            this.panelGradient1.BorderRadius = 0;
            this.panelGradient1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGradient1.ForeColor = System.Drawing.Color.Black;
            this.panelGradient1.GradientAngle = 90F;
            this.panelGradient1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.panelGradient1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.panelGradient1.Location = new System.Drawing.Point(0, 0);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(189, 557);
            this.panelGradient1.TabIndex = 0;
            // 
            // frmExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1429, 557);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.panelGradient1);
            this.Name = "frmExam";
            this.Text = "FrmExam";
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustomControl.PanelGradient panelGradient1;
        private MyUserControls.Calendar calendar1;
    }
}