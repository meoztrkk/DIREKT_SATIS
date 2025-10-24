using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using DIREKT_SATIS.Localization;

namespace DIREKT_SATIS.Web.Public;

[Dependency(ReplaceServices = true)]
public class DIREKT_SATISBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<DIREKT_SATISResource> _localizer;

    public DIREKT_SATISBrandingProvider(IStringLocalizer<DIREKT_SATISResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
