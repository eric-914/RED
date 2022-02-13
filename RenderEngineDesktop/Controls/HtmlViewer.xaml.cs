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

        private string _document = "about:blank";

        public HtmlViewer()
        {
            InitializeComponent();
        }

        public string Html
        {
            get => (string)GetValue(HtmlProperty);
            set => SetValue(HtmlProperty, value);
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            if (e.Property == HtmlProperty)
            {
                SetDocument(Html);
            }
        }

        private void SetDocument(string html)
        {
            if (string.IsNullOrEmpty(html) || html == _document) return;

            _document = html;
            Browser.NavigateToString(_document);
        }
    }
}
