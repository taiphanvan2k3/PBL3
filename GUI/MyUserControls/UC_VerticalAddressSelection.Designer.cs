namespace GUI.MyUserControls
{
    partial class UC_VerticalAddressSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQuanHuyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxXaPhuong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTinhThanhPho = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tỉnh/ Thành phố:";
            // 
            // comboBoxQuanHuyen
            // 
            this.comboBoxQuanHuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQuanHuyen.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxQuanHuyen.BorderRadius = 8;
            this.comboBoxQuanHuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxQuanHuyen.DropDownHeight = 300;
            this.comboBoxQuanHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuanHuyen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxQuanHuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxQuanHuyen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQuanHuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxQuanHuyen.IntegralHeight = false;
            this.comboBoxQuanHuyen.ItemHeight = 30;
            this.comboBoxQuanHuyen.Location = new System.Drawing.Point(146, 72);
            this.comboBoxQuanHuyen.Name = "comboBoxQuanHuyen";
            this.comboBoxQuanHuyen.Size = new System.Drawing.Size(282, 36);
            this.comboBoxQuanHuyen.TabIndex = 13;
            this.comboBoxQuanHuyen.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuanHuyen_SelectedIndexChanged);
            // 
            // comboBoxXaPhuong
            // 
            this.comboBoxXaPhuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxXaPhuong.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxXaPhuong.BorderRadius = 8;
            this.comboBoxXaPhuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxXaPhuong.DropDownHeight = 300;
            this.comboBoxXaPhuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxXaPhuong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxXaPhuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxXaPhuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxXaPhuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxXaPhuong.IntegralHeight = false;
            this.comboBoxXaPhuong.ItemHeight = 30;
            this.comboBoxXaPhuong.Location = new System.Drawing.Point(146, 132);
            this.comboBoxXaPhuong.Name = "comboBoxXaPhuong";
            this.comboBoxXaPhuong.Size = new System.Drawing.Size(282, 36);
            this.comboBoxXaPhuong.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Huyện/ Quận:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Xã/ Phường:";
            // 
            // comboBoxTinhThanhPho
            // 
            this.comboBoxTinhThanhPho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTinhThanhPho.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxTinhThanhPho.BorderRadius = 8;
            this.comboBoxTinhThanhPho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTinhThanhPho.DropDownHeight = 300;
            this.comboBoxTinhThanhPho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTinhThanhPho.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTinhThanhPho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTinhThanhPho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTinhThanhPho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxTinhThanhPho.IntegralHeight = false;
            this.comboBoxTinhThanhPho.ItemHeight = 30;
            this.comboBoxTinhThanhPho.Location = new System.Drawing.Point(146, 15);
            this.comboBoxTinhThanhPho.Name = "comboBoxTinhThanhPho";
            this.comboBoxTinhThanhPho.Size = new System.Drawing.Size(282, 36);
            this.comboBoxTinhThanhPho.TabIndex = 17;
            this.comboBoxTinhThanhPho.SelectedIndexChanged += new System.EventHandler(this.comboBoxTinhThanhPho_SelectedIndexChanged);
            this.comboBoxTinhThanhPho.Click += new System.EventHandler(this.comboBoxTinhThanhPho_Click);
            // 
            // UC_VerticalAddressSelection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.comboBoxTinhThanhPho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxXaPhuong);
            this.Controls.Add(this.comboBoxQuanHuyen);
            this.Controls.Add(this.label1);
            this.Name = "UC_VerticalAddressSelection";
            this.Size = new System.Drawing.Size(437, 177);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxQuanHuyen;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxXaPhuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxTinhThanhPho;
    }
}
