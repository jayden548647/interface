using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFXVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        slider.value = PlayerPrefs.GetFloat("SFXVolume", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        LevelManager.Instance.SetSFX(slider.value);
    }
    public void SetLevel(float sliderValue)
    {
        if (sliderValue > 0)
        {
            mixer.SetFloat("SFXVol", Mathf.Log10(sliderValue) * 20);
        }

        if (sliderValue == 0)
        {
            mixer.SetFloat("SFXVol", -40);
        }
        PlayerPrefs.SetFloat("SFXVolume", sliderValue);
    }
}

