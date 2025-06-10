namespace DotnetSampleApi;

public interface IGodClass { }

public class GodClass : IGodClass
{
    public void MethodA()
    {
        System.Console.WriteLine("MethodA");
    }
    public void MethodB()
    {
        System.Console.WriteLine("MethodB");
    }
    public void MethodC()
    {
        System.Console.WriteLine("MethodC");
    }
}