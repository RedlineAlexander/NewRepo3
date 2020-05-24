using System;
using System.Collections.Generic;
using System.Text;

namespace NewRepo3.DependencyInjectionExampleKukhar
{
    public interface IFortuneFacade
    {
        public void FortuneFacade();
        //5)IFortuneFacade должен содержать два метода, 
//6)которые будут выводить или возвращать предсказание из IFortuneTeller
//7)и IFortuneGetter соответственно.
        public string FortuneTeller();
        public string FortuneGetter();
    }
}
