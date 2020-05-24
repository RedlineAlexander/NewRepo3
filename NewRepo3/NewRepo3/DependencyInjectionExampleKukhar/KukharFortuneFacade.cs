using System;
using System.Collections.Generic;
using System.Text;

namespace NewRepo3.DependencyInjectionExampleKukhar
{
   public class KukharFortuneFacade : IFortuneFacade
    {
        private IFortuneLoader _fortuneLoader;

        private IFortuneGetter _fortuneGetter;
        public KukharFortuneFacade(IFortuneLoader fortuneLoader, IFortuneGetter fortuneGetter)
        {
            _fortuneLoader = fortuneLoader;
            _fortuneGetter = fortuneGetter;
        }


        public void FortuneFacade()
        {
            //throw new NotImplementedException();
        }
    }
}
