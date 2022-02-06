using Ninject;

namespace RenderEngineDesktop.IoC
{
    public interface IFactory
    {
        IFactory SelfBind();
        IFactory Bind<TInterface, TClass>() where TClass : class, TInterface;
        IFactory Singleton<TInterface, TClass>() where TClass : class, TInterface;
        IFactory Singleton<TInterface>(TInterface instance) where TInterface : class;
        TInterface Get<TInterface>();
    }

    internal class Factory : IFactory
    {
        private readonly IKernel _kernel = new StandardKernel();

        public static IFactory Instance { get; } = new Factory();

        private Factory() { }

        public IFactory SelfBind()
        {
            _kernel.Bind<IFactory>().ToMethod(_ => Instance);

            return this;
        }

        public IFactory Bind<TInterface, TClass>() where TClass : class, TInterface
        {
            _kernel.Bind<TInterface>().To<TClass>();

            return this;
        }

        public IFactory Singleton<TInterface, TClass>() where TClass : class, TInterface
        {
            _kernel.Bind<TInterface>().To<TClass>().InSingletonScope();

            return this;
        }
        public IFactory Singleton<TInterface>(TInterface instance) where TInterface : class
        {
            _kernel.Bind<TInterface>().ToConstant(instance).InSingletonScope();

            return this;
        }

        public TInterface Get<TInterface>()
        {
            return _kernel.Get<TInterface>();
        }
    }
}
