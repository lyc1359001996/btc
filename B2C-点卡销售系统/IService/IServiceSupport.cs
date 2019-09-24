using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.IService
{
    //IServiceSupport是一个标志接口，所有服务都必须实现这个接口
    //这样可以保证只有真正的服务实现类才会被注册到autofac
    public interface IServiceSupport
    {
    }
}
