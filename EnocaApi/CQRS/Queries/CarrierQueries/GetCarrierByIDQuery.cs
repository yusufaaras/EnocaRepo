using EnocaNetCoreApi.CQRS.Results.CarrierResults;
using MediatR;

namespace EnocaNetCoreApi.CQRS.Queries.CarrierQueries
{
    public class GetCarrierByIDQuery : IRequest<GetCarrierByIdQueryResults>
    {
        public GetCarrierByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
