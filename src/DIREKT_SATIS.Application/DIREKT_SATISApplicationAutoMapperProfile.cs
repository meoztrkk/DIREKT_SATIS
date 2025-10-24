using AutoMapper;
using DIREKT_SATIS.Books;

namespace DIREKT_SATIS;

public class DIREKT_SATISApplicationAutoMapperProfile : Profile
{
    public DIREKT_SATISApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
