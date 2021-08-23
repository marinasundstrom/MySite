using Statiq.App;
using Statiq.Web;
using Statiq.Common;

DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
dtfi.ShortDatePattern = "yyyy/MM/dd";
CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.Name);
ci.DateTimeFormat = dtfi;

CultureInfo.CurrentCulture = ci;

await Bootstrapper
    .Factory
    .CreateWeb(args)
    .DeployToGitHubPages(
        "robertsundstrom",
        "robertsundstrom.github.io",
        Config.FromSetting<string>("GITHUB_TOKEN")
    )
    .RunAsync();