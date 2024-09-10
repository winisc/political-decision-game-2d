using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculos : MonoBehaviour
{
    public float valuePovo;
    public float valueExercito;
    public float valuePolitica;

    [SerializeField] private Slider[] sliderValues;

    [SerializeField] private TextMeshProUGUI[] apoioValueText;
    // Start is called before the first frame update
    void Start()
    {
        valuePovo = 0;
        valueExercito = 0;
        valuePolitica = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SliderApoioValues();
        TextApoioValues();
    }

    private void SliderApoioValues()
    {
        sliderValues[0].value = valuePovo;
        sliderValues[1].value = valueExercito;
        sliderValues[2].value = valuePolitica;
    }

    private void TextApoioValues()
    {
        apoioValueText[0].text = valuePovo*100 + "%";
        apoioValueText[1].text = valueExercito*100  + "%";
        apoioValueText[2].text = valuePolitica*100  + "%";
    }
}
