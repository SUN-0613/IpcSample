using CommonIpc.Ipc;
using CommonIpc.Resources;
using System;
using System.ServiceModel;
using System.Threading;

namespace IpcClient
{

    /// <summary>IPC通信サンプル.クライアント</summary>
    class Program
    {

        /// <summary>処理開始</summary>
        /// <param name="args">引数</param>
        static void Main(string[] args)
        {

            var server = new ChannelFactory<IIpcInterface>(
                new NetNamedPipeBinding(),
                new EndpointAddress(Resources.baseAddress + "/" + Resources.endPoint)
                ).CreateChannel();

            Console.WriteLine("Client");

            for (var iLoop = 1; iLoop <= 5; iLoop++)
            {

                Thread.Sleep(1000);
                Console.CursorLeft = 0;
                Console.Write("{0}sec", iLoop);

            }

            Console.WriteLine("");

            var value = server.Hello("Yamamoto");

            Console.WriteLine(value);

            Console.WriteLine("何かキーを押して終了してください");
            Console.ReadKey();

        }

    }

}
