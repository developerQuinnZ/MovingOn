using System;
using System.IO;

class Test
{
    public static void Main()
    {

        DirectoryInfo Source = new DirectoryInfo(@"c:\users\student\documents\visual studio 2015\Projects\MovingOn\MovingOn\A\");
        DirectoryInfo Destination = new DirectoryInfo(@"c:\users\student\documents\visual studio 2015\Projects\MovingOn\MovingOn\B\");
        foreach (var File in Source.EnumerateFiles())
        {
            if (isLessThanDayOld(File.LastWriteTime))
            {
                File.CopyTo((Destination + File.Name));
            }
        }

    }
    public static bool isLessThanDayOld(DateTime LastMod)
    {

        var IGetMoved = DateTime.Now.AddDays(1);

        
        DateTime TooOld = DateTime.Now.AddDays(-1);
        
        



        return LastMod > TooOld;
    }

}