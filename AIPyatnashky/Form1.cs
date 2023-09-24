using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIPyatnashky
{
    public partial class Form1 : Form
    {
        MainGame game;
        public Form1()
        {
            InitializeComponent();

            var buttons = new Button[] { this.button1, this.button2, this.button3,
                                         this.button4, this.button5, this.button6,
                                         this.button7, this.button8, this.button9};

            game = new MainGame(buttons);

        }

        private async void button10_Click(object sender, System.EventArgs e)
        {
            await Task.Run(() =>
                {
                    var mainAlgorithm = new MainAlgorythm();
                    mainAlgorithm.DoMainAlgorythm(game.GameMatrix, this);
                    
                });
            var form2 = new Form2();
            form2.Show();
        }
    }
}
