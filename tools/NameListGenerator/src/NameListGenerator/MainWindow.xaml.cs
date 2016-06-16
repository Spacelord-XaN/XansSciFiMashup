using NameListGenerator.Paradox;
using Pdoxcl2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;

namespace NameListGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<char> invalidCharacters;
        private readonly DispatcherTimer timer;
        private readonly List<string> names;
        private string lastContent;

        public MainWindow()
        {
            InitializeComponent();








            this.names = new List<string>();
            this.lastContent = Clipboard.GetText();
            this.invalidCharacters = new List<char>();
            this.invalidCharacters.Add('(');
            this.invalidCharacters.Add(')');
            this.invalidCharacters.Add('0');
            this.invalidCharacters.Add('1');
            this.invalidCharacters.Add('2');
            this.invalidCharacters.Add('3');
            this.invalidCharacters.Add('4');
            this.invalidCharacters.Add('5');
            this.invalidCharacters.Add('6');
            this.invalidCharacters.Add('7');
            this.invalidCharacters.Add('8');
            this.invalidCharacters.Add('9');

            this.timer = new DispatcherTimer();
            this.timer.Interval = TimeSpan.FromMilliseconds(300);
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string content = Clipboard.GetText();
            if (content != this.lastContent)
            {
                this.lastContent = content;
                this.AddText(content);
            }
        }

        private void AddText(string Text)
        {
            string[] lineTokens = Text.Split('\n', '\r');
            StringBuilder sb = new StringBuilder();
            foreach (string line in lineTokens)
            {
                string name = line;
                int first = name.IndexOf('(');
                first--;
                if (first >= 0)
                {
                    name = name.Substring(0, first);
                }
                name = name.Replace("\"", "");
                name = name.Replace("\t", "");
                if (this.names.Contains(name))
                {
                    continue;
                }
                this.names.Add(name);
                sb.Append(name);
                sb.Append(" ");
            }

            this.textBloxNames.Text += sb.ToString();
        }

        private void Button_Click(object Sender, RoutedEventArgs E)
        {
            this.names.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (string name in names)
            {
                if (name.Contains(' '))
                {
                    sb.AppendFormat("\"{0}\"", name);
                }
                else
                {
                    sb.Append(name);
                }
                sb.Append(' ');
            }

            Clipboard.SetText(sb.ToString(), TextDataFormat.Text);
        }

        private void ButtonResetClick(object Sender, RoutedEventArgs E)
        {
            this.timer.Stop();
            Clipboard.Clear();
            this.lastContent = null;
            this.names.Clear();
            this.textBloxNames.Text = "";
            this.timer.Start();
        }
    }
}
