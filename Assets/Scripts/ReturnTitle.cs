using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitle : MonoBehaviour
{
    private bool firstPush = false;

    public void PressReturn(){
        Debug.Log("Press Start");

        if(!firstPush){
            Debug.Log("Go Next Scene");
            firstPush = true;
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
