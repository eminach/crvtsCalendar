using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using crvtsCalendar.Controllers;
using crvtsCalendar.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class AppointmentControllerTest
    {
        [TestMethod]
        public void TestDetailsPartial()
        {
            var controller = new AppointmentsController();
            var result = controller.AppointDetailsParital(2) as PartialViewResult;
            var appointment = (Appointment)result.ViewData.Model;
            Assert.IsNotNull(appointment);
        }
    }
}
