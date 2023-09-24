using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIPyatnashky
{
    public static class ListExecutor
    {
        public static List<GameMatrix> gameMatrices = new List<GameMatrix>();

        public static ListBox listBox;

        private static int count = 0;

        public static Form2 MainForm;

        public static void AddToList(GameMatrix matrix)
        {

            gameMatrices.Add(new GameMatrix(matrix));
            count++;

            var outputString = $"{count}) Diff = {matrix.Diff}, Height = {matrix.Height}";

            MainForm.Invoke((MethodInvoker)delegate { listBox.Items.Add(outputString); });
        }
    }
}
