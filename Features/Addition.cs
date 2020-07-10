namespace PluginDemo
{
    class Addition : IFeature
    {
        public string Description
        {
            get
            {
                return "Addition";
            }
        }

        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
