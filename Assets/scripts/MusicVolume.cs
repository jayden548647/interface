using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider VolumeSlider;
    public float sliderValue;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (!VolumeSlider)
        {
            sliderValue = LevelManager.Instance.GetMusic();
        }

        VolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
       LevelManager.Instance.SetMusic(sliderValue); 
    }
    public void SetLevel(float sliderValue)
    {
        
        
        if (sliderValue > 0)
        {
            mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
        }

        if(sliderValue == 0 )
        {
            mixer.SetFloat("MusicVol", -80);
        }
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
}
