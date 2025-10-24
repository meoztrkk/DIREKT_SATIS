using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace DIREKT_SATIS.Books;

public class Book : FullAuditedAggregateRoot<Guid> // Created/Modified bilgileri otomatik
{
    public string Name { get; private set; }
    public string? Author { get; private set; }
    public DateTime? PublishDate { get; private set; }
    public float? Price { get; private set; }
    public int? Stock { get; private set; }

    private Book() { } // EF için

    public Book(Guid id, string name, string? author = null,
                DateTime? publishDate = null, float? price = null, int? stock = null)
        : base(id)
    {
        SetName(name);
        Author = author;
        PublishDate = publishDate;
        Price = price;
        Stock = stock;
    }

    public void SetName(string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name), maxLength: 128);
    }

    public void Update(string name, string? author, DateTime? publishDate, float? price, int? stock)
    {
        SetName(name);
        Author = author;
        PublishDate = publishDate;
        Price = price;
        Stock = stock;
    }
}
