using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ForButtons : MonoBehaviour
{
    private float _int = 0.8f; //scale
    private int _ind = 0; //index of ar
    private readonly float[] _ar = { 1.1f, 0.8f }; //array for animation
    private int _sec = 0;
    private float _time = 0f;
    void Start()
    {
        _ind = 0;
    }
    
    
    void Update()
    {
        _time += Time.deltaTime;
        
        if (_time >= 1f)
        {
            _sec++;
            _time = 0f;
            
            transform.localScale = new Vector3(_int, _int, _int);
            _int = _ar[_ind];
            _ind = (_ind + 1) % 2;
        }
    }
}
