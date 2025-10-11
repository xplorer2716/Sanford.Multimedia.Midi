using System;
using System.Collections;

namespace Sanford.Multimedia.Midi
{
    /// <summary>
    /// A class for stopped events.
    /// </summary>
    public class StoppedEventArgs : EventArgs
    {
        private ICollection messages;

        /// <summary>
		/// Main function for stopped events.
		/// </summary>
        public StoppedEventArgs(ICollection messages)
        {
            this.messages = messages;
        }

        /// <summary>
		/// Gets and returns messages.
		/// </summary>
        public ICollection Messages
        {
            get
            {
                return messages;
            }
        }
    }
}
