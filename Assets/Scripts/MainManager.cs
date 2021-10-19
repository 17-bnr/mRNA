using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public float now_time;
    // Start is called before the first frame update
    void Start()
    {
        now_time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        now_time += Time.deltaTime;
    }
}
