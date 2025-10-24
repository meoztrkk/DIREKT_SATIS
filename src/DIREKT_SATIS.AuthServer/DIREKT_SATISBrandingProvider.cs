using Microsoft.Extensions.Localization;
using DIREKT_SATIS.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DIREKT_SATIS;

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
