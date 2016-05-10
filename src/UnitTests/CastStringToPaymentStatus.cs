using System;
using StringToEnum.Enums;
using NUnit.Framework;
using StringToEnum.ExtensionMethods;

namespace UnitTests
{
    public class CastStringToPaymentStatus
    {
        [Test]
        public void ReturnsSubmittedStatus_GivenSubmittedAsString()
        {
            var statusAsString = "Submitted";
            PaymentStatus resultOfCast = (PaymentStatus)Enum.Parse(typeof(PaymentStatus), statusAsString);

            Assert.AreEqual(PaymentStatus.Submitted, resultOfCast);
        }

        [Test]
        public void ReturnsSubmittedStatus_UsingTryParse()
        {
            var statusAsString = "Submitted";
            PaymentStatus resultOfCast = (PaymentStatus)Enum.Parse(typeof(PaymentStatus), statusAsString);

            Assert.AreEqual(PaymentStatus.Submitted, resultOfCast);
        }

        [Test]
        public void ReturnsSubmittedStatus_WhenUsingExtentionMethod()
        {
            var statusAsString = "Submitted";
            var resultOfUsingExtensionMethod = statusAsString.ToEnum<PaymentStatus>();

            Assert.AreEqual(PaymentStatus.Submitted, resultOfUsingExtensionMethod);
        }


    }
}
