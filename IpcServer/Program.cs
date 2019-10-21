using CommonIpc.Ipc;
using CommonIpc.Resources;
using System;
using System.ServiceModel;

namespace IpcServer
{

    /// <summary>IPC通信サンプル.サーバ</summary>
    class Program
    {

        /// <summary>処理開始</summary>
        /// <param name="args">引数</param>
        static void Main(string[] args)
        {

            Console.WriteLine("Server");

            // 本プログラムのアドレス指定
            var endPoint = Resources.endPoint;

            // サービス宣言
            var host = new ServiceHost(new IpcServer(), new Uri(Resources.baseAddress));
            host.AddServiceEndpoint(typeof(IIpcInterface), new NetNamedPipeBinding(), endPoint);

            // サービス開始
            host.Open();

            Console.WriteLine("待機中...");

            // クライアントからの連絡待ち
            Console.ReadKey();

            // サービス終了
            host.Close();

        }

    }

}
