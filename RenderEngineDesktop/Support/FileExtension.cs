namespace RenderEngineDesktop.Support
{
    public class FileExtension
    {
        public string Description { get; }
        public string Extension { get; }

        public FileExtension(string description, string extension)
        {
            Description = description;
            Extension = extension;
        }

        public string Filter => $"{Description}|{Extension}";
    }
}
