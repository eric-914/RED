using RenderEngineDesktop.Configuration;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Service
{
    internal class RenderEngineService : IRenderEngineService
    {
        private readonly IConfiguration _configuration;

        public RenderEngineService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void RenderLeads(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid[] leadIds,
            string outputFilePath)
            => Invoke(x => x.RenderLeads(
                clientId,
                instance,
                environment,
                key,
                leadIds,
                outputFilePath));

        public Task RenderLeadsAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid[] leadIds,
            string outputFilePath)
            => Invoke(x => x.RenderLeadsAsync(
                clientId,
                instance,
                environment,
                key,
                leadIds,
                outputFilePath));

        public void RenderOutputFiles(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string[] outputFilePaths)
            => Invoke(x => x.RenderOutputFiles(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                outputFilePaths));

        public Task RenderOutputFilesAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string[] outputFilePaths)
            => Invoke(x => x.RenderOutputFilesAsync(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                outputFilePaths));

        public void RenderOutputFilesWithWaterMark(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string[] outputFilePaths,
            string waterMark)
            => Invoke(x => x.RenderOutputFilesWithWaterMark(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                outputFilePaths,
                waterMark));

        public Task RenderOutputFilesWithWaterMarkAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string[] outputFilePaths,
            string waterMark)
            => Invoke(x => x.RenderOutputFilesWithWaterMarkAsync(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                outputFilePaths,
                waterMark));

        public string RenderPreviewHTML5(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string cultureName)
            => Invoke(x => x.RenderPreviewHTML5(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                cultureName));

        public Task<string> RenderPreviewHTML5Async(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string cultureName)
            => Invoke(x => x.RenderPreviewHTML5Async(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                cultureName));

        public byte[] RenderPreviewSwf(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            int maximumWidthInPixels,
            int maximumHeightInPixels,
            bool suppressMultimediaLinks)
            => Invoke(x => x.RenderPreviewSwf(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                maximumWidthInPixels,
                maximumHeightInPixels,
                suppressMultimediaLinks));

        public Task<byte[]> RenderPreviewSwfAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            int maximumWidthInPixels,
            int maximumHeightInPixels,
            bool suppressMultimediaLinks)
            => Invoke(x => x.RenderPreviewSwfAsync(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                maximumWidthInPixels,
                maximumHeightInPixels,
                suppressMultimediaLinks));

        public byte[] RenderPreview(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            int maximumWidthInPixels,
            int maximumHeightInPixels,
            int outlineColorRedComponent,
            int outlineColorGreenComponent,
            int outlineColorBlueComponent)
            => Invoke(x => x.RenderPreview(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                maximumWidthInPixels,
                maximumHeightInPixels,
                outlineColorRedComponent,
                outlineColorGreenComponent,
                outlineColorBlueComponent));

        public Task<byte[]> RenderPreviewAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            int maximumWidthInPixels,
            int maximumHeightInPixels,
            int outlineColorRedComponent,
            int outlineColorGreenComponent,
            int outlineColorBlueComponent)
            => Invoke(x => x.RenderPreviewAsync(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                maximumWidthInPixels,
                maximumHeightInPixels,
                outlineColorRedComponent,
                outlineColorGreenComponent,
                outlineColorBlueComponent));

        public byte[] RenderWaterMarkedPreview(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            int maximumWidthInPixels,
            int maximumHeightInPixels,
            int outlineColorRedComponent,
            int outlineColorGreenComponent,
            int outlineColorBlueComponent)
            => Invoke(x => x.RenderWaterMarkedPreview(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                maximumWidthInPixels,
                maximumHeightInPixels,
                outlineColorRedComponent,
                outlineColorGreenComponent,
                outlineColorBlueComponent));

        public Task<byte[]> RenderWaterMarkedPreviewAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            int maximumWidthInPixels,
            int maximumHeightInPixels,
            int outlineColorRedComponent,
            int outlineColorGreenComponent,
            int outlineColorBlueComponent)
            => Invoke(x => x.RenderWaterMarkedPreviewAsync(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                maximumWidthInPixels,
                maximumHeightInPixels,
                outlineColorRedComponent,
                outlineColorGreenComponent,
                outlineColorBlueComponent));

        public void RenderLowResPreview(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string outputFilePath)
            => Invoke(x => x.RenderLowResPreview(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                outputFilePath));

        public Task RenderLowResPreviewAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string outputFilePath)
            => Invoke(x => x.RenderLowResPreviewAsync(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                outputFilePath));


        public void RenderLowResPreviewWithWaterMark(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string outputFilePath,
            string waterMark)
            => Invoke(x => x.RenderLowResPreviewWithWaterMark(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                outputFilePath,
                waterMark));

        public Task RenderLowResPreviewWithWaterMarkAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string outputFilePath,
            string waterMark)
            => Invoke(x => x.RenderLowResPreviewWithWaterMarkAsync(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                outputFilePath,
                waterMark));

        public byte[] RenderZoomedPreviewFragment(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            int maximumWidthInPixels,
            int maximumHeightInPixels,
            int outlineColorRedComponent,
            int outlineColorGreenComponent,
            int outlineColorBlueComponent,
            float percentXTranslation,
            float percentYTranslation,
            float percentageWidth,
            float percentageHeight)
            => Invoke(x => x.RenderZoomedPreviewFragment(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                maximumWidthInPixels,
                maximumHeightInPixels,
                outlineColorRedComponent,
                outlineColorGreenComponent,
                outlineColorBlueComponent,
                percentXTranslation,
                percentYTranslation,
                percentageWidth,
                percentageHeight));

        public Task<byte[]> RenderZoomedPreviewFragmentAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            int maximumWidthInPixels,
            int maximumHeightInPixels,
            int outlineColorRedComponent,
            int outlineColorGreenComponent,
            int outlineColorBlueComponent,
            float percentXTranslation,
            float percentYTranslation,
            float percentageWidth,
            float percentageHeight)
            => Invoke(x => x.RenderZoomedPreviewFragmentAsync(
                clientId,
                instance,
                environment,
                key,
                templateInstanceId,
                maximumWidthInPixels,
                maximumHeightInPixels,
                outlineColorRedComponent,
                outlineColorGreenComponent,
                outlineColorBlueComponent,
                percentXTranslation,
                percentYTranslation,
                percentageWidth,
                percentageHeight));

        public string ListEnumeratedFonts()
            => Invoke(x => x.ListEnumeratedFonts());

        public Task<string> ListEnumeratedFontsAsync()
            => Invoke(x => x.ListEnumeratedFontsAsync());

        public void PrepSwfForParse(
            Guid clientId,
            string instance,
            string environment,
            string key,
            string swfFileName)
            => Invoke(x => x.PrepSwfForParse(
                clientId,
                instance,
                environment,
                key,
                swfFileName));

        public Task PrepSwfForParseAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            string swfFileName)
            => Invoke(x => x.PrepSwfForParseAsync(
                clientId,
                instance,
                environment,
                key,
                swfFileName));

        public void PrepZipDirectoryForParse(
            Guid clientId,
            string instance,
            string environment,
            string key,
            string zipFileName)
            => Invoke(x => x.PrepZipDirectoryForParse(
                clientId,
                instance,
                environment,
                key,
                zipFileName));

        public Task PrepZipDirectoryForParseAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            string zipFileName)
            => Invoke(x => x.PrepZipDirectoryForParseAsync(
                clientId,
                instance,
                environment,
                key,
                zipFileName));

        private void Invoke(Action<IRenderEngineService> invoke)
        {
            using var client = new RenderEngineServiceClient(Binding(), EndpointAddress());

            invoke(client);
        }

        private async Task Invoke(Func<IRenderEngineService, Task> invoke)
        {
            using var client = new RenderEngineServiceClient(Binding(), EndpointAddress());

            await invoke(client);
        }

        private T Invoke<T>(Func<IRenderEngineService, T> invoke)
        {
            using var client = new RenderEngineServiceClient(Binding(), EndpointAddress());

            return invoke(client);
        }

        private async Task<T> Invoke<T>(Func<IRenderEngineService, Task<T>> invoke)
        {
            using var client = new RenderEngineServiceClient(Binding(), EndpointAddress());

            return await invoke(client);
        }

        private static Binding Binding() => new NetTcpBinding();
        private EndpointAddress EndpointAddress() => new(_configuration.Model.Uri);
    }
}
