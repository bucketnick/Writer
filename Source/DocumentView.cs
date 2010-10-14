namespace Writer
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using Writer.Html;

    internal class DocumentView : Panel
    {
        private Document document;

        public DocumentView(Document document)
        {
            this.document = document;

            this.Dock = DockStyle.Fill;
        }
    }
}
