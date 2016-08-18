using System;

namespace ModToolbox.Release
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
