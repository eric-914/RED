namespace RenderEngineDesktop.Models.Macros
{
    public class MacroState
    {
        public string Message { get; set; } = "(macro state)";
        public MacroStates State { get; set; } = MacroStates.None;
    }
}
