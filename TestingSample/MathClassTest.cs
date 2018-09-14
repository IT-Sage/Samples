using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSample
{
    [TestFixture]
    public class MathClassTest
    {        
        [Test]
        public void SqrtSemiPositive()
        {
            Assert.That(MathClass.Square(5), Is.GreaterThanOrEqualTo(0));
        }
        [Test]
        public void SqrtPositive()
        {
            Assert.That(MathClass.Square(-1), Is.GreaterThan(0));
        }
    }
}
