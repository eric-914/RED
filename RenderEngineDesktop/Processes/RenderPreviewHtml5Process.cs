﻿using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.Service;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace RenderEngineDesktop.Processes
{
    public class RenderPreviewHtml5Process : IAsyncFunction<string>
    {
        private readonly IConfiguration _configuration;
        private readonly IRenderEngine _re;

        /// <summary>
        /// Callback on complete
        /// </summary>
        public Action<string> OnComplete { get; set; } = _ => { };

        public RenderPreviewHtml5Process(IConfiguration configuration, IRenderEngine re)
        {
            _configuration = configuration;
            _re = re;
        }

        public async Task<string> Invoke()
        {
            try
            {
                return await _re.RenderPreviewHtml5Async(_configuration.Model.RenderPreviewHtml5);
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected connection failure");
                throw;
            }
        }

        public void InvokeComplete(string result)
        {
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("No HTML data returned");
                return;
            }

            var path = DocumentPath(result);

            //OnComplete(ConvertToHtmlLink(result));
            OnComplete(path);
        }

        public string DocumentPath(string file)
        {
            var root = _configuration.Model.AssetPath.Root.Path;
            var folder = _configuration.Model.RenderPreviewHtml5.Source.ClientId.ToString();

            return Path.Combine(root, folder, file);
        }

        public string ConvertToHtmlLink(string file)
        {
            var path = DocumentPath(file);

            var html = $@"
<html>
<head></head>
<body>
<a href = ""{path}"" target=""_blank"">{file}</a>
<a href = ""https://www.bing.com"">Bing</a>
</body>
</html>
";

            return html;
        }
    }
}