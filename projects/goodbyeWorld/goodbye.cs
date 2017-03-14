using System;  

class Goodbye  
{  
    static void Main()  
    {  
#if DebugConfig  
        Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");  
#endif  

        Console.WriteLine("Goodbye, world!");  
    }  
}  
