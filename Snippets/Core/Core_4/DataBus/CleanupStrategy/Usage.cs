namespace Snippets4.DataBus.CleanupStrategy
{
    using System;
    using System.IO;
    using Core4.DataBus.DataBusProperty;

    public class Usage
    {
        #region FileLocationForDatabusFiles
        public void Handle(MessageWithLargePayload message)
        {
            string filename = Path.Combine(@"\\share\databus_attachments\", message.LargeBlob.Key);
            Console.WriteLine(filename);
        }
        #endregion
    }
}