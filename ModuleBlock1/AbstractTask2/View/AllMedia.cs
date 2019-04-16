using System;
using System.Windows.Forms;
using AbstractTask2.Controller;

namespace AbstractTask2.View
{
    public partial class AllMedia : Form
    {
        private readonly MediumManager _mediumManager;
        public AllMedia(MediumManager manger)
        {
            InitializeComponent();
            _mediumManager = manger;
        }

        private void BtnShowAllMedium_Click(object sender, EventArgs e)
        {
            LsbAllMediums.Items.Clear();
            LsbAllMediums.Items.AddRange(_mediumManager.GetAllMedia());
        }
    }
}
