using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace NameListGenerator
{
    /// <summary>
    /// Interaction logic for Extractor.xaml
    /// </summary>
    public partial class Extractor : UserControl
    {
        private readonly List<string> lines;
        private readonly List<string> result;

        public Extractor()
        {
            InitializeComponent();

            this.lines = new List<string>();
            this.result = new List<string>();
        }

        private void ParseInput()
        {
            this.lines.Clear();
            string input = this.textBoxInput.Text;
            string[] lines = input.Split('\n', '\r');

            this.lines.AddRange(lines.Where(X => !string.IsNullOrEmpty(X)));
        }

        private string CreateText(IEnumerable<string> Lines)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in Lines)
            {
                sb.AppendLine(line);
            }
            return sb.ToString();
        }

        private void ButtonExtractClick(object Sender, RoutedEventArgs E)
        {
            this.ParseInput();

            string keyword = this.textBoxKeyword.Text;
            this.result.Clear();
            this.result.AddRange(this.lines.Where(X => X.ToLower().Contains(keyword.ToLower())));
            this.textBoxResult.Text = this.CreateText(this.result);
        }

        private void ButtonCopyResultToClipboardClick(object Sender, RoutedEventArgs E)
        {
            Clipboard.SetText(this.CreateText(this.result), TextDataFormat.Text);
        }

        private void ButtonCopyCorrectedSourceClipboardClick(object Sender, RoutedEventArgs E)
        {
            Clipboard.SetText(this.CreateText(this.lines.Where( X => !this.result.Contains(X))), TextDataFormat.Text);
        }
    }
}
