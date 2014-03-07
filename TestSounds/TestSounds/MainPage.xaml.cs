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
        Dictionary<char, char> conversionTable1;
        Dictionary<char, char> conversionTable2;
        public MainPage()
        {
            InitializeComponent();
            conversionTable1 = new Dictionary<char, char>();
            conversionTable2 = new Dictionary<char, char>();
            InitializeConversionTables();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void InitializeConversionTables()
        {
            conversionTable1.Add('a','\u0250');
            conversionTable1.Add('b','q');
            conversionTable1.Add('c','\u0254'); //open o -- from pne
            conversionTable1.Add('d','p');
            conversionTable1.Add('e','\u01DD');
            conversionTable1.Add('f','\u025F'); //from pne
            conversionTable1.Add('g','\u0183');
            conversionTable1.Add('h','\u0265');
            conversionTable1.Add('i','\u0131'); //from pne
            conversionTable1.Add('j','\u027E');
            conversionTable1.Add('k','\u029E');
            conversionTable1.Add('m','\u026F');
            conversionTable1.Add('n','u');
            conversionTable1.Add('r','\u0279');
            conversionTable1.Add('t','\u0287');
            conversionTable1.Add('v','\u028C');
            conversionTable1.Add('w','\u028D');
            conversionTable1.Add('y','\u028E');
            conversionTable1.Add('.','\u02D9');
            conversionTable1.Add('[',']');
            conversionTable1.Add('(',')');
            conversionTable1.Add('{','}');
            conversionTable1.Add('?','\u00BF');
            conversionTable1.Add('!','\u00A1');
            conversionTable1.Add('\'',',');
            conversionTable1.Add('<','>');
            conversionTable1.Add('_','\u203E');
            conversionTable1.Add(';','\u061B');
            conversionTable1.Add('\u203F','\u2040');
            conversionTable1.Add('\u2045','\u2046');
            conversionTable1.Add('\u2234','\u2235');
            conversionTable1.Add('\r', '\n');

            foreach (KeyValuePair<char, char> item in conversionTable1)
            {
                conversionTable2.Add(item.Value, item.Key);
            }

        }
        private void PlayAudioButton_Click_1(object sender, RoutedEventArgs e)
        {
            //mediaElement.Play();
            String input = InputText.Text;
            OutputText.Text = ChangeString(input);

            NotificationText.Text = "Copied";

          //  ShellToast toast = new ShellToast();
          //  toast.Title = "Inverted text";
          //  toast.Content = "ho gaya invert";
          //  toast.Show();
        }

        private String ChangeString(String inputString)
        {
            int last = inputString.Length - 1;
            char[] chars = inputString.ToCharArray();
            for (var i = last; i >= 0; --i) 
            {
                char c = inputString[i];
                chars[last - i] = conversionTable1.ContainsKey(c) ? conversionTable1[c] : (conversionTable2.ContainsKey(c) ? conversionTable2[c] : c);
            }

            String outputString = new String(chars);
            return outputString;
        }
        
    }
}