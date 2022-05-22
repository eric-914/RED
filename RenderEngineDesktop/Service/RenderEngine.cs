using RenderEngineDesktop.Models;
using RenderEngineDesktop.Models.Application;
using RenderEngineDesktop.Models.Process;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Service;

public interface IRenderEngine
{
    Task<string> ListEnumeratedFontsAsync();
    Task<string> RenderPreviewHtml5Async(RenderPreviewHtml5Model m);

    Task<byte[]> RenderPreviewAsync(RenderPreviewModel m);
    Task<byte[]> RenderWatermarkedPreviewAsync(RenderWatermarkedPreviewModel m);
    Task<byte[]> RenderZoomedPreviewFragmentAsync(RenderZoomedPreviewFragmentModel m);

    Task RenderLeadsAsync(RenderLeadsModel m);
    Task RenderLowResPreviewAsync(RenderLowResPreviewModel m);
    Task RenderLowResPreviewWithWatermarkAsync(RenderLowResPreviewWithWatermarkModel m);
    Task RenderOutputFilesAsync(RenderOutputFilesModel m);
    Task RenderOutputFilesWithWatermarkAsync(RenderOutputFilesWithWatermarkModel m);
    Task PrepZipDirectoryForParseAsync(PrepZipDirectoryForParseModel m);
}

public class RenderEngine : IRenderEngine
{
    private readonly IApplication _application;
    private readonly RES.V1.IRenderEngineService _v1;
    private readonly RES.V2.IRenderEngineService _v2;

    public RenderEngine(IApplication application, RES.V1.IRenderEngineService v1, RES.V2.IRenderEngineService v2)
    {
        _application = application;
        _v1 = v1;
        _v2 = v2;
    }

    public Task<string> ListEnumeratedFontsAsync()
    {
        var lookup = new Dictionary<ApiVersions, Func<Task<string>>>
        {
            {ApiVersions.V1, _v1.ListEnumeratedFontsAsync},
            {ApiVersions.V2, _v2.ListEnumeratedFontsAsync},
        };

        return lookup[Version]();
    }

