using Microsoft.Azure.Devices.Client;
using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Device
{
    class Program
    {

        // 1. skapa inctance med connection string name i Device Explorer "DeviceApp"

        private static DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("HostName=ecwin20IoTHub.azure-devices.net;DeviceId=DeviceApp;SharedAccessKey=3ezWY7wyls+AtDvS0QH1HIYMVMaEKxfV/dgtnWIY39w=", TransportType.Mqtt);

        private static int telemetryInterval = 5;// 5 secund



        static void Main(string[] args)
        {
            
        }

        // bygga 2st f.--static (hela programm)//retunera <MethodResponse> //gör det med TASK
        private static Task<MethodResponse>SetTelemetryInterval(MethodRequest request, object userContext)
        //MethodRequest - request som styra med
        {
            var payload = Encoding.UTF8.GetString(request.Data);

            if(Int32.TryParse(payload, ))// testa om det tall eller inte
            {

            }
            else
            {

            }
        }

    }
}
