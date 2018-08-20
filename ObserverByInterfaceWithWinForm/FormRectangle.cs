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
    public partial class FormRectangle : Form , IMyObserver
    {
        public FormRectangle()
        {
            InitializeComponent();
        }

        public void Update(int i_Count)
        {
            
                this.CreateGraphics().Clear(this.BackColor);

                SolidBrush myBrush = new SolidBrush(Color.BlueViolet);

                Graphics graphicRectangle = CreateGraphics();

                int sizeOfRectangle = i_Count * 10;

                graphicRectangle.FillRectangle(myBrush, new Rectangle(0, 0, sizeOfRectangle, sizeOfRectangle));

                myBrush.Dispose();
                graphicRectangle.Dispose();
            
            

        }
    }
}
