using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int levelSelectScene;
    public int controlsScene;
    public int titleScene;
    public int levelOneScene;
    public int levelTwoScene;
    public int loseScene;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLevelSelectPressed()
    {
       SceneManager.LoadScene(levelSelectScene);
    }

    public void OnControlsPressed()
    {
       SceneManager.LoadScene(controlsScene);
    }

    public void OnBackPressed()
    {
       SceneManager.LoadScene(titleScene);
    }

    public void OnMainMenuPressed()
    {
       SceneManager.LoadScene(titleScene);
    }

    public void OnOnePressed()
    {
        SceneManager.LoadScene(levelOneScene);
    }

    public void OnTwoPressed()
    {
        SceneManager.LoadScene(levelTwoScene);
    }
}