    public Task<byte[]> RenderPreviewAsync(RenderPreviewModel m)
    {
        var lookup = new Dictionary<ApiVersions, Func<Task<byte[]>>>
        {
            {ApiVersions.V1, () => _v1.RenderPreviewAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.MaximumInPixels.Width, m.MaximumInPixels.Height, m.OutlineColorComponent.Red, m.OutlineColorComponent.Green, m.OutlineColorComponent.Blue)},
            {ApiVersions.V2, () => _v2.RenderPreviewAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Source.CultureName, m.Template.InstanceId, m.MaximumInPixels.Width, m.MaximumInPixels.Height, m.OutlineColorComponent.Red, m.OutlineColorComponent.Green, m.OutlineColorComponent.Blue)},
        };

        return lookup[Version]();
    }

    public Task RenderOutputFilesAsync(RenderOutputFilesModel m)
    {
        var lookup = new Dictionary<ApiVersions, Func<Task>>
        {
            {ApiVersions.V1, () => _v1.RenderOutputFilesAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.OutputFiles.Paths.ToArray())},
            {ApiVersions.V2, () => _v2.RenderOutputFilesAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Source.CultureName, m.Template.InstanceId, m.OutputFiles.Paths.ToArray())},
        };

        return lookup[Version]();
    }

    public Task RenderLeadsAsync(RenderLeadsModel m)
    {
        var lookup = new Dictionary<ApiVersions, Func<Task>>
        {
            {ApiVersions.V1, () => _v1.RenderLeadsAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Leads.Ids.ToArray(), m.OutputFile.Path)},
            {ApiVersions.V2, () => _v2.RenderLeadsAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Leads.Ids.ToArray(), m.OutputFile.Path)},
        };

        return lookup[Version]();
    }

    public Task RenderOutputFilesWithWatermarkAsync(RenderOutputFilesWithWatermarkModel m)
    {
        var lookup = new Dictionary<ApiVersions, Func<Task>>
        {
            {ApiVersions.V1, () => _v1.RenderOutputFilesWithWaterMarkAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.OutputFiles.Paths.ToArray(), m.Watermark.Text)},
            {ApiVersions.V2, () => _v2.RenderOutputFilesWithWaterMarkAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Source.CultureName, m.Template.InstanceId, m.OutputFiles.Paths.ToArray(), m.Watermark.Text)},
        };

        return lookup[Version]();
    }

    public Task<string> RenderPreviewHtml5Async(RenderPreviewHtml5Model m)
    {
        var lookup = new Dictionary<ApiVersions, Func<Task<string>>>
        {
            {ApiVersions.V1, () => _v1.RenderPreviewHTML5Async(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.Source.CultureName)},
            {ApiVersions.V2, () => _v2.RenderPreviewHTML5Async(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Source.CultureName, m.Template.InstanceId)},
        };

        return lookup[Version]();
    }

    public Task<byte[]> RenderWatermarkedPreviewAsync(RenderWatermarkedPreviewModel m)
    {
        var lookup = new Dictionary<ApiVersions, Func<Task<byte[]>>>
        {
            {ApiVersions.V1, () => _v1.RenderWaterMarkedPreviewAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.MaximumInPixels.Width, m.MaximumInPixels.Height, m.OutlineColorComponent.Red, m.OutlineColorComponent.Green, m.OutlineColorComponent.Blue)},
            {ApiVersions.V2, () => _v2.RenderWaterMarkedPreviewAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Source.CultureName, m.Template.InstanceId, m.MaximumInPixels.Width, m.MaximumInPixels.Height, m.OutlineColorComponent.Red, m.OutlineColorComponent.Green, m.OutlineColorComponent.Blue)},
        };

        return lookup[Version]();
    }

    public Task RenderLowResPreviewAsync(RenderLowResPreviewModel m)
    {
        var lookup = new Dictionary<ApiVersions, Func<Task>>
        {
            {ApiVersions.V1, () => _v1.RenderLowResPreviewAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.OutputFile.Path)},
            {ApiVersions.V2, () => _v2.RenderLowResPreviewAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Source.CultureName, m.Template.InstanceId, m.OutputFile.Path)},
        };

        return lookup[Version]();
    }

    public Task RenderLowResPreviewWithWatermarkAsync(RenderLowResPreviewWithWatermarkModel m)
    {
        var lookup = new Dictionary<ApiVersions, Func<Task>>
        {
            {ApiVersions.V1, () => _v1.RenderLowResPreviewWithWaterMarkAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.OutputFile.Path, m.Watermark.Text)},
            {ApiVersions.V2, () => _v2.RenderLowResPreviewWithWaterMarkAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Source.CultureName, m.Template.InstanceId, m.OutputFile.Path, m.Watermark.Text)},
        };

        return lookup[Version]();
    }

    public Task<byte[]> RenderZoomedPreviewFragmentAsync(RenderZoomedPreviewFragmentModel m)
    {
        var lookup = new Dictionary<ApiVersions, Func<Task<byte[]>>>
        {
            {ApiVersions.V1, () => _v1.RenderZoomedPreviewFragmentAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Template.InstanceId, m.MaximumInPixels.Width, m.MaximumInPixels.Height, m.OutlineColorComponent.Red, m.OutlineColorComponent.Green, m.OutlineColorComponent.Blue, m.PercentTranslation.X, m.PercentTranslation.Y, m.Percentage.Width, m.Percentage.Height)},
            {ApiVersions.V2, () => _v2.RenderZoomedPreviewFragmentAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.Source.CultureName, m.Template.InstanceId, m.MaximumInPixels.Width, m.MaximumInPixels.Height, m.OutlineColorComponent.Red, m.OutlineColorComponent.Green, m.OutlineColorComponent.Blue, m.PercentTranslation.X, m.PercentTranslation.Y, m.Percentage.Width, m.Percentage.Height)},
        };

        return lookup[Version]();
    }

    public Task PrepZipDirectoryForParseAsync(PrepZipDirectoryForParseModel m)
    {
        var lookup = new Dictionary<ApiVersions, Func<Task>>
        {
            {ApiVersions.V1, () => _v1.PrepZipDirectoryForParseAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.ZipFile.Path)},
            {ApiVersions.V2, () => _v2.PrepZipDirectoryForParseAsync(m.Source.ClientId, m.Source.Instance, m.Source.Environment, m.Source.Key, m.ZipFile.Path)},
        };

        return lookup[Version]();
    }

    private ApiVersions Version => _application.Model.ApiVersion;
}
