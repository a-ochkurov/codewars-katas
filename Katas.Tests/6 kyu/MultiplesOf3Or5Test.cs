using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  public void Test()
  {
    Assert.AreEqual(23, MultiplesOf3Or5.Solution(10));
  }
}
