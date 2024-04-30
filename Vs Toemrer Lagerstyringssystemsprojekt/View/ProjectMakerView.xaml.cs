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

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.View
{
    /// <summary>
    /// Interaction logic for ProjectMakerView.xaml
    /// </summary>
    public partial class ProjectMakerView : UserControl
    {
        public ProjectMakerView()
        {
            InitializeComponent();
        }


        private void txbTitle_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Titel")
            {
                textBox.Text = ""; // Clear the placeholder text
                textBox.TextAlignment = TextAlignment.Left; // Change text alignment to left
            }
        }

        private void txbOffer_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Tilbud")
            {
                textBox.Text = ""; // Clear the placeholder text
                textBox.TextAlignment = TextAlignment.Left; // Change text alignment to left
            }
        }

        private void txbAddress_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Adresse")
            {
                textBox.Text = ""; // Clear the placeholder text
                textBox.TextAlignment = TextAlignment.Left; // Change text alignment to left
            }
        }

        private void txbDescription_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Projektbeskrivelse")
            {
                textBox.Text = ""; // Clear the placeholder text
                textBox.TextAlignment = TextAlignment.Left; // Change text alignment to left
            }
        }

        private void txbTitle_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = "Titel"; // Clear the placeholder text
                textBox.TextAlignment = TextAlignment.Center; // Change text alignment to left
            }
        }

        private void txbOffer_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = "Tilbud"; // Clear the placeholder text
                textBox.TextAlignment = TextAlignment.Center; // Change text alignment to left
            }
        }

        private void txbAddress_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = "Adresse"; // Clear the placeholder text
                textBox.TextAlignment = TextAlignment.Center; // Change text alignment to left
            }
        }

        private void txbDescription_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = "Projectbeskrivelse"; // Clear the placeholder text
                textBox.TextAlignment = TextAlignment.Center; // Change text alignment to left
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
