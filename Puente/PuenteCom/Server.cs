using System.Runtime.InteropServices;

namespace PuenteCom;

[ComVisible(true)]
[Guid("b022d7ea-1dfb-4911-9d53-a26bc8fc9674")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
public interface IServer
{
    int AddNumbers(int a, int b);
}

[ComVisible(true)]
[Guid("af900b10-ff4b-41e6-9d1b-8f95d6d7d3bb")]
public class Server : IServer
{
    public int AddNumbers(int a, int b)
    {
        return a + b;
    }
}