using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public Text ResultText;
    public Text ResultScore;
    // Start is called before the first frame update
    void Start()
    {
        ResultText.text = DataSender.result_text;
        if(DataSender.clear_flag==1){
            ResultScore.text  = "SCORE:"+DataSender.result_score+"s";
        }else{
            ResultScore.text  = DataSender.result_score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
