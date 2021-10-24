using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using System.Runtime.InteropServices;   // DllImportを使うために必要

public class ReturnTitle : MonoBehaviour
{
     /*   // 新しいタブでURLを開く
    #if !UNITY_EDITOR && UNITY_WEBGL
        // WebGLビルドで有効になる
        [DllImport("__Internal")]
        private static extern void OpenNewTab(string url);
    #else
        // UnityエディタやWebGL以外のプラットフォームで有効になる
        private static void OpenNewTab(string url) => Application.OpenURL(url);
    #endif*/
        private bool firstPush = false;

    public void PressReturn(){
        Debug.Log("Press Start");

        if(!firstPush){
            Debug.Log("Go Next Scene");
            firstPush = true;
            //OpenNewTab("https://twitter.com/home");
            SceneManager.LoadScene("Title");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
