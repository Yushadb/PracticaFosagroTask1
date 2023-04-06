using PracticaFosagroTask1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFosagroTask1.Views
{
    public partial class CircleWindow : Form
    {
        public CircleWindow()
        {
            InitializeComponent();
            material.DataSource = Mater.MaterListt;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            var A = new Circle
            (
                Convert.ToDouble(CirR.Text),
                Math.Pow(Convert.ToDouble(CirR.Text),2)*(4.0/3.0)*Math.PI,
                Mater.Materialls[material.Text] * Math.Pow(Convert.ToDouble(CirR.Text), 2) * (4.0 / 3.0) * Math.PI
            );
            ObjectLists.YUDetail(A);
        }
    }
}
