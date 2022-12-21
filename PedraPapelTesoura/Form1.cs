namespace PedraPapelTesoura
{
    public partial class Form1 : Form
    {
        Image[] imgCpu = new Image[]
        {
            Properties.Resources.PedraC,
            Properties.Resources.PapelC,
            Properties.Resources.TesouraC
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClickJogada(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            PicJogador.Image = bt.BackgroundImage;

            Jogada jogadaJogador = RetornaJogadaDoJogador(Convert.ToInt32(bt.Tag));

            Jogada jogadaCpu = RetornaJogadaDaCpu();

            Resultado resultado = RetornaGanhador(jogadaJogador, jogadaCpu);

            if(resultado == Resultado.VitoriaCpu)
            {
                LbPtCpu.Text = (int.Parse(LbPtCpu.Text) + 1).ToString();
            }
            else if(resultado == Resultado.VitoriaJogador)
            {
                LbPtJogador.Text = (int.Parse(LbPtJogador.Text) + 1).ToString();
            }
        }

        private Resultado RetornaGanhador(Jogada Jogador, Jogada Cpu)
        {
            if(Jogador == Jogada.Pedra)
            {
                if(Cpu == Jogada.Papel)
                {
                    return Resultado.VitoriaCpu;
                }
                else if(Cpu == Jogada.Tesoura)
                {
                    return Resultado.VitoriaJogador;
                }
            }
            else if(Jogador == Jogada.Papel)
            {
                if (Cpu == Jogada.Pedra)
                {
                    return Resultado.VitoriaJogador;
                }
                else if (Cpu == Jogada.Tesoura)
                {
                    return Resultado.VitoriaCpu;
                }
            }
            else
            {
                if (Cpu == Jogada.Pedra)
                {
                    return Resultado.VitoriaCpu;
                }
                else if (Cpu == Jogada.Papel)
                {
                    return Resultado.VitoriaJogador;
                }
            }

            return Resultado.Empate;
        }

        private Jogada RetornaJogadaDoJogador(int escolha)
        {
            return (Jogada)escolha;
        }

        private Jogada RetornaJogadaDaCpu()
        {
            Random rnd= new Random();
            int escolha = rnd.Next(3);
            PicCpu.Image = imgCpu[escolha];
            return(Jogada)escolha;
        }

        enum Jogada
        {
            Pedra = 0,
            Papel = 1,
            Tesoura = 2
        }

        enum Resultado
        {
            VitoriaJogador,
            VitoriaCpu,
            Empate
        }
    }
}