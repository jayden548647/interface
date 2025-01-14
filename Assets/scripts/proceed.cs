using UnityEngine;

public class proceed : MonoBehaviour
{
   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonMethod()
    {
        LevelManager.Instance.SceneLoad("Game");
    }
    
    public void surrender()
    {
        Application.Quit();
    }
}
