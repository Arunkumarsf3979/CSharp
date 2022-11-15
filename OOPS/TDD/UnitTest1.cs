namespace TDD;
[TestFixture]
public class Tests
{
    Calculator<int> operation1=null;
    Calculator<double> operation2=null;
    Calculator<string> operation3=null;
    [SetUp]
    public void Setup()
    {
        operation1=new Calculator<int>();
        operation2=new Calculator<double>();
        operation3=new Calculator<string>();
    }

    [Test]
    public void Test1()
    {
        int result=operation1.Addition(10,20);
        Assert.That(result,Is.EqualTo(30));
    }
    [TestCase(10,20,30)]
    [TestCase(1,2,3)]
    public void IsAdditionOk(int value1,int value2,int result)
    {
        int output=operation1.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
    [TestCase(1.5,2.5,4.0)]
    [TestCase(10.5,20.5,31.0)]
    public void IsAdditionOk(double value1,double value2,double result)
    {
        double output=operation2.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
    [TestCase("Ravi","Chandran","RaviChandran")]
    [TestCase("Baskaran"," Sethurajan","Baskaran Sethurajan")]
    public void IsAdditionOk(string value1,string value2,string result)
    {
        string output=operation3.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
}