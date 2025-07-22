using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextSetter : MonoBehaviour
{
    public float scale = 1.2f;
    public TMP_Text _text;
    public GameObject[] _images;
    Vector3[] _localScales;

    void Start()
    {
        _localScales = new Vector3[_images.Length];
        for (int i = 0; i < _images.Length; ++i)
            _localScales[i] = _images[i].transform.localScale;
    }

    public void Soyuz()
    {
        for(int i = 0; i < _images.Length; ++i)
            _images[i].transform.localScale = _localScales[i];
        _images[2].transform.localScale *= scale;

        _text.text = "Спускаемый аппарат «Союз» — это герметичная капсула. Она возвращает космонавтов и груз с орбиты на Землю \n и защищает их при входе в атмосферу и при посадке.";
    }

    public void Helicopter()
    {
        for (int i = 0; i < _images.Length; ++i)
            _images[i].transform.localScale = _localScales[i];
        _images[0].transform.localScale *= scale;
        _text.text = "Вертолет Ми-8. Он сопровождает спускаемый аппарат от выброса парашюта до момента приземления. Поэтому он прибывает к месту посадки быстрее всех.";
    }

    public void PSS()
    {
        for (int i = 0; i < _images.Length; ++i)
            _images[i].transform.localScale = _localScales[i];
        _images[1].transform.localScale *= scale;
        _text.text = "Пилот поисково-спасательной службы. \n" +
                     " Его задача сопроводить космонавтов к месту посадки, доставить поисково-спасательные группы, медиков и их оборудование.";
    }

    // public void Med()
    // {
    //     for (int i = 0; i < _images.Length; ++i)
    //         _images[i].transform.localScale = _localScales[i];
    //     _images[3].transform.localScale *= scale;
    //     _text.text = "Врач поисково-спасательной службы (ПСС) осматривает космонавтов сразу после посадки. Это называется базовая проверка. Ее всегда проводят в полевых условиях. После космонавт попадает в медицинскую палатку для медико-биологического обследования.";
    // }
}
