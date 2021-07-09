
using System.Threading.Tasks;
namespace Finance.Domain.Interfaces
{
    public interface IUnitOfWork
    {
          Task Commit();
    }
}