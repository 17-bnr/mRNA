using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RNA : MonoBehaviour
{
    public Text RNAText;
    private bool firstPush = false;
    public Button A;
    public Button C;
    public Button G;
    public Button U;

    public void pressA(){
        if(!firstPush){
            Debug.Log("press A");
            RNAText.text = "A";
            firstPush = true;
            MainManager.instance.RNA_num[0] = 4;
        }
    }

    public void pressC(){
        if(!firstPush){
            Debug.Log("press C");
            RNAText.text = "C";
            firstPush = true;
            MainManager.instance.RNA_num[0] = 3;
        }
    }

    public void pressG(){
        if(!firstPush){
            Debug.Log("press G");
            RNAText.text = "G";
            firstPush = true;
            MainManager.instance.RNA_num[0] = 2;
        }
    }

    public void pressU(){
        if(!firstPush){
            Debug.Log("press U");
            RNAText.text = "U";
            firstPush = true;
            MainManager.instance.RNA_num[0] = 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MainManager.instance.RNA_num[0]==0){
            RNAText.text = "?";
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
