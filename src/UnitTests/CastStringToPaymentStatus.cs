using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringToEnum.Enums;
using NUnit.Framework;

namespace UnitTests
{
    public class CastStringToPaymentStatus
    {
        public void ReturnsSubmittedStatus_GivenSubmittedAsString()
        {
            var statusAsString = "Submitted";
            PaymentStatus resultOfCast = (PaymentStatus)Enum.Parse(typeof(PaymentStatus), statusAsString);

            Assert.AreEqual(PaymentStatus.Submitted, resultOfCast);
        }
    }
}
