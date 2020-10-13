using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SdkMgr : MonoBehaviour {

    [SerializeField] private Button _btn = null;
    [SerializeField] private Text _text = null;
    [SerializeField] private Button _btn02 = null;
    [SerializeField] private Text _text02 = null;

    private ISdkBase _sdk = null;
    private int _count = 0;

    void Awake()
    {
        _btn.onClick.AddListener(OnClick);
        _btn02.onClick.AddListener(OnClick02);
    }

    void Start ()
    {
#if UNITY_EDITOR
        _sdk = new SdkOwn();
#elif UNITY_ANDROID
        _sdk = new SdkAndroid();
#elif UNITY_IPHONE
        _sdk = new SdkIos();
#else
        _sdk = new SdkOwn();
#endif
    }

    void OnClick () {
        Debug.Log("OnClick");
        _count++;
        _sdk.PrintLog("click" + _count);
    }

    void OnClick02()
    {
        Debug.Log("OnClick02");
        _count++;
        string str = _sdk.GetStr("click02" + _count);
        _text02.text = str;
    }

    // 接受sdk通知
    public void OnPrint(string str)
    {
        _text.text = str;
    }
}
