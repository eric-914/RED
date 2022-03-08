using Ninject;
using RenderEngineDesktop.Commands;
using RenderEngineDesktop.Models.Configuration;
using RenderEngineDesktop.Service.Parameters.Models;
using System;
using System.Windows.Input;

namespace RenderEngineDesktop.Views
{
    public abstract class BaseServiceViewModel<T> : NotifyModel
        where T : class, new()
    {
        private readonly Func<ConfigurationModel, T> _accessor = _ => new T(); //--Temporary until Inject constructed.

        private IConfiguration _configuration = new NullConfiguration();
        [Inject]
        public IConfiguration Configuration
        {
            get => _configuration;
            set
            {
                _configuration = value;

                _configuration.PropertyChanged += (_, args) =>
                {
                    if (args.PropertyName == "Model")
                    {
                        OnPropertyChanged(nameof(Model));
                    }
                };

                OnPropertyChanged(nameof(Model));
            }
        }

        public T Model => _accessor(_configuration.Model);

        public ICommand InvokeCommand { get; private set; } = new NullCommand();
        
        protected BaseServiceViewModel() { }

        protected BaseServiceViewModel(Func<ConfigurationModel, T> fn)
        {
            _accessor = fn;
        }

        protected void SetInvoke(ICommand command) => InvokeCommand = command;
    }
}
