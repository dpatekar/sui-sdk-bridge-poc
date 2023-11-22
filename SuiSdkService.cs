using Jering.Javascript.NodeJS;

namespace SuiSdkBridgePoc;

internal class SuiSdkService
{
    private const string BridgeModulePath = "./dist/bridge.js";
    private readonly INodeJSService _nodeJsService;

    public SuiSdkService(INodeJSService nodeJsService)
    {
        _nodeJsService = nodeJsService;
    }

    public async Task<string?> GenerateAddressAsync()
    {
        return await _nodeJsService.InvokeFromFileAsync<string>(BridgeModulePath, "generateAddress");
    }
}