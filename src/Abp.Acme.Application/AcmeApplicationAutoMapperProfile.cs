using AutoMapper;
using Abp.Acme.Books;

namespace Abp.Acme;

public class AcmeApplicationAutoMapperProfile : Profile
{
    public AcmeApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
