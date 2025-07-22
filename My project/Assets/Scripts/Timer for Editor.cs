using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerforEditor : MonoBehaviour
{
    private float _time;
    
    void Start()
    {
        _time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        

        if (Input.anyKeyDown || Input.touchCount >0)
            _time = 0;
        
        if (_time >= 90)
            FindObjectOfType<SceneTransition>().ChangeScene("New Menu");
    }
}
