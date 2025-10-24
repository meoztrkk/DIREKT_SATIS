using System;
using DIREKT_SATIS.Books;
using DIREKT_SATIS.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Authorization;
using Volo.Abp.Domain.Repositories;

namespace DIREKT_SATIS;

public class BookAppService :
    CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto, CreateUpdateBookDto>,
    IApplicationService
{
    public BookAppService(IRepository<Book, Guid> repository) : base(repository)
    {
        GetPolicyName = DIREKT_SATISPermissions.Books.Default;
        GetListPolicyName = DIREKT_SATISPermissions.Books.Default;
        CreatePolicyName = DIREKT_SATISPermissions.Books.Create;
        UpdatePolicyName = DIREKT_SATISPermissions.Books.Edit;
        DeletePolicyName = DIREKT_SATISPermissions.Books.Delete;
    }
}
