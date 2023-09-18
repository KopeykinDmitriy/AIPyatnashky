namespace AIPyatnashky
{
    public class GameMatrix
    {
        public GameTile[] GameTileMatrix;

        public GameMatrix(GameTile[] gameTileMatrix) 
        {
            GameTileMatrix = gameTileMatrix;
        }

        public GameTile[] GetTileMatrix()
        {
            return GameTileMatrix;
        }

        public void SetTileMatrix(GameTile[] gameTileMatrix)
        {
            if (gameTileMatrix.Length == Constants.DIMENSION * Constants.DIMENSION)
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
    }
}
