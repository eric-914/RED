using Newtonsoft.Json;
using RenderEngineDesktop.Dialogs;
using RenderEngineDesktop.IoC;
using System;
using System.IO;

namespace RenderEngineDesktop.Support
{
    public interface IPersistence<T>
    {
        public T Load(string path);
        public void Save(string path, T model);
    }

    public abstract class Persistence<T> : IPersistence<T>
    {
        private readonly IFactory _factory;

        protected Persistence(IFactory factory)
        {
            _factory = factory;
        }

        public T Load(string path) => Load(_factory.Get<T>(), path);

        private T Load(T instance, string path)
        {
            try
            {
                if (instance == null) throw new InvalidOperationException();

                if (File.Exists(path))
                {
                    JsonConvert.PopulateObject(File.ReadAllText(path), instance);
                }

                return instance;

                //return JsonConvert.DeserializeAnonymousType(File.ReadAllText(path), instance)
                //    ?? throw new InvalidOperationException();
            }
            catch (Exception e)
            {
                _factory.Get<IDialogManager>()
                    .ShowPathError(e, path,
                        "An error occurred while trying to read file:",
                        "Loading as default.");

                return instance;
            }
        }

        public void Save(string path, T model)
        {
            try
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(model, Formatting.Indented));
            }
            catch (Exception e)
            {
                _factory.Get<IDialogManager>()
                    .ShowPathError(e, path,
                        "An error occurred while trying to save file:");
            }
        }
    }
}
