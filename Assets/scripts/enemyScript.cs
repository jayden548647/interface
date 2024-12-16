using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float difficultyValue;
    public void Awake()
    {
        difficultyValue = PlayerPrefs.GetFloat("Difficulty");
        int rng = Random.Range(0, 20);

        if (rng + 1 > difficultyValue)
        {
            gameObject.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
