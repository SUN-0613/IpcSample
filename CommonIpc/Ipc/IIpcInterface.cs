using System.ServiceModel;

namespace CommonIpc.Ipc
{

    /// <summary>IPC通信用インターフェース</summary>
    [ServiceContract]
    public interface IIpcInterface
    {

        /// <summary>Hello World</summary>
        /// <param name="name">名称</param>
        [OperationContract]
        string Hello(string name);

    }

}
