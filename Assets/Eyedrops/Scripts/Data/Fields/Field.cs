namespace Eyedrops.Data.Fields
{
    public sealed class Field
    {
        public int Width { get; private set; }

        public int Height { get; private set; }

        public FieldPoint[][] WholePoints { get; private set; }
        
        public FieldPoint[] NoEntryPoints { get; private set; }


        public void Initialize()
        {
        }


#if UNITY_EDITOR
        private void CreateFieldPoints()
        {
            
        }
    }
#endif
}