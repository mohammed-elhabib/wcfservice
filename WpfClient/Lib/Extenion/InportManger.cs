using MefAction.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfClient.Lib.Extenion
{
    public class InportManger
    {
        [ImportMany]
        public IEnumerable<IExtention> ExtenionList { get; set; }

        // AggregateCatalog armazena os catÃ¡logos do MEF 
        AggregateCatalog catalog = new AggregateCatalog();

        public InportManger()
        {

            var extensionsDir = GetConFiguretionPath();
            catalog.Catalogs.Add(new DirectoryCatalog(extensionsDir, "*.dll"));

            CompositionContainer cc = new CompositionContainer(catalog);

            cc.ComposeParts(this);

        }

        private string GetConFiguretionPath()
        {
            /**   Configuration PluginConfig =
              ConfigurationManager.OpenExeConfiguration(
                                      this.GetType().Assembly.Location);
               AppSettingsSection PluginConfigAppSettings =
               (AppSettingsSection)PluginConfig.GetSection("appSettings");
               // retorna o valor da chave PluginPath
               return PluginConfigAppSettings.Settings["ExtenionPath"].Value;*/
            return "C:\\Users\\habib\\Desktop\\app";
        }
    }
}
