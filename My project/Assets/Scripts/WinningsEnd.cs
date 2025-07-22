using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningsEnd : MonoBehaviour
{
    
    [SerializeField] public GameObject[] buttons;
    
    private int _sec;
    private float _time;
    private bool _isScreenPlaying;
    
    public void Start()
    {
        _isScreenPlaying = true;
        _time = 0f;
    }
    
    public void Update()
    {
        _time += Time.deltaTime;
        if (_time >= 14f && _isScreenPlaying)
        {
            _isScreenPlaying = false;
            foreach (var light  in buttons)
                light.GameObject().SetActive(!light.GameObject().activeSelf);
        }
        if (_time >= 20f)
        {
            _time = 0f;
            SceneManager.LoadScene("New Menu");
        }

        
    }
}
