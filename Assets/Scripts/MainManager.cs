using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public static MainManager instance = null;
    public float now_time;
    public int RNA_num = 0;
    public int DNA_num = 0;
    public Text DNAText;
    int display_flag = 0;
    
    private void Awake(){
        if(instance==null){
            instance = this;
            //DontDestroyOnLoad(this.gameObject);
        }else{
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        now_time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        now_time += Time.deltaTime;
        if(display_flag==0){
            DisplayDNA();
        }else if(RNA_num!=0 && DNA_num==RNA_num){
            GameOver("CLEAR","SCORE:"+now_time.ToString("F4")+"s");
        }else if(RNA_num!=0 && DNA_num!=RNA_num){
            GameOver("GAME OVER","PLEASE RETRY");
        }
    }

    public void GameOver(string result_text,string result_score){
        DataSender.result_text = result_text;
        DataSender.result_score = result_score;
        SceneManager.LoadScene("Result");
    }

    private void DisplayDNA(){
        DNA_num = Random.Range(1,5);
        switch(DNA_num){
            case 1:
            DNAText.text = "A";
            break;

            case 2:
            DNAText.text = "C";
            break;

            case 3:
            DNAText.text = "G";
            break;

            case 4:
            DNAText.text = "T";
            break;
        }
        display_flag  = 1;
    }
}
