using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartVideo : MonoBehaviour
{
    private float _time; 
    

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        
        if (_time >= 7f)
            FindObjectOfType<SceneTransition>().ChangeScene("Level");
    }
}
