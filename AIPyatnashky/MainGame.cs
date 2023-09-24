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
            for (int i = 0; i < Constants.DIMENSION * Constants.DIMENSION - 1; i++)
            {
                gameTiles.Add(new GameTile(i + 1, Buttons[i]));
            }
            gameTiles.Add(new GameTile(0, Buttons[8]));
            var gameMatrix = new GameMatrix(gameTiles);
            return gameMatrix;
        }

        public void Update(GameMatrix gameMatrix) 
        {
            gameMatrix.InitTiles();
        }

        public void RandomMatrix(GameMatrix gameMatrix)
        {
            for (int i = 1; i <= 50; i++)
            {
                Thread.Sleep(10);
                var a = new Random();
                var turn = a.Next(1, 5);
                switch(turn)
                {
                    case 1:
                        gameMatrix.DownTurn();
                        break;
                    case 2:
                        gameMatrix.UpTurn();
                        break;
                    case 3:
                        gameMatrix.LeftTurn();
                        break;
                    case 4: 
                        gameMatrix.RightTurn();
                        break;
                    default:
                        throw new Exception();
                }
            }
        }
    }
}
