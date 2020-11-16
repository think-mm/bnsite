using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

namespace mmblog {
    public class Program {
        public static async Task<int> Main(string[] args) =>
            await Bootstrapper
                .Factory
                .CreateWeb(args)
                .DeployToGitHubPagesBranch("think-mm", "bnsite", Config.FromSetting<string>("GITHUB_TOKEN"), "web")
                .RunAsync();
    }
}
