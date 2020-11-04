using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace HultasBilverkstad.test
{
    public class HultgrensBilverkstadTestConfiguration
    {
        
        public ChromeBrowserDriverConfiguration ChromeBrowserDriver { get; private set; } = new ChromeBrowserDriverConfiguration();

        public ServiceHostConfiguration ServiceHost { get; private set; } = new ServiceHostConfiguration();

       

        public HultgrensBilverkstadTestConfiguration()
        {
            var config = new ConfigurationBuilder()
                                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                                    .Build();

            config.GetSection("chromeBrowserDriver").Bind(ChromeBrowserDriver);
            config.GetSection("serviceHost").Bind(ServiceHost);

           
        }
    }

    public class ChromeBrowserDriverConfiguration
    {
        public string[] ChromeOptions { get; set; }
    }

    public class ServiceHostConfiguration
    {
        public string Name { get; set; }
        public string Port { get; set; }
    }

    public class TestData
    {
        public RowItem[] rowItems;
    }

    public class RowItem
    {
        internal RowItem() { }
        public RowItem(string id, string name)
        {
            Id = id;
            Name = name;
        }
        public string Id { get; set; }
        public string Name { get; set; }
    }

}
