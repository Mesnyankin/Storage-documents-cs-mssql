﻿using System;
using System.Windows.Forms;

namespace Mostootriad_55
{
    public partial class ScanSelectSellersValue : Form
    {
        public ScanSelectSellersValue()
        {
            InitializeComponent();
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mdlData.ScanDocRadioBtn = 0;
            this.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mdlData.ScanDocRadioBtn = 1;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mdlData.ScanDocRadioBtn = 2;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            mdlData.ScanDocRadioBtn = 3;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            mdlData.ScanDocRadioBtn = 4;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            mdlData.ScanDocRadioBtn = 5;
        }
        private void ScanSelectSellersValue_FormClosed(object sender, EventArgs e)
        {
            mdlData.ScanDocRadioBtn = 0;
            mdlData.CountScanDocument = 0;
        }
        private void ActiveButton(bool Enabled)
        {
            btnScan.Enabled = Enabled;
            button2.Enabled = Enabled;
            radioButton1.Enabled = Enabled;
            radioButton2.Enabled = Enabled;
            radioButton3.Enabled = Enabled;
            radioButton4.Enabled = Enabled;
            radioButton5.Enabled = Enabled;
            label1.Enabled = Enabled;
        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            ActiveButton(false);
            if (mdlData.ScanDocRadioBtn == 0)
            {
                MessageBox.Show("Вы ничего не выбрали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (mdlData.ScanDocRadioBtn > 0 && mdlData.CountScanDocument == 0)
            {
                mdlData.StatusAdd = false;
                AddSellers Form = new AddSellers();
                Form.Owner = this;
                Form.Show();
                mdlData.CountScanDocument++;
            }
            else if (mdlData.ScanDocRadioBtn > 0 && mdlData.CountScanDocument != 0)
            {
                Data.EventHandlerScan();
            }
            ActiveButton(true);
        }
    }
}
