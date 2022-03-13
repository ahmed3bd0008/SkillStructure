using Entity.Core;
using Repository.Context;
using Repository.Interface;
namespace Repository.Implementation
{
    public class UntityOfWork : IUntityOfWork
    {
        private readonly AppDbContextTest _context;
        private  GenericRepository<Room> _genericRepository;

        public UntityOfWork(AppDbContextTest context)
        {
            _context=context;
        }
         public GenericRepository<Room> genericRepository {
              get{
                  if(_genericRepository==null)
                            _genericRepository=new GenericRepository<Room>(_context);
                return  _genericRepository;
              } 
              }
    }
}