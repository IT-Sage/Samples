using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class ClassWithEventChild : ClassWithEvent
    {
        public ClassWithEventChild()
        {
            Age += ShowAge;            
        }

        internal void RaiseAge()
        {
            OnAge(30, "John");
        }

        protected override void OnAge(int age, string name)
        {
            base.OnAge(age, name);
            Console.WriteLine("called from " + this);
        }

        private void ShowAge(int age, string name)
        {
            Console.WriteLine(name + " is " + age);
        }
    }
}
