using System.Collections.Generic;

namespace AIPyatnashky
{
    public class GameMatrix
    {
        public List<GameTile> GameTileMatrix;

        public int Height { get; set; }

        public int Diff { get; set; }

        public GameMatrix(List<GameTile> gameTileMatrix) 
        {
            GameTileMatrix = gameTileMatrix;
        }

        public List<GameTile> GetTileMatrix()
        {
            return GameTileMatrix;
        }

        public void SetTileMatrix(List<GameTile> gameTileMatrix)
        {
            if (gameTileMatrix.Count == Constants.DIMENSION * Constants.DIMENSION)
                GameTileMatrix = gameTileMatrix;
        }

        public void SwapTiles(int idA, int idB)
        {
            if ((idA < 0) || (idB < 0)) return;
            (GameTileMatrix[idB].TileNumber, GameTileMatrix[idA].TileNumber) = 
                (GameTileMatrix[idA].TileNumber, GameTileMatrix[idB].TileNumber);
        }

        public void InitTiles()
        {
            foreach(var tile in GameTileMatrix)
                tile.InitTile(); 
        }

        public void InitDiff()
        {
            var diff = 0;
            for (int i = 0; i < Constants.DIMENSION * Constants.DIMENSION - 1; i++)
            {
                if (GameTileMatrix[i].TileNumber != i + 1) diff++;
            }
            if (GameTileMatrix[Constants.DIMENSION * Constants.DIMENSION].TileNumber != 0)
                diff++;
            Diff = diff;
        }

        public bool Equals(GameMatrix gameMatrix)
        {
            if (this.GameTileMatrix.Equals(gameMatrix.GameTileMatrix))
                return true;
            return false;
        }

        public void LeftTurn()
        {
            if (GameTileMatrix[0].TileNumber == 0 || GameTileMatrix[3].TileNumber == 0
                || GameTileMatrix[6].TileNumber == 0) return;
            for (int i = 0; i < Constants.DIMENSION * Constants.DIMENSION; i++)
                if (GameTileMatrix[i].TileNumber == 0)
                {
                    SwapTiles(i, i - 1);
                    break;
                }    
        }

        public void UpTurn()
        {
            if (GameTileMatrix[0].TileNumber == 0 || GameTileMatrix[1].TileNumber == 0
                || GameTileMatrix[2].TileNumber == 0) return;
            for (int i = 0; i < Constants.DIMENSION * Constants.DIMENSION; i++)
                if (GameTileMatrix[i].TileNumber == 0)
                {
                    SwapTiles(i, i - 3);
                    break;
                }
        }

        public void RightTurn()
        {
            if (GameTileMatrix[2].TileNumber == 0 || GameTileMatrix[5].TileNumber == 0
                || GameTileMatrix[8].TileNumber == 0) return;
            for (int i = 0; i < Constants.DIMENSION * Constants.DIMENSION; i++)
                if (GameTileMatrix[i].TileNumber == 0)
                {
                    SwapTiles(i, i + 1);
                    break;
                }
        }

        public void DownTurn()
        {
            if (GameTileMatrix[6].TileNumber == 0 || GameTileMatrix[7].TileNumber == 0
                || GameTileMatrix[8].TileNumber == 0) return;
            for (int i = 0; i < Constants.DIMENSION * Constants.DIMENSION; i++)
                if (GameTileMatrix[i].TileNumber == 0)
                {
                    SwapTiles(i, i + 3);
                    break;
                }
        }
    }
}
