using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace RenderEngineDesktop.Views.Logging;

/// <summary>
/// A helper to convert a Binding into a FlowDocument
/// </summary>
/// <see href="https://stackoverflow.com/questions/343468/richtextbox-wpf-binding"/>
public class RichTextBoxHelper : DependencyObject
{
    public static FlowDocument GetDocumentXaml(DependencyObject o)
    {
        return (FlowDocument)o.GetValue(DocumentXamlProperty);
    }

    public static void SetDocumentXaml(DependencyObject o, FlowDocument value)
    {
        o.SetValue(DocumentXamlProperty, value);
    }

    public static readonly DependencyProperty DocumentXamlProperty =
        DependencyProperty.RegisterAttached(
            "DocumentXaml",
            typeof(FlowDocument),
            typeof(RichTextBoxHelper),
            new FrameworkPropertyMetadata
            {
                BindsTwoWayByDefault = true,
                PropertyChangedCallback = (o, _) =>
                {
                    if (o is RichTextBox rtb)
                    {
                        rtb.Document = GetDocumentXaml(rtb) ?? new FlowDocument();
                    }
                }
            });
}