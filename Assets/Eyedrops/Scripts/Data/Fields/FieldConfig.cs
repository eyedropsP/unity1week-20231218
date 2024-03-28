namespace Eyedrops.Data.Fields
{
    public sealed class FieldConfig
    {
        public int Width { get; private set; }
        
        public int Height { get; private set; }
        
        public NoEntryArea[] NoEntryAreas { get; private set; }
        
        
    }


    public sealed class NoEntryArea
    {
        public int Point { get; private set; }
        
        public string SpriteName { get; private set; }
    }
}