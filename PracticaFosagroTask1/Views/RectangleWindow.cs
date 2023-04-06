using PracticaFosagroTask1.Model;
using System;
using System.Windows.Forms;

namespace PracticaFosagroTask1.Views
{
    public partial class RectangleWindow : Form
    {
        public RectangleWindow()
        {
            InitializeComponent();
            material.DataSource = Mater.MaterListt;
        }

        private void AddRectangle_Click(object sender, EventArgs e)
        {

            var A = new Rectangle
            (
                Convert.ToDouble(RecA.Text),
                Convert.ToDouble(RecB.Text),
                Convert.ToDouble(RecH.Text),
                Convert.ToDouble(RecA.Text) * Convert.ToDouble(RecB.Text) * Convert.ToDouble(RecH.Text),
                Mater.Materialls[material.Text]* Convert.ToDouble(RecA.Text) * Convert.ToDouble(RecB.Text) * Convert.ToDouble(RecH.Text)
            );
            ObjectLists.YUDetail(A);       
        }
    }
}
