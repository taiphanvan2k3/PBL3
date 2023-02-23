using System.Windows.Forms;

namespace GUI.MyUserControls
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDays = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDays
            // 
            this.btnDays.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDays.Location = new System.Drawing.Point(0, 0);
            this.btnDays.Name = "btnDays";
            this.btnDays.Size = new System.Drawing.Size(152, 100);
            this.btnDays.TabIndex = 3;
            this.btnDays.Text = "00";
            this.btnDays.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDays.UseVisualStyleBackColor = true;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(152, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDays;
    }
}
