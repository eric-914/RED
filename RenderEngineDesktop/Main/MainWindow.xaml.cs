﻿using RenderEngineDesktop.Configuration;
using RenderEngineDesktop.IoC;
using System.Windows;

namespace RenderEngineDesktop.Main
{
    public interface IMainWindow
    {
        Window Window { get; }
    }

    public partial class MainWindow : IMainWindow
    {
        public Window Window => this;

        public MainWindow()
        {
            var factory = Factory.Instance;

            factory.Singleton<IMainWindow>(this);
           
            InitializeComponent();

            var configuration = factory.Get<IConfiguration>();
            
            configuration.Load();
            Window.Closed += (_, _) => configuration.Save();

            DataContext = factory.Get<MainViewModel>();
        }
    }
}
