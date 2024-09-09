using System.Threading.Tasks;

namespace Dbscan.Eventing
{
    public interface IDbscanEventSubscriber<TR>
    {
        Task<TR> Subscribe();
    }
}