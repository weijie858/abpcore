using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public interface IBookAppService
    {
        public interface IBookAppService :
    ICrudAppService< //Defines CRUD methods  note by weij  using Volo.Abp.Application.Services;
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books   note by weij using Volo.Abp.Application.Services;
        CreateUpdateBookDto, //Used to create a new book
        CreateUpdateBookDto> //Used to update a book
        {

        }
    }
}
