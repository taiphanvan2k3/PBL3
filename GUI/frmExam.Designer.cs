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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Calendar1 = new GUI.MyUserControls.UC_Calendar();
            this.panelGradient1 = new GUI.MyCustomControl.PanelGradient();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.uC_Calendar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 643);
            this.panel1.TabIndex = 1;
            // 
            // uC_Calendar1
            // 
            this.uC_Calendar1.Location = new System.Drawing.Point(6, 27);
            this.uC_Calendar1.Name = "uC_Calendar1";
            this.uC_Calendar1.Size = new System.Drawing.Size(1142, 741);
            this.uC_Calendar1.TabIndex = 0;
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
            this.panelGradient1.Size = new System.Drawing.Size(200, 643);
            this.panelGradient1.TabIndex = 0;
            // 
            // uC_Calendar1
            // 
            this.uC_Calendar1.Location = new System.Drawing.Point(0, 0);
            this.uC_Calendar1.Name = "uC_Calendar1";
            this.uC_Calendar1.Size = new System.Drawing.Size(1115, 661);
            this.uC_Calendar1.TabIndex = 0;
            // 
            // frmExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1327, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGradient1);
            this.Name = "frmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExam";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustomControl.PanelGradient panelGradient1;
        private System.Windows.Forms.Panel panel1;
        private MyUserControls.UC_Calendar uC_Calendar1;
    }
}