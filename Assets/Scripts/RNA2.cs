using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RNA2 : MonoBehaviour
{
    public Text RNAText2;
    private bool firstPush = false;

    public void pressA(){
        if(!firstPush){
            Debug.Log("press A");
            RNAText2.text = "A";
            firstPush = true;
            MainManager.instance.RNA_num[2] = 4;
        }
    }

    public void pressC(){
        if(!firstPush){
            Debug.Log("press C");
            RNAText2.text = "C";
            firstPush = true;
            MainManager.instance.RNA_num[2] = 3;
        }
    }

    public void pressG(){
        if(!firstPush){
            Debug.Log("press G");
            RNAText2.text = "G";
            firstPush = true;
            MainManager.instance.RNA_num[2] = 2;
        }
    }

    public void pressU(){
        if(!firstPush){
            Debug.Log("press U");
            RNAText2.text = "U";
            firstPush = true;
            MainManager.instance.RNA_num[2] = 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MainManager.instance.RNA_num[2]==0){
            RNAText2.text = "?";
            firstPush = false;
        } 
    }
}
