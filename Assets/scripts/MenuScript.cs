using UnityEngine;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour
{
    float masterVol;
    float musicVol;
    float SFXVol;
    public AudioMixer mixer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //get playerprefs settings

        masterVol = PlayerPrefs.GetFloat("MasterVolume");
        musicVol = PlayerPrefs.GetFloat("MusicVolume");
        SFXVol = PlayerPrefs.GetFloat("SFXVolume");

        mixer.SetFloat("MasterVol", Mathf.Log10(masterVol));
        mixer.SetFloat("MusicVol", Mathf.Log10(musicVol));
        mixer.SetFloat("SFXVol", Mathf.Log10(SFXVol));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
