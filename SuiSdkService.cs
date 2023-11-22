using Jering.Javascript.NodeJS;

namespace SuiSdkBridgePoc;

internal class SuiSdkService
{
    private const string ModulePath = "./dist/bridge.js";
    private readonly INodeJSService _nodeJSService;

    public SuiSdkService(INodeJSService nodeJSService)
    {
        _nodeJSService = nodeJSService;
    }

    public async Task<string?> GenerateAddressAsync()
    {
        return await _nodeJSService.InvokeFromFileAsync<string>(ModulePath, "generateAddress");
    }
}