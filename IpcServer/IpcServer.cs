using CommonIpc.Ipc;
using System.ServiceModel;

namespace IpcServer
{

    /// <summary>IPCサーバ</summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class IpcServer : IIpcInterface
    {

        /// <summary>Hello World</summary>
        /// <param name="name">名称</param>
        public string Hello(string name)
        {
            return string.Format("Hello {0}", name);
        }

    }

}
