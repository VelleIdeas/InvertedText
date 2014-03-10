using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TestSounds.Resources;

namespace TestSounds
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        Converter stringConverter;
        public MainPage()
        {
            InitializeComponent();
            stringConverter = new Converter();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        
        private void PlayAudioButton_Click_1(object sender, RoutedEventArgs e)
        {
            //mediaElement.Play();
            String input = InputText.Text;
            OutputText.Text = Converter.InvertString(input);
            Clipboard.SetText(OutputText.Text); // Copy the string to clipboard
            NotificationText.Text = "Copied";

        }
        
    }
}