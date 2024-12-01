using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string colour1;
        string colour2;
        string colour3;
        string colour4;
        int attemptCounter = 1;
        int secondsCounter = 0;
        private DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            GenerateColours(out colour1, out colour2, out colour3, out colour4);
            solutionTextBox.Text += $"{colour1}, {colour2}, {colour3}, {colour4}";
            timer.Tick += Countdown; //Event koppelen
            timer.Interval = new TimeSpan(0, 0, 1); //Elke seconde
            timer.Start(); //Timer starten
        }

        //METHODS
        private void GenerateColours(out string colourSlot1, out string colourSlot2, out string colourSlot3, out string colourSlot4)
        {
            Random rng = new Random();
            List<string> colourList = new List<string>();
            int rngNumber;
            string rngString = "";
            
            for (int i=0; i<4; i++)
            {
                rngNumber = rng.Next(1, 7);
                switch (rngNumber)
                {
                    case 1:
                        rngString = "Red";
                        break;
                    case 2:
                        rngString = "Yellow";
                        break;
                    case 3:
                        rngString = "Orange";
                        break;
                    case 4:
                        rngString = "White";
                        break;
                    case 5:
                        rngString = "Green";
                        break;
                    case 6:
                        rngString = "Blue";
                        break;
                }
                colourList.Add(rngString);
            }
            colourSlot1 = colourList[0];
            colourSlot2 = colourList[1];
            colourSlot3 = colourList[2];
            colourSlot4 = colourList[3];
        }
        private void GenerateBackgrounds(Label label1, Label label2, Label label3, Label label4, out List<string> stringList)
        {
            List<string> colourList = new List<string>();
            colourList.Add(label1.Background.ToString());
            colourList.Add(label2.Background.ToString());
            colourList.Add(label3.Background.ToString());
            colourList.Add(label4.Background.ToString());
            stringList = new List<string>();
            for(int i=0; i<4; i++)
            {
                switch (colourList[i])
                {
                    case "#FFFF0000":
                        stringList.Add("Red");
                        break;
                    case "#FFFFFF00":
                        stringList.Add("Yellow");
                        break;
                    case "#FFFFA500":
                        stringList.Add("Orange");
                        break;
                    case "#FFFFFFFF":
                        stringList.Add("White");
                        break;
                    case "#FF008000":
                        stringList.Add("Green");
                        break;
                    case "#FF0000FF":
                        stringList.Add("Blue");
                        break;
                    default:
                        stringList.Add("Invalid");
                        break;
                }
            }
        }
        
        private void Countdown(object sender, EventArgs e)
        {
            secondsCounter++;
            if (secondsCounter % 10 == 0)
            {
                secondsCounter = 0;
                attemptCounter++;
                attemptLabel.Content = $"Attempt: {attemptCounter}";
            }
            timeLabel.Content = $"Seconds: {secondsCounter}";
        }

        //EVENT METHODS
        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        colour1Label.Background = Brushes.Red;
                        break;
                    case 1:
                        colour1Label.Background = Brushes.Yellow;
                        break;
                    case 2:
                        colour1Label.Background = Brushes.Orange;
                        break;
                    case 3:
                        colour1Label.Background = Brushes.White;
                        break;
                    case 4:
                        colour1Label.Background = Brushes.Green;
                        break;
                    case 5:
                        colour1Label.Background = Brushes.Blue;
                        break;
                }
            }
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        colour2Label.Background = Brushes.Red;
                        break;
                    case 1:
                        colour2Label.Background = Brushes.Yellow;
                        break;
                    case 2:
                        colour2Label.Background = Brushes.Orange;
                        break;
                    case 3:
                        colour2Label.Background = Brushes.White;
                        break;
                    case 4:
                        colour2Label.Background = Brushes.Green;
                        break;
                    case 5:
                        colour2Label.Background = Brushes.Blue;
                        break;
                }
            }
        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                switch (comboBox3.SelectedIndex)
                {
                    case 0:
                        colour3Label.Background = Brushes.Red;
                        break;
                    case 1:
                        colour3Label.Background = Brushes.Yellow;
                        break;
                    case 2:
                        colour3Label.Background = Brushes.Orange;
                        break;
                    case 3:
                        colour3Label.Background = Brushes.White;
                        break;
                    case 4:
                        colour3Label.Background = Brushes.Green;
                        break;
                    case 5:
                        colour3Label.Background = Brushes.Blue;
                        break;
                }
            }
        }

        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                switch (comboBox4.SelectedIndex)
                {
                    case 0:
                        colour4Label.Background = Brushes.Red;
                        break;
                    case 1:
                        colour4Label.Background = Brushes.Yellow;
                        break;
                    case 2:
                        colour4Label.Background = Brushes.Orange;
                        break;
                    case 3:
                        colour4Label.Background = Brushes.White;
                        break;
                    case 4:
                        colour4Label.Background = Brushes.Green;
                        break;
                    case 5:
                        colour4Label.Background = Brushes.Blue;
                        break;
                }
            }
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            attemptCounter += 1;
            attemptLabel.Content = $"Attempt: {attemptCounter}";
            secondsCounter = 0;
            List<string> colourList = new List<string>();
            colourList.Add(colour1);
            colourList.Add(colour2);
            colourList.Add(colour3);
            colourList.Add(colour4);
            List<string> backgroundList = new List<string>();
            GenerateBackgrounds(colour1Label, colour2Label, colour3Label, colour4Label, out backgroundList);
            if (backgroundList.Contains("Invalid"))
            {
                MessageBox.Show("At least one of the combo boxes is empty, try again.");
                return;
            }
            List<string> borderList = new List<string>();
            for (int i=0; i<4; i++)
            {
                if (backgroundList[i] == colourList[i])
                {
                    borderList.Add("DarkRed");
                }
                else if (colourList.Contains(backgroundList[i]))
                {
                    borderList.Add("Wheat");
                }
                else borderList.Add("None");
            }
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        if (borderList[i] == "DarkRed")
                        {
                            colour1Label.BorderBrush = Brushes.DarkRed;
                        }
                        else if (borderList[i] == "Wheat")
                        {
                            colour1Label.BorderBrush = Brushes.Wheat;
                        }
                        else colour1Label.BorderBrush = Brushes.Transparent;
                        break;
                    case 1:
                        if (borderList[i] == "DarkRed")
                        {
                            colour2Label.BorderBrush = Brushes.DarkRed;
                        }
                        else if (borderList[i] == "Wheat")
                        {
                            colour2Label.BorderBrush = Brushes.Wheat;
                        }
                        else colour2Label.BorderBrush = Brushes.Transparent;
                        break;
                    case 2:
                        if (borderList[i] == "DarkRed")
                        {
                            colour3Label.BorderBrush = Brushes.DarkRed;
                        }
                        else if (borderList[i] == "Wheat")
                        {
                            colour3Label.BorderBrush = Brushes.Wheat;
                        }
                        else colour3Label.BorderBrush = Brushes.Transparent;
                        break;
                    case 3:
                        if (borderList[i] == "DarkRed")
                        {
                            colour4Label.BorderBrush = Brushes.DarkRed;
                        }
                        else if (borderList[i] == "Wheat")
                        {
                            colour4Label.BorderBrush = Brushes.Wheat;
                        }
                        else colour4Label.BorderBrush = Brushes.Transparent;
                        break;
                }
            }
        }
        private void ToggleDebug(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control)
            {
                if (e.Key == Key.F12)
                {
                    if (solutionTextBox.Visibility == Visibility.Hidden)
                    {
                        solutionTextBox.Visibility = Visibility.Visible;
                    }
                    else solutionTextBox.Visibility = Visibility.Hidden;
                }
            }
        }
    }
}