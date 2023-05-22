using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; set; }
    public AudioSource bgm;

    private void Awake() {
        if(Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(this);
        }    
        else
        {
            Destroy(gameObject);
        }
    }

    public void MuteSound() 
    {
        if (bgm.mute == false)
        {
            bgm.mute = true;
        }
        else
        {
            bgm.mute = false;
        }
    }
}
