using System;
using System.Collections.Generic;
using System.Text;

namespace NewRepo3.DependencyInjectionExampleKukhar
{
    public class KukharFortuneGetter : IFortuneGetter
    {
        private IFortuneLoader _fortuneLoader;
        public KukharFortuneGetter(IFortuneLoader fortuneLoader)
        {
            _fortuneLoader = fortuneLoader;
        }
        public void GetterFortune()
        {
            //throw new NotImplementedException();
        }
    }
}
