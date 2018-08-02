using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class ClassWithEvent
    {        
        public ClassWithEvent()
        {
            
        }
        
        protected virtual void OnAge(int age, string name)
        {
            //longer version
            //if (Age != null)
            //{
            //    Age(age, name);
            //}
            Age?.Invoke(age, name);
        }        

        public event Action<int,string> Age;        
    }
}
