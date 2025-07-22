using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMoving : MonoBehaviour
{
    [SerializeField] public float speed = 0.1f;

    void Update()
    {
        transform.Translate(0f,speed,0f);
    } 
    
        
    
}
