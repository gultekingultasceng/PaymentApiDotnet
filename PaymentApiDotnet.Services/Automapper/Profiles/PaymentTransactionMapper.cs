using AutoMapper;
using PaymentApiDotnet.Entities.DataTransferObjects;
using PaymentApiDotnet.Entities.Models;


namespace PaymentApiDotnet.Services.Automapper.Profiles
{
    public class PaymentTransactionMapper : Profile
    {
        public PaymentTransactionMapper()
        {
            CreateMap<PaymentRequestDto, PaymentTransaction>();
            CreateMap<Bin, PaymentTransaction>()
                .ForMember(i => i.Id, opt => opt.Ignore());
            CreateMap<PaymentTransaction, PaymentTransactionDto>();
        }
    }
}
