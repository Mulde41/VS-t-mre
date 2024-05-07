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
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            TitleUpdater();
            OfferUpdater();
            AddressUpdater();
            btnSaveProjectUpdater();
        }

        public bool TitleUpdater()
        {
            // Check if controls are not null before accessing their properties
            if (txbTitle != null && lblTitle != null)
            {
                if (txbTitle.Text == "Titel")
                {
                    lblTitle.Content = "";
                    return false;
                }
                //Handles if title only contains spaces
                if (txbTitle.Text.Trim().Length == 0)
                {
                    lblTitle.Content = "Feltet skal udfyldes!";
                    return false;
                }
                //Handles if title contains other than spaces
                else if (txbTitle.Text.Trim().Length != 0/* && txbTitle.Text != "Titel"*/)
                {
                    lblTitle.Content = "";
                    return true;
                }
            }
            return false;
        }
        public bool OfferUpdater()
        {
            // Check if controls are not null before accessing their properties
            if (txbOffer != null && lblOffer != null)
            {
                if (txbOffer.Text == "Tilbud")
                {
                    lblOffer.Content = "";
                    return false;
                }
                else if (txbOffer.Text.Trim().Length == 0)
                {
                    lblOffer.Content = "Feltet skal udfyldes!";
                    return false;
                }
                else if (!double.TryParse(txbOffer.Text, out double result))
                {
                    lblOffer.Content = "Må KUN indeholde tal!";
                    return false;
                }
                else
                {
                    lblOffer.Content = "";
                    return true;
                }
            }
            return false;
        }
        public bool AddressUpdater()
        {
            // Check if controls are not null before accessing their properties
            if (txbAddress != null && lblAddress != null)
            {
                if (txbAddress.Text == "Adresse")
                {
                    lblAddress.Content = "";
                    return false;
                }
                //Handles if title only contains spaces
                if (txbAddress.Text.Trim().Length == 0)
                {
                    lblAddress.Content = "Feltet skal udfyldes!";
                    return false;
                }
                //Handles if title contains other than spaces
                else if (txbAddress.Text.Trim().Length != 0)
                {
                    lblAddress.Content = "";
                    return true;
                }
            }
            return false;
        }

        public void btnSaveProjectUpdater()
        {
            if (btnSaveProject != null)
            {
                if (TitleUpdater() == true && OfferUpdater() == true && AddressUpdater() == true)
                {
                    btnSaveProject.IsEnabled = true;
                }
                else
                {
                    btnSaveProject.IsEnabled = false;
                }
            }
        }
        public void CreationConfirmation()
        {
            //Change the label content and start the timer
            lblCreateProject.Dispatcher.Invoke(new Action(() => { lblCreateProject.Content = "Projektet er gemt!"; }));
            Thread.Sleep(3000);
            // Change the label back to the original content and stop the timer
            lblCreateProject.Dispatcher.Invoke(new Action(() => { lblCreateProject.Content = ""; }));
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
                textBox.Text = "Projektbeskrivelse"; // Clear the placeholder text
                textBox.TextAlignment = TextAlignment.Center; // Change text alignment to left
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void btnSaveProject_Click(object sender, RoutedEventArgs e)
        {
            mvm.CreateProject(txbTitle.Text, txbOffer.Text, txbAddress.Text, txbDescription.Text);

            txbTitle.Text = "Titel"; // Clear the placeholder text
            txbTitle.TextAlignment = TextAlignment.Center; // Change text alignment to left

            txbAddress.Text = "Adresse"; // Clear the placeholder text
            txbAddress.TextAlignment = TextAlignment.Center; // Change text alignment to left

            txbOffer.Text = "Tilbud"; // Clear the placeholder text
            txbOffer.TextAlignment = TextAlignment.Center; // Change text alignment to left

            txbDescription.Text = "Projektbeskrivelse"; // Clear the placeholder text
            txbDescription.TextAlignment = TextAlignment.Center; // Change text alignment to left

            Thread workThread = new Thread(CreationConfirmation);
            workThread.Start();
        }

        private void txbTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void txbOffer_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
        private void txbAddress_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void txbDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
    }
}

