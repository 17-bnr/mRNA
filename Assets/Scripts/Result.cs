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
        ResultScore.text  = DataSender.result_score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
