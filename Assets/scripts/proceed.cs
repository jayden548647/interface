using UnityEditor.Audio;
using UnityEngine;

public class proceed : MonoBehaviour
{
    public AudioSource sounding;
    public AudioClip clip;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sounding = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonMethod()
    {
        LevelManager.Instance.SceneLoad("Game");
    }
    public void ButtonSound()
    {
        sounding.PlayOneShot(clip);
    }
    public void surrender()
    {
        Application.Quit();
    }
}
