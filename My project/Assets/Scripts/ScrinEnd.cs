using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScrinEnd : MonoBehaviour
{
    private int _sec;
    private float _time;
    

    public void Start()
    {
        _time = 0f;
    }
    public void Update()
    {
        _time += Time.deltaTime;
        if (_time >= 14f )
            FindObjectOfType<SceneTransition>().ChangeScene("Titry1");
        
    }
}
