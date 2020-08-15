using Advertise.Service.Zarinpal;

namespace Advertise.Service.Managers.PaymentGateway
{
    public interface IZarinpalGatewayManager
    {
        PaymentGatewayImplementationServicePortTypeClient ZarinpalGateway();
    }
}