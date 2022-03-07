using RenderEngineDesktop.IoC;
using RenderEngineDesktop.Models.Application;
using RenderEngineDesktop.Models.Logging;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace RenderEngineDesktop.Service
{
    internal class RenderEngineService : IRenderEngineService
    {
        private readonly IApplication _application;

        public RenderEngineService(IApplication application)
        {
            _application = application;
        }

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
            => throw new NotImplementedException();

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

        #region Swf/Unused

        public Task<byte[]> RenderPreviewSwfAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            int maximumWidthInPixels,
            int maximumHeightInPixels,
            bool suppressMultimediaLinks)
            => throw new Exception("Why Are You Trying To Use Swf?");

        #endregion

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

        public Task<string> ListEnumeratedFontsAsync()
            => Invoke(x => x.ListEnumeratedFontsAsync());

        #region Swf/Unused

        public Task PrepSwfForParseAsync(
            Guid clientId,
            string instance,
            string environment,
            string key,
            string swfFileName)
            => throw new Exception("Why Are You Trying To Use Swf?");

        #endregion

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

        #region Support

        private async Task Invoke(Func<IRenderEngineService, Task> invoke)
        {
            using var client = new RenderEngineServiceClient(Binding(), EndpointAddress());

            try
            {
                await invoke(client);
            }
            catch (Exception e)
            {
                Factory.Instance.Get<ILogger>().LogException(e, "RES Action");
            }
        }

        private async Task<T> Invoke<T>(Func<IRenderEngineService, Task<T>> invoke)
        {
            using var client = new RenderEngineServiceClient(Binding(), EndpointAddress());

            try
            {
                return await invoke(client);

            }
            catch (Exception e)
            {
                Factory.Instance.Get<ILogger>().LogException(e, "RES Function");

                return default!;
            }
        }

        private static Binding Binding() => new NetTcpBinding();
        private EndpointAddress EndpointAddress() => new(_application.Model.Uri);

        #endregion

        #region Synchronous API versions are not implemented.

        public void RenderLeads(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid[] leadIds,
            string outputFilePath)
            => throw new NotImplementedException();

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
            => throw new NotImplementedException();

        public string RenderPreviewHTML5(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string cultureName)
            => throw new NotImplementedException();

        public byte[] RenderPreviewSwf(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            int maximumWidthInPixels,
            int maximumHeightInPixels,
            bool suppressMultimediaLinks)
            => throw new NotImplementedException();

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
            => throw new NotImplementedException();

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
            => throw new NotImplementedException();

        public void RenderLowResPreview(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string outputFilePath)
            => throw new NotImplementedException();

        public void RenderLowResPreviewWithWaterMark(
            Guid clientId,
            string instance,
            string environment,
            string key,
            Guid templateInstanceId,
            string outputFilePath,
            string waterMark)
            => throw new NotImplementedException();

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
            => throw new NotImplementedException();

        public string ListEnumeratedFonts()
            => throw new NotImplementedException();

        public void PrepSwfForParse(
            Guid clientId,
            string instance,
            string environment,
            string key,
            string swfFileName)
            => throw new NotImplementedException();

        public void PrepZipDirectoryForParse(
            Guid clientId,
            string instance,
            string environment,
            string key,
            string zipFileName)
            => throw new NotImplementedException();

        #endregion
    }
}
