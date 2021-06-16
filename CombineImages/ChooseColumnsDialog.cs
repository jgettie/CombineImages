using System;
using System.Windows.Forms;

namespace CombineImages
{
    public partial class ChooseColumnsDialog : Form
    {
        public static int ChooseColumnCount(Form owner, int maximumCount)
        {
            var dialog = new ChooseColumnsDialog(maximumCount);
            dialog.ShowDialog(owner);
            return (int)dialog.nudColumns.Value;
        }

        private ChooseColumnsDialog(int maximumCount)
        {
            InitializeComponent();

            nudColumns.Minimum = 1;
            nudColumns.Maximum = maximumCount;
            nudColumns.Value = maximumCount;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
