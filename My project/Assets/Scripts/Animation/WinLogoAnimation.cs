using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
public class WinLogoAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        transform.DOScale(new Vector3(86,86,216), 2f);
        transform.DOScale(0, 2f);
    }

    
}
