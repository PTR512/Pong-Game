namespace Data
{
    internal class Data : DataAPI
    {
        private readonly int FieldHeight = 500;
        private readonly int FieldWidth = 800;
        public override int GetFieldHeight()
        {
            return FieldHeight;
        }

        public override int GetFieldWidth()
        {
            return FieldWidth;
        }
    }
}
