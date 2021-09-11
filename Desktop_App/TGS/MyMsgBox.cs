using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TGS {
    public partial class MyMsgBox : Form {
        public MyMsgBox() {
            InitializeComponent();
        }

        // Remove the border
        protected override void WndProc(ref Message m) {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) {
                return;
            }
            base.WndProc(ref m);
        }

        // Body
        public DialogResult Result {
            get;
            private set;
        }

        public static DialogResult Show(string message) {
            var MsgBox = new MyMsgBox();
            MsgBox.lbl_MsgBoxMessage.Text = message;
            MsgBox.ShowDialog();
            return MsgBox.Result;
        }


        

        private void btn_Yes_Click(object sender, EventArgs e) {
            Result = DialogResult.Yes;
            Close();
        }

        private void iconButton1_Click(object sender, EventArgs e) {
            Result = DialogResult.No;
            Close();
        }
    }
}
