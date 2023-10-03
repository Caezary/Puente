using System.Runtime.InteropServices;

namespace PuenteAot;

public static class Server
{
    [UnmanagedCallersOnly(EntryPoint = "addNumbers")]
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}

