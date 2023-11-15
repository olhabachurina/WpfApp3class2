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

namespace WpfApp3class2
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
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
           
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null)
            {
                
                string colorName = radioButton.Content.ToString();
                Color selectedColor = Colors.Black; 

                switch (colorName)
                {
                    case "Красный":
                        selectedColor = Colors.Red;
                        break;
                    case "Синий":
                        selectedColor = Colors.Blue;
                        break;
                    case "зеленый":
                        selectedColor = Colors.Green;
                        break;
                       
                }

                SelectedColorText.Text = $"цвет текста выбран: {colorName}";
                SelectedColorText.Foreground = new SolidColorBrush(selectedColor);
            }
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Ok!");
        }
    }
}
    

