using System;
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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        GameLogic _GameLogic = new GameLogic();

        private void PlayerClicksCell(object sender, RoutedEventArgs e)
        {
            var cell = (Button)sender;

            //Checks if current cell is already occupied by an X or O or if it is the new game button
            if (!String.IsNullOrWhiteSpace(cell.Content?.ToString()))
                return;
            //Checks if the game has already been won to prevent placement of more X's or O's
            if (_GameLogic.GameDone)
                return;

            //Sets the cell that is clicked to be an X or O depending on the current player
            cell.Content = _GameLogic.CurrentPlayer;


            //Updates the Board variable held in GameLogic
            //by getting the tag of the current button being pressed and assigning the
            //tag value to coordinate values
            //then passing the coordinate values into the UpdateBoard() function
            var coordinates = cell.Tag.ToString().Split(',');
            var xValue = int.Parse(coordinates[0]);
            var yValue = int.Parse(coordinates[1]);

            var ButtonPosition = new Position() { x = xValue, y = yValue };
            _GameLogic.UpdateBoard(ButtonPosition, _GameLogic.CurrentPlayer);



            //If a player has won pop up a textbox that displays the winner
            if (_GameLogic.PlayerWin())
            {
                winScreen.Text = $"{_GameLogic.CurrentPlayer} wins!!!";
                winScreen.Visibility = Visibility.Visible;
            }

            //Switches turns
            _GameLogic.SetNextPlayer();    
        }




        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            //For every child in the grid called gridBoard,
            //if the child being checked is a button, then make it empty
            foreach(var control in gridBoard.Children)
            {
                if(control is Button)
                {
                    ((Button)control).Content = String.Empty;
                }
            }

            //Updates game logic
            _GameLogic = new GameLogic();

            //Removes player win textbox
            winScreen.Visibility = Visibility.Collapsed;
        }
    }
}
