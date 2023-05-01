﻿using BLL;
using GUI.MyUserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTaoCauHoi : Form
    {
        private int PreviousHeightOfTextboxCauHoi;
        private List<UC_DapAnControl> dsDapAn;
        public frmTaoCauHoi()
        {
            InitializeComponent();
            PreviousHeightOfTextboxCauHoi = textBoxCauHoi.MinimumSize.Height;
        }

        private void checkBoxSingleMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSingleMulti.Checked)
            {
                groupBoxSingleChoice.Visible = false;
                groupBoxMultiChoices.Visible = true;
                groupBoxMultiChoices.Location = groupBoxSingleChoice.Location;
            }
            else
            {
                groupBoxSingleChoice.Visible = true;
                groupBoxMultiChoices.Visible = false;
                groupBoxMultiChoices.Location = groupBoxSingleChoice.Location;
            }
        }

        private void FormTaoCauHoi_Load(object sender, EventArgs e)
        {
            dsDapAn = new List<UC_DapAnControl>();
            for (int i = 1; i <= 4; i++)
            {
                UC_DapAnControl da = new UC_DapAnControl() { STT = i };
                da.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                panelDanhSachDapAn.Controls.Add(da);

                dsDapAn.Add(da);
            }
        }

        private void selectChoiceChanged(object sender, EventArgs e)
        {
            RadioButton src = sender as RadioButton;
            foreach (var control in groupBoxMultiChoices.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox temp = control as CheckBox;
                    if (temp.Text == src.Text)
                    {
                        temp.Checked = src.Checked;
                        break;
                    }
                }
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (textBoxCauHoi.Text == "")
                check = false;
            string input = textBoxCauHoi.Text;
            foreach (UC_DapAnControl item in dsDapAn)
            {
                if (item.DapAn == "")
                {
                    check = false;
                    break;
                }
                else
                {
                    input += "\n" + item.DapAn;
                }
            }

            if (!check)
                MessageBox.Show("Bạn cần phải nhập đầy đủ các nội dung cần thiết cho câu hỏi");
            else
            {
                MessageBox.Show(input);
            }
        }

        private void textBoxCauHoi_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCauHoi.Text == "")
                labelCheck.Visible = true;
            else
            {
                int HeightText = UtilityClass.CalculateHeightOfControl(textBoxCauHoi);
                if (HeightText > textBoxCauHoi.Height)
                {
                    int offset = HeightText - textBoxCauHoi.Height;
                    textBoxCauHoi.Height = HeightText;
                    panelDanhSachDapAn.Location = new System.Drawing.Point(panelDanhSachDapAn.Location.X,
                                                    panelDanhSachDapAn.Location.Y + offset);
                    this.Height += offset;
                    PreviousHeightOfTextboxCauHoi = HeightText;
                }
                else if (HeightText < PreviousHeightOfTextboxCauHoi && HeightText >=
                                                                    textBoxCauHoi.MinimumSize.Height)
                {
                    int offset = PreviousHeightOfTextboxCauHoi - HeightText;
                    textBoxCauHoi.Height = HeightText;
                    panelDanhSachDapAn.Location = new System.Drawing.Point(panelDanhSachDapAn.Location.X,
                                                   panelDanhSachDapAn.Location.Y - offset);
                    this.Height -= offset;
                    PreviousHeightOfTextboxCauHoi = HeightText;
                }
                labelCheck.Visible = false;
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panelDanhSachDapAn_Resize(object sender, EventArgs e)
        {
            foreach (UC_DapAnControl uc in panelDanhSachDapAn.Controls)
                uc.Width = panelDanhSachDapAn.Width;
        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            panelDanhSachDapAn.Height += 100;
        }


    }
}
