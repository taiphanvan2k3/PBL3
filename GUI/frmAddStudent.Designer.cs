namespace GUI
{
    partial class frmAddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelGradient1 = new GUI.MyCustomControl.PanelGradient();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new GUI.MyCustomControl.CustomButton();
            this.btnAdd = new GUI.MyCustomControl.CustomButton();
            this.tbIdStudent = new GUI.MyCustomControl.CustomTextBox();
            this.panelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // panelGradient1
            // 
            this.panelGradient1.BackColor = System.Drawing.Color.White;
            this.panelGradient1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelGradient1.BorderRadius = 30;
            this.panelGradient1.Controls.Add(this.label3);
            this.panelGradient1.Controls.Add(this.label2);
            this.panelGradient1.ForeColor = System.Drawing.Color.Black;
            this.panelGradient1.GradientAngle = 90F;
            this.panelGradient1.GradientBottomColor = System.Drawing.SystemColors.ControlDark;
            this.panelGradient1.GradientTopColor = System.Drawing.SystemColors.ControlDark;
            this.panelGradient1.Location = new System.Drawing.Point(53, 79);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(384, 176);
            this.panelGradient1.TabIndex = 4;
            this.panelGradient1.Click += new System.EventHandler(this.panelGradient1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::GUI.Properties.Resources.csv;
            this.label3.Location = new System.Drawing.Point(152, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 78);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.panelGradient1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(35, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn file CSV để tải lên";
            this.label2.Click += new System.EventHandler(this.panelGradient1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.BackGroundColor = System.Drawing.Color.Black;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(316, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 45);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(53, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbIdStudent
            // 
            this.tbIdStudent.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdStudent.BorderColor = System.Drawing.Color.Black;
            this.tbIdStudent.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbIdStudent.BorderRadius = 10;
            this.tbIdStudent.BorderSize = 2;
            this.tbIdStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdStudent.ForeColor = System.Drawing.Color.DimGray;
            this.tbIdStudent.Location = new System.Drawing.Point(198, 23);
            this.tbIdStudent.Margin = new System.Windows.Forms.Padding(4);
            this.tbIdStudent.Multiline = false;
            this.tbIdStudent.Name = "tbIdStudent";
            this.tbIdStudent.Padding = new System.Windows.Forms.Padding(7);
            this.tbIdStudent.PasswordChar = false;
            this.tbIdStudent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbIdStudent.PlaceholderText = "";
            this.tbIdStudent.Size = new System.Drawing.Size(227, 38);
            this.tbIdStudent.TabIndex = 1;
            this.tbIdStudent.Texts = "";
            this.tbIdStudent.UnderlinedStyle = false;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 334);
            this.Controls.Add(this.panelGradient1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbIdStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmAddStudent";
            this.Text = "frmAddStudent";
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MyCustomControl.CustomTextBox tbIdStudent;
        private MyCustomControl.CustomButton btnAdd;
        private MyCustomControl.CustomButton btnCancel;
        private MyCustomControl.PanelGradient panelGradient1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}