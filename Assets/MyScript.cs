using System.Globalization;
using UnityEngine;
using TMPro;

public class MyScript : MonoBehaviour
{
    public TMP_InputField inputValue; 
    public TextMeshProUGUI outputValue; 
    public void OnButtonClick()
    {
        string text = inputValue.text.Replace(',', '.');
        
        if (!float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out float f))
        {
            outputValue.text = "Помилка: введіть число!";
            return;
        }
        
        float c = (f - 32f) * 5f / 9f;
        
        outputValue.text = $"Результат: {c:F2} °C"; 
    }
}
