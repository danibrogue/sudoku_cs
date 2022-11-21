using System;

namespace Sudoku
{
    class Logger
    {
        public void Log(string msg)
        {
            using (var sw = new System.IO.StreamWriter("Actions.txt", true))
            {
                sw.WriteLine(DateTime.Now + " " + msg);
            }
        }
    }
}
