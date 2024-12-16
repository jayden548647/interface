using UnityEngine;
using UnityEngine.UI;

public class DifficultySet : MonoBehaviour
{
    public float difficulty;
    public Slider slider;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!slider)
        {
            difficulty = LevelManager.Instance.GetDifficulty();
            
        }
        else
        {
            slider.value = PlayerPrefs.GetFloat("Difficulty");
        }
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDifficulty();
        LevelManager.Instance.SetDifficulty(difficulty);
    }

    public void ChangeDifficulty()
    {
        difficulty = slider.value;
        if (slider)
        {
            PlayerPrefs.SetFloat("Difficulty", difficulty);
        }
        
    }
}
