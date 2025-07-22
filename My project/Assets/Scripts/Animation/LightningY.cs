using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningX : MonoBehaviour
{
    private float _baseScale;
    
    public float speed = 1.5f;
    public float amplitude = 1f;

    private Transform _transform;
    void Start()
    {
        _transform = transform;
        _baseScale = _transform.localScale.y;
        
    }

    void Update()
    {
        float delta = Math.Abs(Mathf.Sin(Time.time * speed)) * amplitude;

        
        var scaleY = _transform.localScale;
        scaleY.y = _baseScale + delta;
        _transform.localScale = scaleY;
    }
}
