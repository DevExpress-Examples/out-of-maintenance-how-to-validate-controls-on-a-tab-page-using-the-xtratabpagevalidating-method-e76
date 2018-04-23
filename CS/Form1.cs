using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ValidatingTabs {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private bool ValidatePage1() {
            bool validated = spinEdit1.Value > 10;
            if(!validated)
                MessageBox.Show("The value must be greater than 10");
            else {
                validated = DateTime.Today.Equals(dateEdit1.DateTime);
                if(!validated)
                    MessageBox.Show("The date must be equal the today date");
            }
            return validated;
        }

        private void xtraTabPage1_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidatePage1();
        }
    }
}