using AutoMapper;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Entities.Models;
namespace PaymentApiDotnet.AutoMapper.Profiles
{
    public class PaymentTransactionMapper : Profile
    {
        public  PaymentTransactionMapper()
        {
            CreateMap<PaymentRequestDto, PaymentTransaction>();
            CreateMap<Bin, PaymentTransaction>()
                .ForMember(i => i.Id , opt => opt.Ignore());
            CreateMap<PaymentTransaction, PaymentTransactionDto>();
                
        }
    }
}
