using Oxide.Core;
using Oxide.Core.Extensions;
using Oxide.Core.Logging;
using Oxide.Core.Plugins;
using Oxide.Ext.ExampleExtension.Libraries;

namespace Oxide.Ext.ExampleExtension
{
    public class ExampleExtension : Extension
    {
        public ExampleExtension(ExtensionManager manager) : base(manager)
        {
            _logger = manager.Logger;
        }

        public override string Name => "ExampleExtension";
        public override string Author => "John Doe";
        public override VersionNumber Version => new VersionNumber(6, 9, 0);
        
        private Logger _logger;
        
        /// <summary>
        /// Called when the extension is created by the extension manager
        /// </summary>
        public override void Load()
        {
            _logger.Write(LogType.Info, "ExampleExtension: Load()");
        }

        
        /// <summary>
        /// Called when the extension is unloaded by the extension manager
        /// </summary>
        public override void Unload()
        {
            _logger.Write(LogType.Info, "ExampleExtension: Unload()");
        }
        
        /// <summary>
        /// Called when a mod is loaded from extension manager
        /// </summary>
        public override void OnModLoad()
        {
            _logger.Write(LogType.Error, "ExampleExtension: OnModLoad()");
            // Register a library with the extension manager
            Manager.RegisterLibrary(nameof(ExampleLibrary), new ExampleLibrary());
        }

        /// <summary>
        /// Called when the server is shutting down
        /// </summary>
        public override void OnShutdown()
        {
            _logger.Write(LogType.Warning, "ExampleExtension: OnShutdown()");
        }
    }
}