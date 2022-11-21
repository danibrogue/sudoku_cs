using System;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Greeting : Form
    {
        Logger logger = new Logger();
        public Greeting()
        {
            InitializeComponent();
            logger.Log("Game launched");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Hide();
            var cmplx = new Complexity();
            cmplx.Show();
        }

        private void Greeting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
