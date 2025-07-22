using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    
    void Start()
    {
        Object.DontDestroyOnLoad(this.gameObject);
        
        if (GameObject.FindGameObjectsWithTag("DonDestroy").Length > 1)
            GameObject.Destroy(GameObject.FindGameObjectsWithTag("DonDestroy")[1]);
        
    }

    
}
