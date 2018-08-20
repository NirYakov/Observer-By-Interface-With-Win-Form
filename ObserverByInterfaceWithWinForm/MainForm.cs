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
    public partial class MainForm : Form
    {
        private readonly Counter m_Counter = new Counter();

        public MainForm()
        {
            InitializeComponent();
            initializeForm();
        }

        private void initializeForm()
        {
            FormText formText = new FormText();
            FormRectangle formRectangle = new FormRectangle();
            m_Counter.RegisterObserver(formText);
            m_Counter.RegisterObserver(formRectangle);
            formText.Show();
            formRectangle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_Counter.AddOneToCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_Counter.LessOneToCount();
        }
    }
}
