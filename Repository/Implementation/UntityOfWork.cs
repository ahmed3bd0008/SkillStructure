using Entity.Core;
using Repository.Context;
using Repository.Interface;
namespace Repository.Implementation
{
    public class UntityOfWork : IUntityOfWork
    {
        private readonly AppDbContext _context;
        private  GenericRepository<AddressBook> _genericRepository;

        public UntityOfWork(AppDbContext context)
        {
            _context=context;
        }
         public GenericRepository<AddressBook> genericRepository {
              get{
                  if(_genericRepository==null)
                            _genericRepository=new GenericRepository<AddressBook>(_context);
                return  _genericRepository;
              } 
              }
    }
}