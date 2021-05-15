using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public void SetSliderSpeed(float SliderSpeed)
    {
        PlayerPrefs.SetFloat("Speed", SliderSpeed);
    }

}

