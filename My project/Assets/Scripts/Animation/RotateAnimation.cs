using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimation : MonoBehaviour
{
    public float speed = 1.0f;
    public float amplitude = 2.0f;
    private float _baseRotationZ;
    
    
    void Start()
    {
        _baseRotationZ = transform.localRotation.z;
    }

    void Update()
    {
        float delta = amplitude * (Mathf.Sin(Time.time * speed));
        
        var rotation = transform.rotation;
        rotation.z = _baseRotationZ + delta; 
        transform.rotation = rotation;

    }
}
