using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public static MainManager instance = null;
    public float now_time;
    public int[] DNA_num = new int[3];
    public int[] RNA_num = new int[3];
    public Text DNAText;
    public Text DNAText1;
    public Text DNAText2;
    int display_flag = 0;
    bool judge_flag = true;
    int stage_num=2;
    
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
        }else{
            for(int i=0;i<3;i++){
                if(RNA_num[i]!=0){
                    if(!Judge(i)){
                        GameOver("GAME OVER","PLEASE RETRY");
                    }
                }
            }
            if(RNA_num[0]*RNA_num[1]*RNA_num[2]!=0){
                if(stage_num>0){
                    RNA_num[0] = 0;
                    RNA_num[1] = 0;
                    RNA_num[2] = 0;
                    display_flag = 0;
                    stage_num--;
                }else{
                    GameOver("CLEAR","SCORE:"+now_time.ToString("F4")+"s");
                }
            }
        }
    }

    public void GameOver(string result_text,string result_score){
        DataSender.result_text = result_text;
        DataSender.result_score = result_score;
        SceneManager.LoadScene("Result");
    }

    private void DisplayDNA(){
        do{
            DNA_num[0] = Random.Range(1,5);
            DNA_num[1] = Random.Range(1,5);
            DNA_num[2] = Random.Range(1,5);
        }while(!final());

        if(stage_num==2){
            DNA_num[0] = 4;
            DNA_num[1] = 1;
            DNA_num[2] = 2;
            /* RNA = AUG*/
        }

        if(stage_num==0){
            int final_num = Random.Range(1,4);
            switch(final_num){
                case 1:
                DNA_num[0]=1;
                DNA_num[1]=4;
                DNA_num[2]=4;
                break;

                case 2:
                DNA_num[0]=1;
                DNA_num[1]=4;
                DNA_num[2]=2;
                break;

                case 3:
                DNA_num[0]=1;
                DNA_num[1]=2;
                DNA_num[2]=4;
                break;
            }
        }
        switch(DNA_num[0]){
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
        switch(DNA_num[1]){
            case 1:
            DNAText1.text = "A";
            break;

            case 2:
            DNAText1.text = "C";
            break;

            case 3:
            DNAText1.text = "G";
            break;

            case 4:
            DNAText1.text = "T";
            break;
        }
        switch(DNA_num[2]){
            case 1:
            DNAText2.text = "A";
            break;

            case 2:
            DNAText2.text = "C";
            break;

            case 3:
            DNAText2.text = "G";
            break;

            case 4:
            DNAText2.text = "T";
            break;
        }  
        display_flag  = 1;
    }

    private bool Judge(int i){
        if(RNA_num[i]!=DNA_num[i]){
            return false;
        }else{
            return true;
        }
    }

    private bool final(){
        if(DNA_num[0]==1&&DNA_num[1]==4&&DNA_num[2]==4){
            return false;
            /* RNA = UAA*/
        }else if(DNA_num[0]==1&&DNA_num[1]==4&&DNA_num[2]==2){
            return false;
            /* RNA = UAG*/
        }else if(DNA_num[0]==1&&DNA_num[1]==2&&DNA_num[2]==4){
            return false;
            /* RNA = UGA*/
        }else{
            return true;
        }
    }
}
