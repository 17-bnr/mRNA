using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RNA1 : MonoBehaviour
{
    public Text RNAText1;
    private bool firstPush = false;
    public Button A;
    public Button C;
    public Button G;
    public Button U;

    public void pressA(){
        if(!firstPush){
            Debug.Log("press A");
            RNAText1.text = "A";
            firstPush = true;
            MainManager.instance.RNA_num[1] = 4;
        }
    }

    public void pressC(){
        if(!firstPush){
            Debug.Log("press C");
            RNAText1.text = "C";
            firstPush = true;
            MainManager.instance.RNA_num[1] = 3;
        }
    }

    public void pressG(){
        if(!firstPush){
            Debug.Log("press G");
            RNAText1.text = "G";
            firstPush = true;
            MainManager.instance.RNA_num[1] = 2;
        }
    }

    public void pressU(){
        if(!firstPush){
            Debug.Log("press U");
            RNAText1.text = "U";
            firstPush = true;
            MainManager.instance.RNA_num[1] = 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MainManager.instance.RNA_num[1]==0){
            RNAText1.text = "?";
            firstPush = false;
        }
        if(firstPush==false){
            A.interactable = true;
            C.interactable = true;
            G.interactable = true;
            U.interactable = true;
        }
        if(firstPush==true){
            A.interactable = false;
            C.interactable = false;
            G.interactable = false;
            U.interactable = false;
        }
    }
}
