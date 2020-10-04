using Microsoft.Azure.Devices;
using System;
using System.Threading.Tasks;

namespace ServiceApp
{
    class Program
    {
        private static ServiceClient serviceClient = ServiceClient.CreateFromConnectionString(
            "HostName=ecwin20IoTHub.azure-devices.net;DeviceId=DeviceApp;SharedAccessKey=3ezWY7wyls+AtDvS0QH1HIYMVMaEKxfV/dgtnWIY39w=");

        static void Main(string[] args)
        { 
            Task.Delay(5000).Wait(); // för att hinna se vad händer

            InvokeMethod("DeviceApp", "SetTelemetryInterval", "10").GetAwaiter(); //++10 -payload interval
            Console.ReadKey();
        }


        //skickad genom payload-- måste ta hand om payload
        static async Task InvokeMethod(string deviceId, string methodName, string payload) //++payload string
        {// methodName --"SetTelemetryInteval"
            var methodInvocation = new CloudToDeviceMethod(methodName) { ResponseTimeout = TimeSpan.FromSeconds(30) };
            methodInvocation.SetPayloadJson(payload); //++payload


            var response = await serviceClient.InvokeDeviceMethodAsync(deviceId, methodInvocation);//deviceId-- DeviceAPP
            Console.WriteLine($"Response Status: {response.Status}");
            Console.WriteLine(response.GetPayloadAsJson());

        }
    }
}
