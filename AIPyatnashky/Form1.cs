using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace AIPyatnashky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var buttons = new Button[] { this.button1, this.button2, this.button3,
                                         this.button4, this.button5, this.button6,
                                         this.button7, this.button8, this.button9};

            var mainGame = new MainGame(buttons);

            var gameMatrix = mainGame.GameMatrix;


        }
    }
}
