using AutoMapper;
using Abp.Acme.Books;

namespace Abp.Acme;

public class AcmeApplicationAutoMapperProfile : Profile
{
    public AcmeApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();

        CreateMap<FaaDocIndexCsv, FaaDocIndexEntity>(MemberList.Source);
    }
}