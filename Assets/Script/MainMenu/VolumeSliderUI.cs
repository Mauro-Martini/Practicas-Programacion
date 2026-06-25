using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderUI : MonoBehaviour
{
    public Slider slider;
    public VolumeSettings volumeSettings;

    void Start()
    {
        slider.value = volumeSettings.volumen;
        slider.onValueChanged.AddListener(MusicManager.instancia.SetVolume);
    }
}