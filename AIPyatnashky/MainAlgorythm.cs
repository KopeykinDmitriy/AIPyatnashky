using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIPyatnashky
{
    public class MainAlgorythm
    {
        public List<GameMatrix> gameMatrices = new List<GameMatrix>();

        private GameMatrix bestGameMatrix;

        private Form1 MainForm;

        public async void DoMainAlgorythm(GameMatrix gameMatrix, Form1 mainForm)
        {
            await Task.Run(() =>
            {
                ListExecutor.gameMatrices = new List<GameMatrix>(gameMatrices);

                MainForm = mainForm;

                gameMatrix.Height = 0;
                gameMatrix.InitDiff();
                gameMatrices.Add(gameMatrix);
                bestGameMatrix = gameMatrix;
                while (bestGameMatrix.Diff != 0)
                {
                    bestGameMatrix = CreateNewMatrices(bestGameMatrix);
                    ListExecutor.AddToList(new GameMatrix(bestGameMatrix, 1));
                }
            });
        }

        private GameMatrix CreateNewMatrices(GameMatrix gameMatrix)
        {
            for (int i = 0; i < 4; i++)
            {
                var newGameMatrix = new GameMatrix(gameMatrix);
                switch (i)
                {
                    case 0:
                        newGameMatrix.DownTurn();
                        break;
                    case 1:
                        newGameMatrix.UpTurn();
                        break;
                    case 2:
                        newGameMatrix.LeftTurn();
                        break;
                    case 3:
                        newGameMatrix.RightTurn();
                        break;
                }
                bool equal = false;
                foreach (var matrix in gameMatrices)
                {
                    if (newGameMatrix.Equals(matrix))
                        equal = true;
                }
                if (!equal)
                {
                    newGameMatrix.InitDiff();
                    gameMatrices.Add(newGameMatrix);
                }
            }
            gameMatrix.isUsed = true;
            var nextGameMatrix = gameMatrices[0];
            var capacity = int.MaxValue;
            foreach (var matrix in gameMatrices)
            {
                if (Formula(matrix) < capacity && !matrix.isUsed)
                {
                    capacity = Formula(matrix);
                    nextGameMatrix = matrix;
                }
            }
            MainForm.Invoke((MethodInvoker)delegate { nextGameMatrix.InitTiles(); });
            return nextGameMatrix;
        }

        private int Formula(GameMatrix gameMatrix)
        {
            return gameMatrix.Height + gameMatrix.Diff;
        }
    }
}
