using Entity.Core;
using Repository.Implementation;

namespace Repository.Interface
{
    public interface IUntityOfWork
    {
           GenericRepository<AddressBook> genericRepository { get; }
    }
}