using System;
using Castle.DynamicProxy;

namespace curtsm
{
    /// <summary>
    /// 自定义拦截方法,nuget需要引用castle
    /// </summary>
    public class MyFilter : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var method = invocation.GetConcreteMethod();

            //获得目标方法，参数并不需要自己丢给目标，只是可以取出做其他操作
            //var s = invocation.Arguments[0]?.ToString();
            //获得非抽象方法
            if (!invocation.MethodInvocationTarget.IsAbstract)
            {
                Console.WriteLine("执行前");
                try
                {
                    //执行被拦截方法
                    invocation.Proceed();
                }
                catch (Exception e)
                {
                    Console.WriteLine("全局异常拦截");
                }

                Console.WriteLine("执行结果"+invocation.ReturnValue);
            }

            Console.WriteLine("执行完毕");
        }
    }
}