using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GeocachingHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ROT13EncryptPage : ContentPage
    {
        public ROT13EncryptPage()
        {
            InitializeComponent();
        }

        private void EncryptClickButton_Clicked(object sender, EventArgs e)
        {
            int lenofinput = 0;
            int a = 0;
            string outputstring = string.Empty;
            string workingletter = string.Empty;

            lenofinput = encryptmessage.Text.Length;

            for (a = 1; a <= lenofinput; a++)
            {
                workingletter = encryptmessage.Text.Substring((a - 1), 1).ToUpper();

                switch (workingletter)
                {
                    case "A":
                        outputstring += "N";
                        break;
                    case "B":
                        outputstring += "O";
                        break;
                    case "C":
                        outputstring += "P";
                        break;
                    case "D":
                        outputstring += "Q";
                        break;
                    case "E":
                        outputstring += "R";
                        break;
                    case "F":
                        outputstring += "S";
                        break;
                    case "G":
                        outputstring += "T";
                        break;
                    case "H":
                        outputstring += "U";
                        break;
                    case "I":
                        outputstring += "V";
                        break;
                    case "J":
                        outputstring += "W";
                        break;
                    case "K":
                        outputstring += "X";
                        break;
                    case "L":
                        outputstring += "Y";
                        break;
                    case "M":
                        outputstring += "Z";
                        break;
                    case "N":
                        outputstring += "A";
                        break;
                    case "O":
                        outputstring += "B";
                        break;
                    case "P":
                        outputstring += "C";
                        break;
                    case "Q":
                        outputstring += "D";
                        break;
                    case "R":
                        outputstring += "E";
                        break;
                    case "S":
                        outputstring += "F";
                        break;
                    case "T":
                        outputstring += "G";
                        break;
                    case "U":
                        outputstring += "H";
                        break;
                    case "V":
                        outputstring += "I";
                        break;
                    case "W":
                        outputstring += "J";
                        break;
                    case "X":
                        outputstring += "K";
                        break;
                    case "Y":
                        outputstring += "L";
                        break;
                    case "Z":
                        outputstring += "M";
                        break;
                }
            }
            outputmessage.Text = outputstring.Trim();
        }
    }
}