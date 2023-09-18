using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIPyatnashky
{
    public class MainGame
    {
        public Button[] Buttons;
        public GameMatrix GameMatrix { get; set; }
        public MainGame(Button[] buttons) 
        {
            Buttons = buttons;

            GameMatrix gameMatrix = InitializeMatrix();

            RandomMatrix(gameMatrix);

            Update(gameMatrix);

            GameMatrix = gameMatrix;
        }

        public GameMatrix InitializeMatrix() 
        {
            var gameTiles = new List<GameTile>(Constants.DIMENSION * Constants.DIMENSION);
            for (int i = 0; i < Constants.DIMENSION * Constants.DIMENSION; i++)
            {
                gameTiles[i] = new GameTile(i, Buttons[i]);
            }
            var gameMatrix = new GameMatrix(gameTiles);
            return gameMatrix;
        }

        public void Update(GameMatrix gameMatrix) 
        {
            gameMatrix.InitTiles();
        }

        public void RandomMatrix(GameMatrix gameMatrix)
        {
            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(10);
                var a = new Random();
                Thread.Sleep(10);
                var b = new Random();
                gameMatrix.SwapTiles(a.Next(9), b.Next(9));
            }
        }
    }
}
