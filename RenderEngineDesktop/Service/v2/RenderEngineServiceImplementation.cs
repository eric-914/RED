﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RES.V2;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IRenderEngineService")]
public interface IRenderEngineService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderLeads", ReplyAction="http://tempuri.org/IRenderEngineService/RenderLeadsResponse")]
    void RenderLeads(System.Guid clientId, string instance, string environment, string key, System.Guid[] leadIds, string outputFilePath);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderLeads", ReplyAction="http://tempuri.org/IRenderEngineService/RenderLeadsResponse")]
    System.Threading.Tasks.Task RenderLeadsAsync(System.Guid clientId, string instance, string environment, string key, System.Guid[] leadIds, string outputFilePath);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderOutputFiles", ReplyAction="http://tempuri.org/IRenderEngineService/RenderOutputFilesResponse")]
    void RenderOutputFiles(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string[] outputFilePaths);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderOutputFiles", ReplyAction="http://tempuri.org/IRenderEngineService/RenderOutputFilesResponse")]
    System.Threading.Tasks.Task RenderOutputFilesAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string[] outputFilePaths);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderOutputFilesWithWaterMark", ReplyAction="http://tempuri.org/IRenderEngineService/RenderOutputFilesWithWaterMarkResponse")]
    void RenderOutputFilesWithWaterMark(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string[] outputFilePaths, string waterMark);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderOutputFilesWithWaterMark", ReplyAction="http://tempuri.org/IRenderEngineService/RenderOutputFilesWithWaterMarkResponse")]
    System.Threading.Tasks.Task RenderOutputFilesWithWaterMarkAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string[] outputFilePaths, string waterMark);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderPreviewHTML5", ReplyAction="http://tempuri.org/IRenderEngineService/RenderPreviewHTML5Response")]
    string RenderPreviewHTML5(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderPreviewHTML5", ReplyAction="http://tempuri.org/IRenderEngineService/RenderPreviewHTML5Response")]
    System.Threading.Tasks.Task<string> RenderPreviewHTML5Async(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderPreviewSwf", ReplyAction="http://tempuri.org/IRenderEngineService/RenderPreviewSwfResponse")]
    byte[] RenderPreviewSwf(System.Guid clientId, string instance, string environment, string key, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, bool suppressMultimediaLinks);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderPreviewSwf", ReplyAction="http://tempuri.org/IRenderEngineService/RenderPreviewSwfResponse")]
    System.Threading.Tasks.Task<byte[]> RenderPreviewSwfAsync(System.Guid clientId, string instance, string environment, string key, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, bool suppressMultimediaLinks);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderPreview", ReplyAction="http://tempuri.org/IRenderEngineService/RenderPreviewResponse")]
    byte[] RenderPreview(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderPreview", ReplyAction="http://tempuri.org/IRenderEngineService/RenderPreviewResponse")]
    System.Threading.Tasks.Task<byte[]> RenderPreviewAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderWaterMarkedPreview", ReplyAction="http://tempuri.org/IRenderEngineService/RenderWaterMarkedPreviewResponse")]
    byte[] RenderWaterMarkedPreview(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderWaterMarkedPreview", ReplyAction="http://tempuri.org/IRenderEngineService/RenderWaterMarkedPreviewResponse")]
    System.Threading.Tasks.Task<byte[]> RenderWaterMarkedPreviewAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderLowResPreview", ReplyAction="http://tempuri.org/IRenderEngineService/RenderLowResPreviewResponse")]
    void RenderLowResPreview(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string outputFilePath);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderLowResPreview", ReplyAction="http://tempuri.org/IRenderEngineService/RenderLowResPreviewResponse")]
    System.Threading.Tasks.Task RenderLowResPreviewAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string outputFilePath);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderLowResPreviewWithWaterMark", ReplyAction="http://tempuri.org/IRenderEngineService/RenderLowResPreviewWithWaterMarkResponse")]
    void RenderLowResPreviewWithWaterMark(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string outputFilePath, string waterMark);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderLowResPreviewWithWaterMark", ReplyAction="http://tempuri.org/IRenderEngineService/RenderLowResPreviewWithWaterMarkResponse")]
    System.Threading.Tasks.Task RenderLowResPreviewWithWaterMarkAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string outputFilePath, string waterMark);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderZoomedPreviewFragment", ReplyAction="http://tempuri.org/IRenderEngineService/RenderZoomedPreviewFragmentResponse")]
    byte[] RenderZoomedPreviewFragment(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent, float percentXTranslation, float percentYTranslation, float percentageWidth, float percentageHeight);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/RenderZoomedPreviewFragment", ReplyAction="http://tempuri.org/IRenderEngineService/RenderZoomedPreviewFragmentResponse")]
    System.Threading.Tasks.Task<byte[]> RenderZoomedPreviewFragmentAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent, float percentXTranslation, float percentYTranslation, float percentageWidth, float percentageHeight);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/ListEnumeratedFonts", ReplyAction="http://tempuri.org/IRenderEngineService/ListEnumeratedFontsResponse")]
    string ListEnumeratedFonts();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/ListEnumeratedFonts", ReplyAction="http://tempuri.org/IRenderEngineService/ListEnumeratedFontsResponse")]
    System.Threading.Tasks.Task<string> ListEnumeratedFontsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/PrepSwfForParse", ReplyAction="http://tempuri.org/IRenderEngineService/PrepSwfForParseResponse")]
    void PrepSwfForParse(System.Guid clientId, string instance, string environment, string key, string swfFileName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/PrepSwfForParse", ReplyAction="http://tempuri.org/IRenderEngineService/PrepSwfForParseResponse")]
    System.Threading.Tasks.Task PrepSwfForParseAsync(System.Guid clientId, string instance, string environment, string key, string swfFileName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/PrepZipDirectoryForParse", ReplyAction="http://tempuri.org/IRenderEngineService/PrepZipDirectoryForParseResponse")]
    void PrepZipDirectoryForParse(System.Guid clientId, string instance, string environment, string key, string zipFileName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRenderEngineService/PrepZipDirectoryForParse", ReplyAction="http://tempuri.org/IRenderEngineService/PrepZipDirectoryForParseResponse")]
    System.Threading.Tasks.Task PrepZipDirectoryForParseAsync(System.Guid clientId, string instance, string environment, string key, string zipFileName);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IRenderEngineServiceChannel : IRenderEngineService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class RenderEngineServiceClient : System.ServiceModel.ClientBase<IRenderEngineService>, IRenderEngineService
{
    
    public RenderEngineServiceClient()
    {
    }
    
    public RenderEngineServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public RenderEngineServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public RenderEngineServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public RenderEngineServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void RenderLeads(System.Guid clientId, string instance, string environment, string key, System.Guid[] leadIds, string outputFilePath)
    {
        base.Channel.RenderLeads(clientId, instance, environment, key, leadIds, outputFilePath);
    }
    
    public System.Threading.Tasks.Task RenderLeadsAsync(System.Guid clientId, string instance, string environment, string key, System.Guid[] leadIds, string outputFilePath)
    {
        return base.Channel.RenderLeadsAsync(clientId, instance, environment, key, leadIds, outputFilePath);
    }
    
    public void RenderOutputFiles(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string[] outputFilePaths)
    {
        base.Channel.RenderOutputFiles(clientId, instance, environment, key, cultureName, templateInstanceId, outputFilePaths);
    }
    
    public System.Threading.Tasks.Task RenderOutputFilesAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string[] outputFilePaths)
    {
        return base.Channel.RenderOutputFilesAsync(clientId, instance, environment, key, cultureName, templateInstanceId, outputFilePaths);
    }
    
    public void RenderOutputFilesWithWaterMark(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string[] outputFilePaths, string waterMark)
    {
        base.Channel.RenderOutputFilesWithWaterMark(clientId, instance, environment, key, cultureName, templateInstanceId, outputFilePaths, waterMark);
    }
    
    public System.Threading.Tasks.Task RenderOutputFilesWithWaterMarkAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string[] outputFilePaths, string waterMark)
    {
        return base.Channel.RenderOutputFilesWithWaterMarkAsync(clientId, instance, environment, key, cultureName, templateInstanceId, outputFilePaths, waterMark);
    }
    
    public string RenderPreviewHTML5(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId)
    {
        return base.Channel.RenderPreviewHTML5(clientId, instance, environment, key, cultureName, templateInstanceId);
    }
    
    public System.Threading.Tasks.Task<string> RenderPreviewHTML5Async(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId)
    {
        return base.Channel.RenderPreviewHTML5Async(clientId, instance, environment, key, cultureName, templateInstanceId);
    }
    
    public byte[] RenderPreviewSwf(System.Guid clientId, string instance, string environment, string key, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, bool suppressMultimediaLinks)
    {
        return base.Channel.RenderPreviewSwf(clientId, instance, environment, key, templateInstanceId, maximumWidthInPixels, maximumHeightInPixels, suppressMultimediaLinks);
    }
    
    public System.Threading.Tasks.Task<byte[]> RenderPreviewSwfAsync(System.Guid clientId, string instance, string environment, string key, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, bool suppressMultimediaLinks)
    {
        return base.Channel.RenderPreviewSwfAsync(clientId, instance, environment, key, templateInstanceId, maximumWidthInPixels, maximumHeightInPixels, suppressMultimediaLinks);
    }
    
    public byte[] RenderPreview(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent)
    {
        return base.Channel.RenderPreview(clientId, instance, environment, key, cultureName, templateInstanceId, maximumWidthInPixels, maximumHeightInPixels, outlineColorRedComponent, outlineColorGreenComponent, outlineColorBlueComponent);
    }
    
    public System.Threading.Tasks.Task<byte[]> RenderPreviewAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent)
    {
        return base.Channel.RenderPreviewAsync(clientId, instance, environment, key, cultureName, templateInstanceId, maximumWidthInPixels, maximumHeightInPixels, outlineColorRedComponent, outlineColorGreenComponent, outlineColorBlueComponent);
    }
    
    public byte[] RenderWaterMarkedPreview(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent)
    {
        return base.Channel.RenderWaterMarkedPreview(clientId, instance, environment, key, cultureName, templateInstanceId, maximumWidthInPixels, maximumHeightInPixels, outlineColorRedComponent, outlineColorGreenComponent, outlineColorBlueComponent);
    }
    
    public System.Threading.Tasks.Task<byte[]> RenderWaterMarkedPreviewAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent)
    {
        return base.Channel.RenderWaterMarkedPreviewAsync(clientId, instance, environment, key, cultureName, templateInstanceId, maximumWidthInPixels, maximumHeightInPixels, outlineColorRedComponent, outlineColorGreenComponent, outlineColorBlueComponent);
    }
    
    public void RenderLowResPreview(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string outputFilePath)
    {
        base.Channel.RenderLowResPreview(clientId, instance, environment, key, cultureName, templateInstanceId, outputFilePath);
    }
    
    public System.Threading.Tasks.Task RenderLowResPreviewAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string outputFilePath)
    {
        return base.Channel.RenderLowResPreviewAsync(clientId, instance, environment, key, cultureName, templateInstanceId, outputFilePath);
    }
    
    public void RenderLowResPreviewWithWaterMark(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string outputFilePath, string waterMark)
    {
        base.Channel.RenderLowResPreviewWithWaterMark(clientId, instance, environment, key, cultureName, templateInstanceId, outputFilePath, waterMark);
    }
    
    public System.Threading.Tasks.Task RenderLowResPreviewWithWaterMarkAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, string outputFilePath, string waterMark)
    {
        return base.Channel.RenderLowResPreviewWithWaterMarkAsync(clientId, instance, environment, key, cultureName, templateInstanceId, outputFilePath, waterMark);
    }
    
    public byte[] RenderZoomedPreviewFragment(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent, float percentXTranslation, float percentYTranslation, float percentageWidth, float percentageHeight)
    {
        return base.Channel.RenderZoomedPreviewFragment(clientId, instance, environment, key, cultureName, templateInstanceId, maximumWidthInPixels, maximumHeightInPixels, outlineColorRedComponent, outlineColorGreenComponent, outlineColorBlueComponent, percentXTranslation, percentYTranslation, percentageWidth, percentageHeight);
    }
    
    public System.Threading.Tasks.Task<byte[]> RenderZoomedPreviewFragmentAsync(System.Guid clientId, string instance, string environment, string key, string cultureName, System.Guid templateInstanceId, int maximumWidthInPixels, int maximumHeightInPixels, int outlineColorRedComponent, int outlineColorGreenComponent, int outlineColorBlueComponent, float percentXTranslation, float percentYTranslation, float percentageWidth, float percentageHeight)
    {
        return base.Channel.RenderZoomedPreviewFragmentAsync(clientId, instance, environment, key, cultureName, templateInstanceId, maximumWidthInPixels, maximumHeightInPixels, outlineColorRedComponent, outlineColorGreenComponent, outlineColorBlueComponent, percentXTranslation, percentYTranslation, percentageWidth, percentageHeight);
    }
    
    public string ListEnumeratedFonts()
    {
        return base.Channel.ListEnumeratedFonts();
    }
    
    public System.Threading.Tasks.Task<string> ListEnumeratedFontsAsync()
    {
        return base.Channel.ListEnumeratedFontsAsync();
    }
    
    public void PrepSwfForParse(System.Guid clientId, string instance, string environment, string key, string swfFileName)
    {
        base.Channel.PrepSwfForParse(clientId, instance, environment, key, swfFileName);
    }
    
    public System.Threading.Tasks.Task PrepSwfForParseAsync(System.Guid clientId, string instance, string environment, string key, string swfFileName)
    {
        return base.Channel.PrepSwfForParseAsync(clientId, instance, environment, key, swfFileName);
    }
    
    public void PrepZipDirectoryForParse(System.Guid clientId, string instance, string environment, string key, string zipFileName)
    {
        base.Channel.PrepZipDirectoryForParse(clientId, instance, environment, key, zipFileName);
    }
    
    public System.Threading.Tasks.Task PrepZipDirectoryForParseAsync(System.Guid clientId, string instance, string environment, string key, string zipFileName)
    {
        return base.Channel.PrepZipDirectoryForParseAsync(clientId, instance, environment, key, zipFileName);
    }
}