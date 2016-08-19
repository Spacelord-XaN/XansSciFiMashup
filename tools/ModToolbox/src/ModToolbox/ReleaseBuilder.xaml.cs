using ModToolbox.Release;
using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace ModToolbox
{
    /// <summary>
    /// Interaction logic for ReleaseBuilder.xaml
    /// </summary>
    public partial class ReleaseBuilder : UserControl
    {
        private readonly ReleaseCreator creator;

        public ReleaseBuilder()
        {
            InitializeComponent();

            this.textBoxInkscapePath.Text = this.SuggestInkscapePath();
            this.textBoxRepository.Text = this.SuggestRepositoryPath();
            this.textBoxTarget.Text = this.SuggestTargetPath();

            this.creator = new ReleaseCreator();
            this.creator.MessageReady += this.ReleaseCreatorMessageReady;
        }

        private string SuggestInkscapePath()
        {
            return @"C:\Program Files\Inkscape\inkscape.exe";
        }

        private string SuggestRepositoryPath()
        {
            Assembly myAssembly = Assembly.GetAssembly(typeof(ReleaseBuilder));
            FileInfo fileInfo = new FileInfo(myAssembly.Location);
            string path = Path.Combine(fileInfo.Directory.FullName, "..", "..", "..", "..", "..", "..");
            path = Path.GetFullPath(path);
            return path;
        }

        private string SuggestTargetPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = Path.Combine(path, "Paradox", "Stellaris", "mods");
            return path;
        }

        private void ReleaseCreatorMessageReady(object Sender, ReleaseCreatorEventArgs E)
        {
            this.textBoxOutput.AppendText(E.Message);
            this.textBoxOutput.AppendText(Environment.NewLine);
        }

        private void ButtonMakeReleaseClick(object Sender, RoutedEventArgs E)
        {
            Setup setup = new Setup();
            setup.CopyToTarget = this.checkBoxCopy.IsChecked == true;
            setup.CreateFlags = this.checkBoxCreateFlags.IsChecked == true;
            setup.CreatePortraits = this.checkBoxCreatePortraits.IsChecked == true;
            setup.InkscapePath = this.textBoxInkscapePath.Text;
            setup.RepositoryPath = this.textBoxRepository.Text;
            setup.TargetPath = this.textBoxTarget.Text;

            this.textBoxOutput.Text = string.Empty;
            this.creator.Setup = setup;
            this.creator.RunAsync();
        }
    }
}
