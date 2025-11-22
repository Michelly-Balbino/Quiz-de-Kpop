namespace Quizeitaeita
{
    public partial class Form1 : Form
    {
        //quiz variavel

        int QuestaoCorreta;
        int PerguntaNumero = 1;
        int Pontuacao;
        int TotalPerguntas;
        int porcentagem;
        int TotalPontos;

        public Form1()
        {
            InitializeComponent();

            askQuestion(PerguntaNumero);

            TotalPerguntas = 10;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == QuestaoCorreta)
            {
                Pontuacao++;

            }

            if (PerguntaNumero == TotalPerguntas)
            {
                porcentagem = (int)Math.Round((double)(Pontuacao * 100) / TotalPerguntas);

                MessageBox.Show(
                    "Quiz finalizado!" + Environment.NewLine +
                    "Você acertou " + Pontuacao + " de " + TotalPerguntas + " perguntas." + Environment.NewLine +
                    "Sua pontuação é " + porcentagem + "%" + Environment.NewLine + "Obrigado por jogar!"
                    );

                Pontuacao = 0;
                PerguntaNumero = 1;
                QuestaoCorreta = 0;
                askQuestion(PerguntaNumero);
                return;
            }

            PerguntaNumero++;
            askQuestion(PerguntaNumero);

        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureGrupo.Image = Properties.Resources.XLOV;

                    lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";

                    btnOpcao1.Text = "XLOV";
                    btnOpcao2.Text = "TXT";
                    btnOpcao3.Text = "XG";
                    btnOpcao4.Text = "WINNER";

                    QuestaoCorreta = 1;

                    break;

                    case 2:
                    pictureGrupo.Image = Properties.Resources.TXT;

                    lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";

                    btnOpcao1.Text = "XLOV";
                    btnOpcao2.Text = "TXT";
                    btnOpcao3.Text = "XG";
                    btnOpcao4.Text = "WINNER";

                    QuestaoCorreta = 2;

                    break;

                    case 3:
                    pictureGrupo.Image = Properties.Resources.ILLIT;
                    
                    lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?"; 

                    btnOpcao1.Text = "ITZY";
                    btnOpcao2.Text = "ILLIT";
                    btnOpcao3.Text = "BLACKPINK";
                    btnOpcao4.Text = "aespa";

                    QuestaoCorreta = 2;

                    break;

                    case 4:
                    pictureGrupo.Image = Properties.Resources.TWICE;
                    lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";
                    btnOpcao1.Text = "MAMAMOO";
                    btnOpcao2.Text = "RED VELVET";
                    btnOpcao3.Text = "TWICE";
                    btnOpcao4.Text = "GFRIEND";

                    QuestaoCorreta = 3; 
                    break;

                    case 5:
                    pictureGrupo.Image = Properties.Resources.LE_SSERAFIM;
                    lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";
                    btnOpcao1.Text = "LE SSERAFIM";
                    btnOpcao2.Text = "NEW JEANS";
                    btnOpcao3.Text = "ITZY";
                    btnOpcao4.Text = "aespa";

                    QuestaoCorreta = 1;
                    break;

                    case 6:
                    pictureGrupo.Image = Properties.Resources.STRAY_KIDS;
                    lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";
                    btnOpcao1.Text = "GOT7";
                    btnOpcao2.Text = "ATEEZ";
                    btnOpcao3.Text = "STRAY KIDS";
                    btnOpcao4.Text = "ENHYPEN";

                    QuestaoCorreta = 3;
                    break;

                    case 7:
                    pictureGrupo.Image = Properties.Resources.RED_VELVET;
                    lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";
                    btnOpcao1.Text = "MAMAMOO";
                    btnOpcao2.Text = "RED VELVET";
                    btnOpcao3.Text = "TWICE";
                    btnOpcao4.Text = "GFRIEND";

                    QuestaoCorreta = 2;
                    break;

                    case 8:
                    pictureGrupo.Image = Properties.Resources.BTS;
                    lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";
                    btnOpcao1.Text = "SEVENTEEN";
                    btnOpcao2.Text = "BTS";
                    btnOpcao3.Text = "MONSTA X";
                    btnOpcao4.Text = "NCT";

                    QuestaoCorreta = 2;
                    break;

                    case 9:
                    pictureGrupo.Image = Properties.Resources.NEW_JEANS;
                    lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";
                    btnOpcao1.Text = "LE SSERAFIM";
                    btnOpcao2.Text = "NEW JEANS";
                    btnOpcao3.Text = "ITZY";
                    btnOpcao4.Text = "aespa";

                    QuestaoCorreta = 2;
                    break;

                    case 10:
                    pictureGrupo.Image = Properties.Resources._2NE1;
                    lblpergunta.Text = "Qual desse grupo de k-pop pertence esses integrantes?";
                    btnOpcao1.Text = "BLACKPINK";
                    btnOpcao2.Text = "2NE1";
                    btnOpcao3.Text = "SNSD";
                    btnOpcao4.Text = "T-ARA";

                    QuestaoCorreta = 2;
                    break;
            }

        }
    }
}

