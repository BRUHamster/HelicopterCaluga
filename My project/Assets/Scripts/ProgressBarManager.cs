using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBarManager : MonoBehaviour
{
    private float _maxTime = 65.0f;
    private float _time = 0.0f;

    [SerializeField] private Slider progressBar;
    
    void FixedUpdate()
    {
        _time += Time.deltaTime;
        progressBar.value = _time / _maxTime;
    }
}
