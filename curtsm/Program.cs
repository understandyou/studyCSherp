using System;
using Castle.DynamicProxy;

namespace curtsm
{
    class Program
    {
        static void Main(string[] args)
        {
            //动态拦截，使用castle类库实现，用nuget引用即可
            //自定义拦截器
            MyFilter myFilter = new MyFilter();
            //代理对象
            ProxyGenerator proxy = new ProxyGenerator();
            //编织目标对象
            Iyw yw = proxy.CreateInterfaceProxyWithTarget<Iyw>(new yw(), myFilter);
            yw.Home("aaa", "bbb");
            //被编制后的对象所以方法都会被代理
            yw.two();
            //proxy.CreateInterfaceProxyWithoutTarget()
        }
    }
}
