using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteRotateGui
{
    public partial class Form1 : Form
    {
        string[] characters = { "F", "U", "TH", "O", "R", "C(K)", "G", "W", "G", "N", "I", "J", "EO", "P", "X", "S(Z)", "T", "B", "E", "M", "L", "NG(ING)", "OE", "D", "A", "AE", "Y", "IA(IO)", "EA" };
        int[] primes = { 2, 3, 4, 5, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109 };
        string ui;
        string[] uch;
        int index;

        int rotate = 0;
        string output = "";
        string primeOut = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output = "";
            primeOut = "";
            ui = userText.Text;
            ui = ui.ToUpper();
            uch = Regex.Split(ui, @"\.|(\s)");

            foreach(string a in uch)
            {
                Console.WriteLine(a);
            }

            rotate = (int)rotations.Value;

            foreach(string x in uch) {
                index = Array.IndexOf(characters, x);

                if (x == "")
                {
                    break;
                }

                if (Regex.IsMatch(x, @"\s"))
                {
                    output += x;
                    primeOut += x;
                    continue;
                }

                if (index < 0)
                {
                    output = x + " is an invalid character, please try again.";
                    primeOut = "";
                    break;
                }

                if (index + rotate >= characters.Length) {
                    output += characters[index + (rotate - characters.Length)];
                    primeOut += primes[index + (rotate - characters.Length)];
                    primeOut += " ";
                }
                else
                {
                    output += characters[index + rotate];
                    primeOut += primes[index + rotate];
                    primeOut += " ";
                }
            }

            characterOutput.Text = output;
            primeOutput.Text = primeOut;
        }
    }
}
