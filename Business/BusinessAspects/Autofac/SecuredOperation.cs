using Base.Utilities.Interceptors;
using Business.HelperClasses;
using Castle.DynamicProxy;
using Entities.Dtos.Users;
using Entities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private UserClaims _role;
        public SecuredOperation(UserClaims role)
        {           
            _role = role;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            if (CurrentUser.UserClaim == _role)
            {
                return;
            }
            throw new Exception("Bu işlemi yapmaya yetkiniz bulunmamaktadır");
        }

        

        
    }
}
