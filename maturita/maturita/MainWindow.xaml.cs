﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace maturita
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private int Player = 1; // Hráč
        private int player1Score = 0; // Score pro hráče 1
        private int player2Score = 0; // Score pro hráče 2

        public MainWindow()
        {
            InitializeComponent();
            Update(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender; 

            if (button.Content == null)
            {
                if (Player == 1)
                {
                    button.Content = "X";
                }
                else
                {
                    button.Content = "O";
                }

                if (Player == 1)
                {
                    Player = 2;
                }
                else
                {
                    Player = 1;
                }

                CheckWin(); 
                Update(); 
            }
        }

        private void CheckWin()
        {
            int[,] win = new int[,]
            {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Řádek
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Sloupec
            { 0, 4, 8 }, { 2, 4, 6 } // Šikmě
            };

            foreach (int i in Enumerable.Range(0, win.GetLength(0)))
            {
                int a = win[i, 0];
                int b = win[i, 1];
                int c = win[i, 2];

                Button btn1 = (Button)MyGrid.Children[a];
                Button btn2 = (Button)MyGrid.Children[b];
                Button btn3 = (Button)MyGrid.Children[c];

                string content1 = btn1.Content as string;
                string content2 = btn2.Content as string;
                string content3 = btn3.Content as string;

                if (!string.IsNullOrEmpty(content1) && content1 == content2 && content2 == content3)
                {
                    string winner;
                    if (Player == 1)
                    {
                        winner = "O";
                    }
                    else
                    {
                        winner = "X";
                    }

                    MessageBox.Show("Hráč " + winner + " vyhrává!");
                    UpdateScore(winner); 
                    Reset();
                    return;
                }
            }

            if (Full())
            {
                MessageBox.Show("Remíza!");
                Reset(); 
            }
        }

        private bool Full()
        {
            foreach (Button button in MyGrid.Children.OfType<Button>())
            {
                if (string.IsNullOrEmpty(button.Content as string))
                {
                    return false;
                }
            }

            return true;
        }

        private void Reset()
        {
            foreach (Button button in MyGrid.Children.OfType<Button>())
            {
                button.Content = null;
            }

            Player = (player1Score + player2Score) % 2 + 1;

            Update(); 
        }

        private void UpdateScore(string winner)
        {
            if (winner == "X")
            {
                player1Score++;
            }
            else if (winner == "O")
            {
                player2Score++;
            }

            Player1ScoreLabel.Content = player1Score.ToString();
            Player2ScoreLabel.Content = player2Score.ToString();
        }

        private void Update()
        {

            string PlayerSymbol;
            if (Player == 1)
            {
                PlayerSymbol = "X";
            }
            else
            {
                PlayerSymbol = "O";
            }

            PlayerLabel.Content = "Hraje hráč: " + PlayerSymbol;

        }
    }


}