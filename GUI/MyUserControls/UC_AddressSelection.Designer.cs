namespace GUI.MyUserControls
{
    partial class UC_AddressSelection
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTinhThanhPho = new System.Windows.Forms.ComboBox();
            this.comboBoxQuanHuyen = new System.Windows.Forms.ComboBox();
            this.comboBoxXaPhuong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tỉnh/ Thành phố:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Huyện/ Quận:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xã/ Phường:";
            // 
            // comboBoxTinhThanhPho
            // 
            this.comboBoxTinhThanhPho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTinhThanhPho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTinhThanhPho.FormattingEnabled = true;
            this.comboBoxTinhThanhPho.Location = new System.Drawing.Point(146, 10);
            this.comboBoxTinhThanhPho.Name = "comboBoxTinhThanhPho";
            this.comboBoxTinhThanhPho.Size = new System.Drawing.Size(177, 24);
            this.comboBoxTinhThanhPho.TabIndex = 3;
            this.comboBoxTinhThanhPho.SelectedIndexChanged += new System.EventHandler(this.comboBoxTinhThanhPho_SelectedIndexChanged);
            // 
            // comboBoxQuanHuyen
            // 
            this.comboBoxQuanHuyen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxQuanHuyen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxQuanHuyen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxQuanHuyen.FormattingEnabled = true;
            this.comboBoxQuanHuyen.Location = new System.Drawing.Point(482, 9);
            this.comboBoxQuanHuyen.Name = "comboBoxQuanHuyen";
            this.comboBoxQuanHuyen.Size = new System.Drawing.Size(177, 24);
            this.comboBoxQuanHuyen.TabIndex = 4;
            this.comboBoxQuanHuyen.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuanHuyen_SelectedIndexChanged);
            // 
            // comboBoxXaPhuong
            // 
            this.comboBoxXaPhuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxXaPhuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxXaPhuong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxXaPhuong.FormattingEnabled = true;
            this.comboBoxXaPhuong.Location = new System.Drawing.Point(814, 11);
            this.comboBoxXaPhuong.Name = "comboBoxXaPhuong";
            this.comboBoxXaPhuong.Size = new System.Drawing.Size(177, 24);
            this.comboBoxXaPhuong.TabIndex = 5;
            // 
            // UC_AddressSelection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.comboBoxXaPhuong);
            this.Controls.Add(this.comboBoxQuanHuyen);
            this.Controls.Add(this.comboBoxTinhThanhPho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddressSelection";
            this.Size = new System.Drawing.Size(1006, 39);
            this.Load += new System.EventHandler(this.UC_AddressSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTinhThanhPho;
        private System.Windows.Forms.ComboBox comboBoxQuanHuyen;
        private System.Windows.Forms.ComboBox comboBoxXaPhuong;
    }
}
