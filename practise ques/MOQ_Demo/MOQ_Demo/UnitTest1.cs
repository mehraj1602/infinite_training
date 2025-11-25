namespace MOQ_Demo
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //  RealClass r = new RealClass();

            FakeClass f = new FakeClass();
            Client ob = new Client(f);
            var res = ob.AddClient(10, 20);// 

            Assert.That(res, Is.EqualTo("the sum is 30"));


        }
        [Test]
        public void Test2()
        {
            Fakecls f = new Fakecls();// which is using the list
            Client1 ob = new Client1(f);
            var res = ob.AddClient("u");// 

            Assert.That(res.Count, Is.GreaterThan(0));


        }

    }

}
