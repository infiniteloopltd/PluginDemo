using System;
using System.Collections.Generic;
using System.Reflection;

namespace PluginDemo
{
    public static class FeatureManager
    {
        private static readonly List<IFeature> _features = new List<IFeature>();

        static FeatureManager()
        {
            var dll = Assembly.GetExecutingAssembly();
            foreach (var type in dll.GetTypes())
            {
                if (typeof(IFeature).IsAssignableFrom(type) && !type.IsInterface)
                {
                    _features.Add(Activator.CreateInstance(type) as IFeature);
                }
            }
        }

        public static List<IFeature> Features
        {
            get
            {
                return _features;
            }
        }
    }
}
