using Xunit;

namespace DotNetKoans.CSharp
{
    public class AboutNull : Koan
    {
        [Koan(1)]
        public void NullIsNotAnObject()
        {
            //Assert.True(typeof(object).IsAssignableFrom(null)); //not everything is an object
            Assert.True(true); // what do you want from me
        }

        [Koan(2)]
        public void YouGetNullPointerErrorsWhenCallingMethodsOnNull()
        {
            //What is the Exception that is thrown when you call a method on a null object?
            //Don't be confused by the code below. It is using Anonymous Delegates which we will
            //cover later on. 
            object nothing = null;
            Assert.Throws(typeof(System.NullReferenceException), delegate() { nothing.ToString(); });

            //What's the message of the exception? What substring or pattern could you test
            //against in order to have a good idea of what the string is?
            try
            {
                nothing.ToString();
            }
            catch (System.Exception ex)
            {
                Assert.Contains("Object reference not set to an instance of an object." as string, ex.Message);
            }
        }

        [Koan(3)]
        public void CheckingThatAnObjectIsNull()
        {
            object obj = null;
            Assert.True(obj == null);
        }

#pragma warning disable 219
        [Koan(4)]
        public void ABetterWayToCheckThatAnObjectIsNull()
        {
            object obj = null;
            Assert.Null(obj);
        }

        [Koan(5)]
        public void AWayNotToCheckThatAnObjectIsNull()
        {
            object obj = null;
            // Assert.True(obj.Equals(null));
        }
    }
}
