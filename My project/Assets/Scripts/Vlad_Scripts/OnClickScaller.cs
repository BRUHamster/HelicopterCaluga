using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class OnClickScaller : MonoBehaviour
{
    public GameObject _txt;

    public void Scaler()
    {
        RectTransform _tr = GetComponent<RectTransform>();
        _tr.DOComplete();
        _tr.DOPunchScale(Vector3.one * 0.002f, 0.2f, 1);
        _txt.GetComponent<RectTransform>().DOPunchScale(Vector3.one * 0.02f, 0.2f, 1);
    }
}
