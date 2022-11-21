using System;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Complexity : Form
    {
        Logger logger = new Logger();
        public Complexity()
        {
            InitializeComponent();
        }

        private void Complexity_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            if(complexityLevel.Text.Length == 0)
            {
                MessageBox.Show("Choose the level of complexity");
            }
            else
            {
                logger.Log(complexityLevel.Text + " level chosen");
                Hide();
                Game gameWindow = new Game((string)complexityLevel.SelectedItem);
                gameWindow.Show();
            }
        }
    }
}
