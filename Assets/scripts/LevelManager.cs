using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public static LevelManager Instance;
    public float difficulty = 0;
    public float masterVolume = 0;
    public float musicVolume = 0;
    public float SFXVolume = 0;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneLoad(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SetDifficulty(float setting)
    {
        difficulty = setting;
    }

    public float GetDifficulty()
    {
        return difficulty;
    }

    public void SetMaster(float master)
    {
        masterVolume = master;
    }
    public float GetMaster()
    {
        return masterVolume;
    }
    public void SetMusic(float music)
    {
        musicVolume = music;
    }
    public float GetMusic()
    {
        return musicVolume;
    }
    public void SetSFX(float SFX)
    {
        SFXVolume = SFX;
    }
    public float GetSFX()
    {
        return SFXVolume;
    }
}
