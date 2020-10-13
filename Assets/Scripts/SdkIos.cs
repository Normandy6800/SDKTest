using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SdkIos : ISdkBase
{
    [DllImport("__Internal")] public static extern void printLog(string args);
    [DllImport("__Internal")] public static extern string getStr(string args);


    public void PrintLog(string args)
    {
        printLog(args);
    }

    public string GetStr(string args)
    {
        return getStr(args);
    }

    public void OnPrint(string args)
    {

    }
}
