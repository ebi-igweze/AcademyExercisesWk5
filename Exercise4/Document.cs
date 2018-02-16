namespace Interfaces
{
    public class Document: IStorable, IPrintable
    {
        private string Name;
        private string Content;
        public Document(string Name, string Content) 
        {
            this.Name = Name;
            this.Content = Content;
        }

        public void Read(string content)
        {
            this.Content = content;
        }

        public void Write(IStorable str)
        {
            str.Read(this.Content);
        }

        public void Print()
        {
            System.Console.WriteLine($"Printing Document {this.Name}: {this.Content}");
        }

        public void ExportTo()
        {
            System.Console.WriteLine("Exporting to another Document");
        } 
    }
}