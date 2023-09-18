using System;
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

        public void InitTile()
        {
            if (TileNumber == 0)
                TileButton.Text = "";
            else
                TileButton.Text = Convert.ToString(TileNumber);

            TileButton.Font = new System.Drawing.Font("Times New Roman", 60);
        }
    }
}
