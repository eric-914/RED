using System.Windows.Controls;
using System.Windows.Data;

namespace RenderEngineDesktop.Controls
{
    /// <summary>
    /// To use:
    /// <list type="table">
    ///   <item>
    ///     <term>Change</term>
    ///     <description><c>&lt;UserControl x:Class...</c></description>
    ///   </item>
    ///   <item>
    ///     <term>To</term>
    ///     <description><c>&lt;controls:ContextControl x:Class...</c></description>
    ///   </item>
    /// </list>
    /// </summary>
    public class ContextControl : UserControl
    {
        //TODO: Figure out why this just can't be the DataContext itself
        public Binding Context
        {
            set
            {
                SetBinding(DataContextProperty, value);
            }
        }

        public object Model
        {
            set
            {

            }
        }
    }
}
