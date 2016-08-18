using ModToolbox.Release;
using System;
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

            this.creator = new ReleaseCreator();
            this.creator.MessageReady += this.ReleaseCreatorMessageReady;
        }

        private void ReleaseCreatorMessageReady(object Sender, ReleaseCreatorEventArgs E)
        {
            this.textBoxOutput.AppendText(E.Message);
            this.textBoxOutput.AppendText(Environment.NewLine);
        }

        private void ButtonMakeReleaseClick(object Sender, RoutedEventArgs E)
        {
            this.textBoxOutput.Text = string.Empty;
            this.creator.RepositoryPath = this.textBoxRepository.Text;
            this.creator.RunAsync();
        }
    }
}
