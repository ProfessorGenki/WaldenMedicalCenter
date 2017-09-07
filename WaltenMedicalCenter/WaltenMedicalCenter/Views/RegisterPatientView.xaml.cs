using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WaltenMedicalCenter.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterPatientView : Page
    {
        private bool isVisible;

        public RegisterPatientView()
        {
            this.InitializeComponent();
        }

        private void ToggleSwitch_OnToggled(object sender, RoutedEventArgs e)
        {
            if (!isVisible)
            {
                isVisible = true;
                CreditTextBlock.Visibility = Visibility.Collapsed;
                CreditTextBox.Visibility = Visibility.Collapsed;
                ProviderTextBlock.Visibility = Visibility.Visible;
                ProviderTextBox.Visibility = Visibility.Visible;
                CoverageTextBlock.Visibility = Visibility.Visible;
                CoverageTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                isVisible = false;
                CreditTextBlock.Visibility = Visibility.Visible;
                CreditTextBox.Visibility = Visibility.Visible;
                ProviderTextBlock.Visibility = Visibility.Collapsed;
                ProviderTextBox.Visibility = Visibility.Collapsed;
                CoverageTextBlock.Visibility = Visibility.Collapsed;
                CoverageTextBox.Visibility = Visibility.Collapsed;
            }
        }
    }
}
