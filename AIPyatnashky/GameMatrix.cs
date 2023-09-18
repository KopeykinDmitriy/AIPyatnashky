namespace AIPyatnashky
{
    public class GameMatrix
    {
        public GameTile[] GameTileMatrix;

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
            var tempGameTile = GameTileMatrix[idA];
            GameTileMatrix[idA] = GameTileMatrix[idB];
            GameTileMatrix[idB] = tempGameTile;
        }
    }
}
