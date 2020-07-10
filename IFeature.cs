namespace PluginDemo
{
    public interface IFeature
    {
        string Description { get; }

        int Execute(int a, int b);
    }
}
