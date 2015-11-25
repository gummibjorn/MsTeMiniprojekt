using AutoReservation.TestEnvironment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoReservation.BusinessLayer.Testing
{
    [TestClass]
    public class BusinessLayerTest
    {
        private AutoReservationBusinessComponent target;
        private AutoReservationBusinessComponent Target
        {
            get
            {
                if (target == null)
                {
                    target = new AutoReservationBusinessComponent();
                }
                return target;
            }
        }


        [TestInitialize]
        public void InitializeTestData()
        {
            TestEnvironmentHelper.InitializeTestData();
        }
        
        [TestMethod]
        public void Test_UpdateAuto()
        {
            const string marke = "Test Marke";
            const int id = 1;

            var originalAuto = Target.GetAuto(id);
            var modifiedAuto = Target.GetAuto(id);

            modifiedAuto.Marke = marke;
            Target.UpdateAuto(modifiedAuto, originalAuto);

            var modifiedObjectInList = Target.GetAuto(id);
            Assert.AreEqual(marke, modifiedObjectInList.Marke);
        }

        [TestMethod]
        public void Test_UpdateKunde()
        {
            const string nachname = "Test Nachname";
            const int id = 1;

            var originalKunde = Target.GetKunde(id);
            var modifiedKunde = Target.GetKunde(id);

            modifiedKunde.Nachname = nachname;
            Target.UpdateKunden(modifiedKunde, originalKunde);

            var modifiedObjectInList = Target.GetKunde(id);
            Assert.AreEqual(nachname, modifiedObjectInList.Nachname);
        }

        [TestMethod]
        public void Test_UpdateReservation()
        {
            System.DateTime bis = System.DateTime.Parse("1.2.3456 12:34");
            const int id = 1;

            var originalReservation = Target.GetReservation(id);
            var modifiedReservation = Target.GetReservation(id);

            modifiedReservation.Bis = bis;
            Target.UpdateReservation(modifiedReservation, originalReservation);

            var modifiedObjectInList = Target.GetReservation(id);
            Assert.AreEqual(bis, modifiedObjectInList.Bis);
        }
    }
}
