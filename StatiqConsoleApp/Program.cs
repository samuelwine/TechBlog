using Statiq.App;
using Statiq.Web;

namespace MySite
{
    public class Program
    {
        public static async Task<int> Main(string[] args) =>
          await Bootstrapper
            .Factory
            .CreateDefaultWithout(args, DefaultFeatures.Pipelines)
            .AddWeb()
            .RunAsync();
    }
}