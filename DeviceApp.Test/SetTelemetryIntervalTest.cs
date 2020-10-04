using DeviceApp_console.Services;
using Microsoft.Azure.Devices.Client;
using System;
using Xunit;

namespace DeviceApp.Test
{
    public class SetTelemetryIntervalTest : DeviceService
    {

        //[Fact]
        //public void GetRandomValue()
        //{
        //    var baseValue = 100;
        //    var multiplier = 0;

        //    var actual = Program.GetRandomValue(baseValue, multiplier);

        //    Assert.Equal(100, actual);
        //}



        private DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("", TransportType.Mqtt);

        [Theory]
        [InlineData("SetTelemetryInterval", "10", 200)]
        [InlineData("SetInterval", "10", 501)]
        public void SetTelemetryInterval_ShouldChangeTheInterval(string methodName, string payload, int statusCode)
        {
            deviceClient.SetMethodHandlerAsync("SetTelemetryInterval", DeviceService.SetTelemetryInterval, null).Wait(); // anroppa 

        }
    }
}
