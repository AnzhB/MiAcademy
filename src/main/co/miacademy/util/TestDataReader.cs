using System.Resources;
using Co.miacademy.Model.Enums;

namespace Co.miacademy.Util
{

    public static class TestDataReader
    {
        private static readonly ResourceManager resourceManager = GetResourceManager(EnvironmentType.PROD);

        private static ResourceManager GetResourceManager(EnvironmentType environmentType)
        {
            switch (environmentType)
            {
                case EnvironmentType.LOCAL:
                    return new ResourceManager("MiAcademy.src.test.co.miacademy.resources.environment.local", typeof(TestDataReader).Assembly);
                case EnvironmentType.PROD:
                    return new ResourceManager("MiAcademy.src.test.co.miacademy.resources.environment.prod", typeof(TestDataReader).Assembly);
                default:
                    throw new ArgumentException("Unsupported environment type: " + environmentType);
            }
        }

        public static string GetTestData(string key)
        {
            try
            {
                return resourceManager.GetString(key);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Failed to retrieve resource for key '{key}'", ex);
            }
        }
    }
}