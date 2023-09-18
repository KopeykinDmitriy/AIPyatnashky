using System.Windows.Forms;

namespace AIPyatnashky
{
    public class GameTile
    {
        /// <summary>
        /// Номер плитки
        /// </summary>
        public int TileNumber { get; set; }

        /// <summary>
        /// Button, к которой привязана плитка
        /// </summary>
        public Button TileButton { get; set; }

        public GameTile(int tileNumber, Button tileButton)
        {
            TileNumber= tileNumber;
            TileButton= tileButton;
        }
    }
}
