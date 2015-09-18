namespace Overmind.Domain.File
{
    public class Video : Abstract.File
    {
        public Video(string fileId)
            : base(fileId)
        {
            // Blank
        }

        public override void Type(string type)
        {
            // Decide type
        }
    }
}
