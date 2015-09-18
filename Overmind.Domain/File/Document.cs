namespace Overmind.Domain.File
{
    public class Document : Abstract.File
    {
        public Document(string fileId, string type) 
            : base(fileId)
        {
            // Blank

        }

        public override void Type(string type)
        {
            // Decide the config depending on type
        }
    }
}
