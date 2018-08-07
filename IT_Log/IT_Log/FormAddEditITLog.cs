using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Log
{
    public partial class FormAddEditITLog : Form
    {
        public FormAddEditITLog()
        {
            InitializeComponent();
        }

        private void FormAddEditITLog_Load(object sender, EventArgs e)
        {
            comboBoxITPersonnel.SelectedIndex = 0;
        }

        private void FormAddEditITLog_Load_1(object sender, EventArgs e)
        {

        }
    }
}
