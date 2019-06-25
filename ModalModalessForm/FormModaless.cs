using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModalModalessForm
{
    public partial class FormModaless : Form
    {
        public FormModaless()
        {
            InitializeComponent();
        }

        private void FormModaless_Load(object sender, EventArgs e)
        {

        }
        public string Title
        {
            set { this.Text = value; }
        }
    }
}
