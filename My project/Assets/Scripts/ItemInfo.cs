using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    [SerializeField] public string Text;
    
    [SerializeField] public GameObject TextMeshPro;
    
    public void ChangeText() => TextMeshPro.GetComponent<TextMeshProUGUI>().text = Text;



}
