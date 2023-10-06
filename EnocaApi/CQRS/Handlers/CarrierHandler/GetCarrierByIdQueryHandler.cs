
using EnocaApi.Dal;
using EnocaNetCoreApi.CQRS.Queries.CarrierQueries;
using EnocaNetCoreApi.CQRS.Results.CarrierResults;
using MediatR;

namespace EnocaNetCoreApi.CQRS.Handlers.CarrierHandler
{
    public class GetCarrierByIdQueryHandler: IRequestHandler<GetCarrierByIDQuery, GetCarrierByIdQueryResults>
    {
        private readonly context _context;

        public GetCarrierByIdQueryHandler(context context)
        {
            _context = context;
        }

        public async Task<GetCarrierByIdQueryResults> Handle(GetCarrierByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Carrier.FindAsync(request.id);
            return new GetCarrierByIdQueryResults
            {
                CarrierConfigurationid = values.CarrierConfigurationid,
                CarrierId = values.CarrierId,   
                CarrierName = values.CarrierName,
                CarrierPlusDesiCost=values.CarrierPlusDesiCost,
            };
        }
    }
}
