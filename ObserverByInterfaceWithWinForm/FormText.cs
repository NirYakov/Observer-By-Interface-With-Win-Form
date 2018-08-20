using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverByInterfaceWithWinForm
{
    public partial class FormText : Form , IMyObserver
    {
        public FormText()
        {
            InitializeComponent();
        }

        public void Update(int i_Count)
        {
            label1.Text = i_Count.ToString();
        }
    }
}
