using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Sudoku
{
    public partial class Game : Form
    {
        Logger logger = new Logger();
        public const int SIZE = 9;
        public const int CELL_SIZE = 3;
        public Game(string cmplx)
        {
            InitializeComponent();
            var rand = new Random();
            switch (cmplx) {
                case "Easy":
                    StartingFill(38);
                    break;
                case "Medium":
                    StartingFill(30);
                    break;
                case "Hard":
                    StartingFill(25);
                    break;
            }
        }
        private void Trigger(object sender, EventArgs eventArgs)
        {
            Button button = sender as Button;
            button.Text = chosen.Text;
            logger.Log("Digit set");
        }

        private void Choose(object sender, EventArgs eventArgs)
        {
            Button button = sender as Button;
            chosen.Text = button.Text;
        }

        private Control FindControl(int ind)
        {
            Control retCtrl = null;
            foreach(Control ctrl in Grid.Controls.OfType<Button>())
            {
                if (ind == ctrl.TabIndex)
                {
                    retCtrl = ctrl;
                    break;
                }
            }
            return retCtrl;
        }

        private void StartingFill(int amount)
        {
            var val = new List<int>();
            var pos = new List<int>();
            string fileName = "";
            string[] vals = { }, poss = { };
            Random rand = new Random();
            switch (amount)
            {
                case 38:
                    fileName = "Easy.txt";
                    break;
                case 30:
                    fileName = "Medium.txt";
                    break;
                case 25:
                    fileName = "Hard.txt";
                    break;
            }
            var sr = new StreamReader(fileName);
            for(int i = 0; i < rand.Next(1, 4); ++i)
            {
                vals = sr.ReadLine().Split(' ');
                poss = sr.ReadLine().Split(' ');
            }
            for(int i = 0; i < amount; ++i)
            {
                val.Add(Convert.ToInt32(vals[i]));
                pos.Add(Convert.ToInt32(poss[i]));
            }
            foreach (Button i in Grid.Controls.OfType<Button>())
            {
                if (pos.Contains(i.TabIndex))
                    i.Text = val[pos.IndexOf(i.TabIndex)].ToString();
            }
        }

        private bool CorrectCheck(int tag, int value)
        {
            int y = tag / SIZE;
            int x = tag - y * SIZE;
            //проверка по столбику
            for (int i = 0; i < SIZE; ++i)
            {
                int cur = i * SIZE + x;
                if (cur == tag) continue;
                if(Grid.Controls.OfType<Button>()
                    .Where(c => c.TabIndex == cur)
                    .Select(c => c.Text).First() == "")
                    return false;
                if (value == Convert.ToInt32(Grid.Controls.OfType<Button>()
                    .Where(c => c.TabIndex == cur)
                    .Select(c => c.Text).First()))
                    return false;
            }
            //проверка по строке
            for (int i = 0; i < SIZE; ++i)
            {
                int cur = y * SIZE + i;
                if (cur == tag) continue;
                if (Grid.Controls.OfType<Button>()
                    .Where(c => c.TabIndex == cur)
                    .Select(c => c.Text).First() == "")
                    return false;
                if (value == Convert.ToInt32(Grid.Controls.OfType<Button>()
                    .Where(c => c.TabIndex == cur)
                    .Select(c => c.Text).First()))
                    return false;
            }
            //проверка по квадрату
            int cell_x = x / CELL_SIZE;
            int cell_y = y / CELL_SIZE;
            for (int i = 0; i < CELL_SIZE; ++i)
            {
                for (int j = 0; j < CELL_SIZE; ++j)
                {
                    int cur = (cell_x * CELL_SIZE + j) + ((cell_y * CELL_SIZE + i) * SIZE);
                    if (cur == tag) continue;
                    if (Grid.Controls.OfType<Button>()
                        .Where(c => c.TabIndex == cur)
                        .Select(c => c.Text).First() == "")
                        return false;
                    if (value == Convert.ToInt32(Grid.Controls.OfType<Button>()
                    .Where(c => c.TabIndex == cur)
                    .Select(c => c.Text).First()))
                        return false;
                }
            }
            return true;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            logger.Log("Checked");
            bool correct = false;
            foreach(Button i in Grid.Controls.OfType<Button>())
            {
                correct = CorrectCheck(i.TabIndex, Convert.ToInt32(i.Text));
                if (correct == false) return;
            }
            MessageBox.Show("You win!");
            logger.Log("Victory");
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            logger.Log("Game restarted");
            Hide();
            var cmplx = new Complexity();
            cmplx.Show();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            logger.Log("Help called");
            MessageBox.Show("Click on the needed digit on the right panel, then click on the box you want to fill. " +
                "Click the check button when you will be sure you filled the grid correctly.\n\n" +
                "The objective is to fill a 9×9 grid with digits so that each column, each row, and each of the nine 3×3 " +
                "subgrids that compose the grid contain all of the digits from 1 to 9.");
        }
    }
}
