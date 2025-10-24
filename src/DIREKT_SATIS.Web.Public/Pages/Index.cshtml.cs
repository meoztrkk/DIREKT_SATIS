using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace DIREKT_SATIS.Web.Public.Pages;

public class IndexModel : DIREKT_SATISPublicPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
