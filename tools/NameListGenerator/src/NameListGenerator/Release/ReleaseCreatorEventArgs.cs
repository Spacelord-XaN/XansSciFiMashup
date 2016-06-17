using System;

namespace NameListGenerator.Release
{
    public class ReleaseCreatorEventArgs : EventArgs
    {
        public ReleaseCreatorEventArgs(string Message)
        {
            this.Message = Message;
        }

        public string Message
        {
            get;
            set;
        }
    }
}
