using Base.Utilities.Interceptors;
using Castle.DynamicProxy;

namespace Business.BusinessAspects.Autofac
{
    public class ExceptionAspect : MethodInterception
    {
        public ExceptionAspect()
        {

        }

        protected override void OnException(IInvocation invocation, Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
