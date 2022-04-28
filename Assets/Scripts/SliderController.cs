using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI sliderText;
    public string variableName;
    public float defaultValue;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat(variableName, defaultValue);
        sliderText.text = PlayerPrefs.GetFloat(variableName, defaultValue).ToString("0.00");
        slider.onValueChanged.AddListener((v) =>
        {
            sliderText.text = v.ToString("0.00");
            PlayerPrefs.SetFloat(variableName, v);    
        });
    }
}
