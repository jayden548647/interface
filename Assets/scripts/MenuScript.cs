using UnityEngine;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour
{
    GameObject Strat;
    float masterVol;
    float musicVol;
    float SFXVol;
    float noSet;
    public AudioMixer mixer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Strat = GameObject.FindGameObjectWithTag("Menu");
        

        masterVol = PlayerPrefs.GetFloat("MasterVolume");
        musicVol = PlayerPrefs.GetFloat("MusicVolume");
        SFXVol = PlayerPrefs.GetFloat("SFXVolume");

        
       
    }
    private void Start()
    {
        noSet = 4;
        if (PlayerPrefs.GetFloat("MasterVolume") == 0)
        {
            mixer.SetFloat("MasterVol", -80);
        }
        if (PlayerPrefs.GetFloat("MusicVolume") == 0)
        {
            mixer.SetFloat("MusicVol", -80);
        }
        if (PlayerPrefs.GetFloat("SFXVolume") == 0)
        {
            mixer.SetFloat("SFXVol", -80);
        }
        if (PlayerPrefs.GetFloat("MasterVolume") > 0)
        {
            mixer.SetFloat("MasterVol", Mathf.Log10(masterVol));
        }
        if (PlayerPrefs.GetFloat("MusicVolume") > 0)
        {
            mixer.SetFloat("MusicVol", Mathf.Log10(musicVol));
        }
        if (PlayerPrefs.GetFloat("SFXVolume") > 0)
        {
            mixer.SetFloat("SFXVol", Mathf.Log10(SFXVol));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Set()
    {
        noSet = noSet - 1;

        if (noSet > 0 && noSet < 2)
        {
            Strat.SetActive(false);
        }
    }
}
