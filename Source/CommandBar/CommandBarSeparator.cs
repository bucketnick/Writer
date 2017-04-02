namespace Writer.Forms
{
    using System.ComponentModel;

    [DesignTimeVisible(false), ToolboxItem(false)]
    public class CommandBarSeparator : CommandBarItem
    {
        public CommandBarSeparator() : base("-")
        {
        }
    }
}
