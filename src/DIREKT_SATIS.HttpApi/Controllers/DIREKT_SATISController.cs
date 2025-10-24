using DIREKT_SATIS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DIREKT_SATIS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DIREKT_SATISController : AbpControllerBase
{
    protected DIREKT_SATISController()
    {
        LocalizationResource = typeof(DIREKT_SATISResource);
    }
}
