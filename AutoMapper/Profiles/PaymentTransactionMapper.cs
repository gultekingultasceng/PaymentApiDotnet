using AutoMapper;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Models;

namespace PaymentApiDotnet.AutoMapper.Profiles
{
    public class PaymentTransactionMapper : Profile
    {
        public  PaymentTransactionMapper()
        {
            CreateMap<PaymentRequestDto, PaymentTransaction>();
            CreateMap<Bin, PaymentTransaction>();
        }

       
    }
}
