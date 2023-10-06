using EnocaApi.Dal;
using EnocaNetCoreApi.CQRS.Results.CarrierResults;
using MediatR;

namespace EnocaNetCoreApi.CQRS.Queries.CarrierQueries
{
    public class GetAllCarrierQuery : IRequest<List<Carrier>>
    {
    }
}
