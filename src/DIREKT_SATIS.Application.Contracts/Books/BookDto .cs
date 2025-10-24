using System;
using Volo.Abp.Application.Dtos;

namespace DIREKT_SATIS.Books;

public class BookDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; } = default!;
    public string? Author { get; set; }
    public DateTime? PublishDate { get; set; }
    public float? Price { get; set; }
    public int? Stock { get; set; }
}
 
