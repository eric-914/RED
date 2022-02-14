using System;
using System.Windows;

namespace RenderEngineDesktop.Controls
{
    /// <summary>
    /// A wrapper around the WebBrowser control to behave more like a WPF control with binding to HTML text
    /// </summary>
    public partial class HtmlViewer
    {
        public const string EmptyDocument = @"
<html>
<head></head>
<body bgcolor=""lightgray"">
No HTML document rendered.
</body>
</html>
";

        public static readonly DependencyProperty HtmlProperty
            = DependencyProperty.Register("Html", typeof(string), typeof(HtmlViewer));

        public static readonly DependencyProperty UrlProperty
            = DependencyProperty.Register("Url", typeof(string), typeof(HtmlViewer));

        private string _html = "about:blank";
        private string _url = "about:blank";

        public HtmlViewer()
        {
            InitializeComponent();
        }

        public string Html
        {
            get => (string)GetValue(HtmlProperty);
            set => SetValue(HtmlProperty, value);
        }

        public string Url
        {
            get => (string)GetValue(UrlProperty);
            set => SetValue(UrlProperty, value);
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            if (e.Property == HtmlProperty)
            {
                SetDocument(Html);
            }
            else if (e.Property == UrlProperty)
            {
                SetUrl(Url);
            }
        }

        private void SetDocument(string html)
        {
            if (string.IsNullOrEmpty(html) || html == _html) return;

            _html = html;
            Browser.NavigateToString(_html);
        }

        private void SetUrl(string url)
        {
            if (string.IsNullOrEmpty(url) || url == _url) return;

            _url = url;
            Browser.Navigate(new Uri(url));
        }
    }
}
