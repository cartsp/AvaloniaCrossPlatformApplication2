using Avalonia.Web.Blazor;

namespace AvaloniaCrossPlatformApplication2.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        WebAppBuilder.Configure<AvaloniaCrossPlatformApplication2.App>()
            .SetupWithSingleViewLifetime();
    }
}