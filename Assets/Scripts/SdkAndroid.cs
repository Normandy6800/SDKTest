using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SdkAndroid : ISdkBase 
{
    private AndroidJavaClass _jc;
    private AndroidJavaObject _jo;


    public SdkAndroid()
    {
        _jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        _jo = _jc.GetStatic<AndroidJavaObject>("currentActivity");
    }

    public void PrintLog(string args)
    {
        _jo.Call("PrintLog", args);
    }

    public string GetStr(string args)
    {
        string s = _jo.Call<string>("GetStr", args);
        return s;
    }

    public void OnPrint(string args)
    {

    }
}
