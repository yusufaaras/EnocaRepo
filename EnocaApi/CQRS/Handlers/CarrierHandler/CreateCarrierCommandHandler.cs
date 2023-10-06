
using EnocaApi.Dal;
using EnocaNetCoreApi.CQRS.Commands.CarrierCommand;
using MediatR;

namespace EnocaNetCoreApi.CQRS.Handlers.CarrierHandler
{
    public class CreateCarrierCommandHandler
    {
        private readonly context _context;

        public CreateCarrierCommandHandler(context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateCarrierCommand request, CancellationToken cancellationToken)
        {
            _context.Carrier.Add(new Carrier
            {
                CarrierName=request.CarrierName,
                CarrierIsActive=true,
                CarrierPlusDesiCost= request.CarrierPlusDesiCost,
                CarrierConfigurationid= request.CarrierConfigurationid,
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
