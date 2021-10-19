using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RNA : MonoBehaviour
{
    public Text RNAText;
    private bool firstPush = false;

    public void pressA(){
        if(!firstPush){
            Debug.Log("press A");
            RNAText.text = "A";
            firstPush = true;
            MainManager.instance.RNA_num = 4;
        }
    }

    public void pressC(){
        if(!firstPush){
            Debug.Log("press C");
            RNAText.text = "C";
            firstPush = true;
            MainManager.instance.RNA_num = 3;
        }
    }

    public void pressG(){
        if(!firstPush){
            Debug.Log("press G");
            RNAText.text = "G";
            firstPush = true;
            MainManager.instance.RNA_num = 2;
        }
    }

    public void pressU(){
        if(!firstPush){
            Debug.Log("press U");
            RNAText.text = "U";
            firstPush = true;
            MainManager.instance.RNA_num = 1;
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
