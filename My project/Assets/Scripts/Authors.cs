using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Authors : MonoBehaviour
{
    [SerializeField] private GameObject[] _items;
    
    [SerializeField] public  GameObject _textField;

    public void Switch()
    {
        foreach (var item in _items)
        {
            item.SetActive(!item.activeSelf);
            
            _textField.GetComponent<TextMeshProUGUI>().text = "Нажми на объект - увидишь текст";
        }
    }

    


    

    //TODO!!!!!!!!!!!!!!!!!!  REMOVE ME
    private void Update()
    {
        
    }
}
