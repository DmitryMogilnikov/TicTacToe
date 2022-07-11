namespace TicTacToe_NewVersion_
{
    public partial class Form1 : Form
    {
        Boolean turn = true;
        int turn—ount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Dmitry Mogilnikov", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x_wins_count.Text = "0";
            o_wins_count.Text = "0";
            draw_count.Text = "0";
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn—ount = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn—ount++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            // horisontal check
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            // vertical check
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            // diagonal check
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                DisableButtons();
                String winner = "";
                if (turn)
                {
                    winner = "O";
                    o_wins_count.Text = Convert.ToString(int.Parse(o_wins_count.Text) + 1);
                }
                else
                {
                    winner = "X";
                    x_wins_count.Text = Convert.ToString(int.Parse(x_wins_count.Text) + 1);
                }

                MessageBox.Show(winner + " Wins!", "Goal!");
            }
            else
            {
                if (turn—ount == 9)
                {
                    MessageBox.Show("Draw!", "Bummer");
                    draw_count.Text = Convert.ToString(int.Parse(draw_count.Text) + 1);
                }
            }
        }

        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }
    }
}