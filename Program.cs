using Jering.Javascript.NodeJS;
using Microsoft.Extensions.DependencyInjection;
using SuiSdkBridgePoc;

var services = new ServiceCollection();
services.AddNodeJS();
services.AddSingleton<SuiSdkService>();
var serviceProvider = services.BuildServiceProvider();

var suiSdk = serviceProvider.GetRequiredService<SuiSdkService>();

for (var i = 0; i < 10; i++)
{
    var generatedAddress = await suiSdk.GenerateAddressAsync();
    Console.WriteLine(generatedAddress);
}