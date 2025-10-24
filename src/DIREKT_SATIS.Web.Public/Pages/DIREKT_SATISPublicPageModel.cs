using DIREKT_SATIS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DIREKT_SATIS.Web.Public.Pages;

/* Inherit your Page Model classes from this class.
 */
public abstract class DIREKT_SATISPublicPageModel : AbpPageModel
{
    protected DIREKT_SATISPublicPageModel()
    {
        LocalizationResourceType = typeof(DIREKT_SATISResource);
    }
}
