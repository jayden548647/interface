using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioSource sounding;
    public AudioClip clip;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sounding = GameObject.FindGameObjectWithTag("Manager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonSound()
    {
        sounding.PlayOneShot(clip);
    }
}
