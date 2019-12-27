using defaultGenerateDuiBi.DAL;
using defaultGenerateDuiBi.Model.Context;
using NUnit.Framework;

namespace defaultGenerateTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            StudentDAL studentDal = new StudentDAL();
            studentDal.GetStudent();
            
            //Assert.Pass();
        }
    }
}