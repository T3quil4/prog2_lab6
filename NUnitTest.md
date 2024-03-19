using prog2_lab6;

namespace NUnitTest
{
    public class Tests
    {

        [TestCase(true)]
        [TestCase(false)]
        public void TestEnvelopeCalculatePrice(bool fromLocker)
        {
            Envelope envelope = new Envelope("DESC", 1000, "Haris Miki");
            Assert.That(envelope.CalculatePrice(fromLocker),Is.EqualTo(1000));
        }

        [Test]
        public void TestEnvelopeOverWeight()
        {
            Envelope envelope = new Envelope("DESC", 2400, "Haris Miki");
            Assert.That(()=> envelope.CalculatePrice(true),Throws.TypeOf<OverweightException>());
        }

        [Test]
        public void TestFragileParcelFromLocker()
        {
            FragileParcel fragileparcel = new FragileParcel(Parcel.OrientationType.Horizontal,3400,"OE");
            Assert.That(() => fragileparcel.CalculatePrice(true), Throws.TypeOf<DeliveryException>());
        }

        [Test]
        public void TestFragileParcelIncorrectOrientation()
        {
            Assert.That(() => new FragileParcel(Parcel.OrientationType.Arbitrary,3400,"OE"),
                Throws.TypeOf<IncorrectOrientiationException>());
        }

        [Test]
        public void TestCourierPickUpItem()
        {
            Courier courier = new Courier(1);
            FragileParcel fragileparcel = new FragileParcel(Parcel.OrientationType.Horizontal, 3400, "OE");
            courier.PickUpItem(fragileparcel);
            Assert.That(courier.sumOfWeights, Is.EqualTo(3400));
        }

        [Test]
        public void TestCourierFragileSorted()
        {
            Courier courier = new Courier(3);
            FragileParcel fragileparcel1 = new FragileParcel(Parcel.OrientationType.Horizontal, 4000, "OE-NIK");
            FragileParcel fragileparcel2 = new FragileParcel(Parcel.OrientationType.Vertical, 3400, "OE-KVK");
            Envelope envelope = new Envelope("DESC", 1000, "Haris Miki");
            courier.PickUpItem(fragileparcel1);
            courier.PickUpItem(envelope);
            courier.PickUpItem(fragileparcel2);

            IDeliverable[] expected = new IDeliverable[] { null, fragileparcel2, fragileparcel1};

            Assert.That(courier.FragilesSorted(),Is.EquivalentTo(expected));
        }

    }
}
