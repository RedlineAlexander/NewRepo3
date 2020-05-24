using System;
using System.Collections.Generic;
using System.Text;

namespace NewRepo3.DependencyInjectionExampleKukhar
{
    public class KukharFortuneLoader : IFortuneLoader
    {
        private IFortuneLoader _fortuneLoader;


        public KukharFortuneLoader(IFortuneLoader fortuneLoader)
        {
            _fortuneLoader = fortuneLoader;
        }
        public string LoadFortune()
        {
            throw new NotImplementedException();
        }
    }
}
