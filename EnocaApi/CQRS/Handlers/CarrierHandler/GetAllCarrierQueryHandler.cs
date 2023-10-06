
using EnocaApi.Dal;
using EnocaNetCoreApi.CQRS.Queries.CarrierQueries;
using EnocaNetCoreApi.CQRS.Results.CarrierResults;
using EnocaNetCoreApi.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EnocaNetCoreApi.CQRS.Handlers.CarrierHandler
{
    public class GetAllCarrierQueryHandler : IRequestHandler<GetAllCarrierQuery, List<Carrier>>
    {
        private readonly CarrierRepository _carrierRepository;

        public GetAllCarrierQueryHandler(CarrierRepository carrierRepository)
        {
            _carrierRepository = carrierRepository;
        }
        //public List<GetAllCarrierResult> Handle()
        //{
        //    var values = _context.Carrier.Select(x => new GetAllCarrierResult
        //    {
        //        id=x.CarrierId,
        //        carrierName=x.CarrierName,
        //        carrierConfigurationid=x.CarrierConfigurationid,
        //        carrierIsActive=x.CarrierIsActive,
        //        carrierPlusDesiCost=x.CarrierPlusDesiCost
        //    }).AsNoTracking().ToList();
        //    return values;
        //}

        //public async Task<List<GetAllCarrierResult>> Handle(GetAllCarrierQuery request, CancellationToken cancellationToken)
        //{
        //    return await _context.Carrier.Select(x => new GetAllCarrierResult
        //    {
        //        id = x.CarrierId,
        //        carrierName = x.CarrierName,
        //        carrierConfigurationid = x.CarrierConfigurationid,
        //        carrierIsActive = x.CarrierIsActive,
        //        carrierPlusDesiCost = x.CarrierPlusDesiCost
        //    }).AsNoTracking().ToListAsync();
        //}

        public List<Carrier> Handle(GetAllCarrierQuery request, CancellationToken cancellationToken)
        {
            return _carrierRepository.GetAllCarriers();
        }

        Task<List<Carrier>> IRequestHandler<GetAllCarrierQuery, List<Carrier>>.Handle(GetAllCarrierQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
