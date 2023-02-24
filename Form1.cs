using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Variables
        private bool player1_turn = true;
        private int[,] boardValue = new int[3, 3];
        const int X_VALUE = 1;
        const int O_VALUE = 2;

        public Form1()
        {
            InitializeComponent();
            restart_matrix();
            player1_turn = true;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 0] = O_VALUE;
            }

            check_win();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 1] = O_VALUE;
            }
            check_win();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 2] = O_VALUE;
            }
            check_win();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 0] = O_VALUE;
            }
            check_win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 1] = O_VALUE;
            }
            check_win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 2] = O_VALUE;
            }
            check_win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 0] = O_VALUE;
            }
            check_win();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 1] = O_VALUE;
            }
            check_win();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 2] = O_VALUE;
            }
            check_win();
        }
       
        private void check_win()
        {
            
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardValue[i, 0]) == Convert.ToInt32(boardValue[i, 1]) &&
                    Convert.ToInt32(boardValue[i, 1]) == Convert.ToInt32(boardValue[i, 2]) &&
                    Convert.ToInt32(boardValue[i, 1]) != 0)
                {
                    color_winning_buttons(find_button_by_value(i, 0),
                        find_button_by_value(i, 1),
                        find_button_by_value(i, 2));
                    display_win_screen(boardValue[i, 0]);

                    return;
                }
            }

            
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardValue[0, i]) == Convert.ToInt32(boardValue[1, i]) &&
                    Convert.ToInt32(boardValue[1, i]) == Convert.ToInt32(boardValue[2, i]) &&
                    Convert.ToInt32(boardValue[2, i]) != 0)
                {
                    color_winning_buttons(find_button_by_value(0, i),
                        find_button_by_value(1, i),
                        find_button_by_value(2, i));
                    display_win_screen(boardValue[1, i]);
                    return;
                }
            }

            
            if (Convert.ToInt32(boardValue[0, 0]) == Convert.ToInt32(boardValue[1, 1]) &&
                Convert.ToInt32(boardValue[1, 1]) == Convert.ToInt32(boardValue[2, 2]) &&
                Convert.ToInt32(boardValue[2, 2]) != 0)
            {
                color_winning_buttons(find_button_by_value(0, 0),
                    find_button_by_value(1, 1),
                    find_button_by_value(2, 2));
                display_win_screen(boardValue[1, 1]);
                return;
            }
            else if (Convert.ToInt32(boardValue[0, 2]) == Convert.ToInt32(boardValue[1, 1]) &&
              Convert.ToInt32(boardValue[1, 1]) == Convert.ToInt32(boardValue[2, 0]) &&
              Convert.ToInt32(boardValue[2, 0]) != 0)
            {
                color_winning_buttons(find_button_by_value(0, 2),
                    find_button_by_value(1, 1),
                    find_button_by_value(2, 0));
                display_win_screen(boardValue[1, 1]);
                return;
            }

            
            bool is_completed = true;
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; j++)
                    if (boardValue[i, j] == 0)
                        is_completed = false;
            if (is_completed)
            {
                MessageBox.Show("Draw");
                restart_matrix();
            }
        }

        // Display win message
        private void display_win_screen(int val)
        {
            if (val == X_VALUE)
            {
                MessageBox.Show("Player 1 wins!");
                int player1_score = Convert.ToInt32(label6.Text);
                ++player1_score;
                label6.Text = player1_score.ToString();
            }
            else
            {
                MessageBox.Show("Player 2 wins!");
                int player2_score = Convert.ToInt32(label7.Text);
                ++player2_score;
                label7.Text = player2_score.ToString();
            }

            restart_matrix();
        }

        private void restart_matrix()
        {
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    boardValue[i, j] = 0;

            clear_buttons();
            player1_turn = true;
        }

        
        private void color_winning_buttons(Button button1, Button button2, Button button3)
        {
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.Blue;
        }

        // Clear buttons
        private void clear_buttons()
        {
            // Content
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.Blue;
            button5.BackColor = Color.Blue;
            button6.BackColor = Color.Blue;
            button7.BackColor = Color.Blue;
            button8.BackColor = Color.Blue;
            button9.BackColor = Color.Blue;

            
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;
        }

        
        private Button find_button_by_value(int value_x, int value_y)
        {
            switch (value_x)
            {
                case 0:
                    if (value_y == 0)
                        return button1;
                    if (value_y == 1)
                        return button2;
                    if (value_y == 2)
                        return button3;
                    return button1;
                    break;
                case 1:
                    if (value_y == 0)
                        return button6;
                    if (value_y == 1)
                        return button5;
                    if (value_y == 2)
                        return button4;
                    return button1;
                    break;
                case 2:
                    if (value_y == 0)
                        return button9;
                    if (value_y == 1)
                        return button8;
                    if (value_y == 2)
                        return button7;
                    return button1;
                    break;

                default:
                    restart_matrix();
                    MessageBox.Show("Something failed!");
                    return button1;
            }
        }

        // Select active player
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
            }
            else
            {
                label2.ForeColor = Color.Green;
                label1.ForeColor = Color.Black;
            }
        }

        // Reset game
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
