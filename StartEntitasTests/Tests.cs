using System;
using NUnit.Framework;

namespace StartEntitasTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Health()
        {
            var contexts = new Contexts();
            var system = new HealthSystem(contexts);
            var e = contexts.game.CreateEntity();
            e.AddHealth(10);
            
            Assert.AreEqual(10, e.health.value);
            
        }

        [Test]
        public void Bonus()
        {
            var contexts = new Contexts();
            var system = new HealthSystem(contexts);
            var e = contexts.game.CreateEntity();
            e.AddBonus(10);
            
            Assert.AreEqual(10, e.bonus.value);
        }
    }
}