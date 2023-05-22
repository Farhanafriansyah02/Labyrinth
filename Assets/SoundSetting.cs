using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    public Toggle toggle;
    public Slider sliderVolume;

    public void SliderVolume()
    {
        SoundManager.Instance.bgm.volume = sliderVolume.value;
    }
    public void ToggleMute() 
    {
        if(SoundManager.Instance.bgm.mute == true)
        {
            SoundManager.Instance.MuteSound();
        }
        else
        {
            SoundManager.Instance.MuteSound();
        }
    }
}
