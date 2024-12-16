using UnityEngine;

public class musicPlay : MonoBehaviour
{
    public AudioSource PlayMusic;
    public AudioClip PlayMusicClip;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        TheMusic();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TheMusic()
    {
        PlayMusic.PlayOneShot(PlayMusicClip);
    }
}
