using System.Windows.Forms;
using AbstractTask1.Controller;
using AbstractTask1.Model;

namespace AbstractTask1.View
{
    public partial class Main : Form
    {
        private MediumManager _mediumManager = new MediumManager();
        public Main()
        {
            InitializeComponent();
        }

        private void BtnShowCompactDiscs_Click(object sender, System.EventArgs e)
        {
            _mediumManager.AddMedium(new Cd("TMMLP2",180,"Eminem",16));
            _mediumManager.AddMedium(new Cd("TMMLP2", 180, "Eminem", 16){Comment = "asdf", Mine = true});
            _mediumManager.AddMedium(new Cd("TMMLP2", 180, "Eminem", 16));
            _mediumManager.AddMedium(new Cd("TMMLP2", 180, "Eminem", 16));
            _mediumManager.AddMedium(new Cd("TMMLP2", 180, "Eminem", 16));
            LsbCompactDiscs.Items.Clear();
            LsbCompactDiscs.Items.AddRange(_mediumManager.GetAllCompactDiscs());
        }

        private void BtnShowDigitalVideoDiscs_Click(object sender, System.EventArgs e)
        {
            _mediumManager.AddMedium(new Dvd("TMMLP2", 180, "Ueli"));
            _mediumManager.AddMedium(new Dvd("TMMLP2", 180, "Fritz"));
            _mediumManager.AddMedium(new Dvd("TMMLP2", 180, "Franz") { Comment = "asdf", Mine = true });
            _mediumManager.AddMedium(new Dvd("TMMLP2", 180, "Gabriel"));
            _mediumManager.AddMedium(new Dvd("TMMLP2", 180, "Gabriel"));
            LsbDigitalVideoDiscs.Items.Clear();
            LsbDigitalVideoDiscs.Items.AddRange(_mediumManager.GetAllDigitalVideoDiscs());
        }
    }
}
