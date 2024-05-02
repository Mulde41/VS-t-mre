using System.Windows;
using System.Windows.Controls;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.View
{
    /// <summary>
    /// Interaction logic for ProjectMakerView.xaml
    /// </summary>
    public partial class ProjectMakerView : UserControl
    {

        private MainViewModel mvm = new MainViewModel();

        public ProjectMakerView()
        {
            this.DataContext = mvm;
            this.Loaded += (s, e) => update();

            btnSaveProject.IsEnabled = false;

        }

        public void update()
        {
            // Check if controls are not null before accessing their properties
            if (txbTitle != null && (txbTitle.Text == "" || txbTitle.Text == "Titel"))
            {
                if (btnSaveProject != null)
                    btnSaveProject.IsEnabled = false;
            }
            if (txbAddress != null && (txbAddress.Text == "" || txbAddress.Text == "Adresse"))
            {
                if (btnSaveProject != null)
                    btnSaveProject.IsEnabled = false;
            }
            else if (txbOffer != null && (txbOffer.Text == "" || txbOffer.Text == "Tilbud"))
            {
                if (btnSaveProject != null)
                    btnSaveProject.IsEnabled = false;
            }
            else
            {
                if (btnSaveProject != null)
                    btnSaveProject.IsEnabled = true;
            }
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



        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void txbDescription_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = "Projektbeskrivelse"; // Clear the placeholder text
                textBox.TextAlignment = TextAlignment.Center; // Change text alignment to left
            }
        }

        private void btnSaveProject_Click(object sender, RoutedEventArgs e)
        {
            double offer = double.Parse(txbOffer.Text);
            mvm.CreateProject(txbTitle.Text, offer, txbAddress.Text, txbDescription.Text);

            txbTitle.Text = "Titel"; // Clear the placeholder text
            txbTitle.TextAlignment = TextAlignment.Center; // Change text alignment to left

            txbAddress.Text = "Adresse"; // Clear the placeholder text
            txbAddress.TextAlignment = TextAlignment.Center; // Change text alignment to left

            txbOffer.Text = "Tilbud"; // Clear the placeholder text
            txbOffer.TextAlignment = TextAlignment.Center; // Change text alignment to left

            txbDescription.Text = "Projektbeskrivelse"; // Clear the placeholder text
            txbDescription.TextAlignment = TextAlignment.Center; // Change text alignment to lef

            Thread workThread = new Thread(CreationConfirmation);
            workThread.Start();

        }

        public void CreationConfirmation()
        {
            //Change the label content and start the timer
            lblCreateProject.Dispatcher.Invoke(new Action(() => { lblCreateProject.Content = "Projektet er gemt!"; }));
            Thread.Sleep(3000);
            // Change the label back to the original content and stop the timer
            lblCreateProject.Dispatcher.Invoke(new Action(() => { lblCreateProject.Content = ""; }));
        }

        private void txbAddress_TextChanged(object sender, TextChangedEventArgs e)
        {
            update();
        }

        private void txbTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            update();
        }



        private void txbOffer_TextChanged(object sender, TextChangedEventArgs e)
        {
            update();
        }

        private void txbDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            update();
        }
    }
}

