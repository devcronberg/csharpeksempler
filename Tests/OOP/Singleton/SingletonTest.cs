using CSharpEksempler.OOP.Singleton;

using Xunit;

namespace CSharpEksempler.Tests.OOP.Singleton
{
    public class SingletonTest
    {
        [Fact]
        public void Should_be_same_instance()
        {
            Logger log1 = Logger.Instance;
            Logger log2 = Logger.Instance;
            // Same instance
            Assert.True(ReferenceEquals(log1, log2));
        }
    }
}
