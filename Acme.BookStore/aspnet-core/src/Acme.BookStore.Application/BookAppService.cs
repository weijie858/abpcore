using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos; //PagedAndSortedResultRequestDto
using Volo.Abp.Application.Services;  //CrudAppService
using Volo.Abp.Domain.Repositories; //IRepository

namespace Acme.BookStore
{
    public class BookAppService :
        CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto,
                       CreateUpdateBookDto, CreateUpdateBookDto>,
        IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {

        }
    }
}
