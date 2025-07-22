using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CloudMoving : MonoBehaviour
{
    
    void Update()
    {
        transform.Translate(-0.001f,0,0);
    }
}
