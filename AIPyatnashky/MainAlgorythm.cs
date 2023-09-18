using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPyatnashky
{
    public class MainAlgorythm
    {
        public List<GameMatrix> gameMatrices = new List<GameMatrix>();

        public MainAlgorythm(GameMatrix gameMatrix) 
        {
            gameMatrix.Height = 0;
            gameMatrix.InitDiff();
            gameMatrices.Add(gameMatrix);
        }

        public void CreateNewMatrices()
        {

        }
    }
}
