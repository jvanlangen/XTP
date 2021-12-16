using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System;
using System.Reflection.Metadata;

namespace AvaloniaApplication1
{
    public class MainWindow : Window
    {
        private readonly Workspace _workspace1;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            _workspace1 = this.FindControl<Workspace>("Workspace1");


            CreateBlock();
            CreateBlock();
            CreateBlock();
            CreateBlock();
            CreateBlock();

        }

        private void CreateBlock()
        {


            var block = new Block();

            Canvas.SetTop(block, 300);
            Canvas.SetLeft(block, 500);

            _workspace1.AddControl(block);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
           
        }
    }
}
