namespace PluginDemo
{
    class Subtraction : IFeature
    {
        public string Description
        {
            get
            {
                return "Subtraction";
            }
        }

        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
