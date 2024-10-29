using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELM_ATLAS
{
    public partial class StatusElement : UserControl
    {
        public StatusElement()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        public string Error
        {
            get => label2.Text;
            set => label2.Text = value;
        }

        public bool PictureBoxVisible
        {
            get => check.Visible;
            set => check.Visible = value; // Set the PictureBox visibility from outside
        }

        public bool PictureBoxErrorVisible
        {
            get => errorPb.Visible;
            set => errorPb.Visible = value; // Set the PictureBox visibility from outside
        }
    }
}
