namespace EnumerableVisualizer
{
    using System.Collections.Generic;
    using System.Windows;
    using Microsoft.VisualStudio.DebuggerVisualizers;

    public class Visualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var window = new Window
            {
                Content = new View((IEnumerable<object>) objectProvider.GetObject())
            };
            window.ShowDialog();
        }
    }
}
