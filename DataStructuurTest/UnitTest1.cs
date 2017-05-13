using System;
using DataStructuur;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuurTest
{
    [TestClass]
    public class UnitTest1
    {
        private Systeem s;
        private Item taak;
        private Item reden;

        [TestInitialize]
        public void Initialize()
        {
            s = new Systeem();

            taak = new Item();
            taak.Titel = "bel makelaar";
            taak.IsActionable = true;

            reden = new Item();
            reden.Titel = "huis verkopen";

            taak.Reason = reden;

            s.AddItem(taak);
            s.AddItem(reden);
        }

        [TestMethod]
        public void Test_BasisToevoegenVanTakenAanSysteem()
        {
            Console.Write(s.ToString());

            Assert.AreEqual<int>(2, s.Items.Count, "Verwachten nu 2 items");        
        }

        [TestMethod]
        public void Test_TopLevelItems()
        {
            Assert.AreEqual<int>(1, s.ToplevelItems().Count, "Verwacht 1 tli");
            Console.Write(s.ToplevelItems()[0].ToString());
        }

        [TestMethod]
        public void Test_NextActions()
        {
            Assert.AreEqual<int>(1, s.NextActions().Count, "Verwacht 1 next action");
            Console.Write(s.NextActions()[0].ToString());
        }
    }
}
