using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public int difficultyValue;
    public void Awake()
    {
        int rng = Random.Range(1, 21);

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
