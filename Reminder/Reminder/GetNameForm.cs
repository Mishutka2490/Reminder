using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder {
    public partial class GetNameForm : Form {
        public GetNameForm() {
            InitializeComponent();
        }

        public string getName() {
            return nameTextBox.Text;
        }

        private void OKButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
