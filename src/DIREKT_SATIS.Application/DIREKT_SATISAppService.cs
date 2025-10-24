using DIREKT_SATIS.Localization;
using Volo.Abp.Application.Services;

namespace DIREKT_SATIS;

/* Inherit your application services from this class.
 */
public abstract class DIREKT_SATISAppService : ApplicationService
{
    protected DIREKT_SATISAppService()
    {
        LocalizationResource = typeof(DIREKT_SATISResource);
    }
}
