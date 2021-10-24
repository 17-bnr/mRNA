using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tweet : MonoBehaviour
{
    private bool firstPush = false;
    // 各種パラメーターはインスペクターから設定する
    //public Button tweetButton;                        // ツイートするボタン
    public string text;    // ツイートに挿入するテキスト
    public string linkUrl;   // ツイートに挿入するURL
    public string hashtags;        // ツイートに挿入するハッシュタグ

    // ツイート画面を開く
    private void Tweeting (int clear_flag)
    {
        if(clear_flag==1){
            text = "「mRNA GAME」を"+DataSender.result_score+"秒でクリアしました！";
        }else{
            text = "「mRNA GAME」にチャレンジしたよ！";
        }
        linkUrl = "https://blog.rogiken.org/";
        hashtags = "rogy,工大祭2021";
        var url = "https://twitter.com/intent/tweet?"
            + "text=" + text
            + "&url=" + linkUrl
            + "&hashtags=" + hashtags;

        Application.OpenURL ( url );
    }

    public void TweetButton(){
        Debug.Log("press tweet");
        
        if(!firstPush){
            Debug.Log("tweet");
            firstPush = true;
            Tweeting(DataSender.clear_flag);
        }
    }

    void FixedUpdate(){

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
