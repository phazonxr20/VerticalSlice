using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public string levelToLoad = "MainLevel";
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
}
