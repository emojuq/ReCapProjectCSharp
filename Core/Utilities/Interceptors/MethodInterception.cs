using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception:MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation İnvocation) { }
        protected virtual void OnAfter(IInvocation İnvocation) { }
        protected virtual void OnException(IInvocation İnvocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation İnvocation) { }

        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);

            try
            {
                invocation.Proceed();
            }

            catch (Exception e)
            {

                isSuccess = false;
                OnException(invocation, e);
                return;
            }

            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }

            OnAfter(invocation);

        }

    }
}
