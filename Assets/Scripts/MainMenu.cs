using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        Debug.Log("Play Game!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void Tutorial()
    {
        Debug.Log("Tutorial!");
        SceneManager.LoadScene(1);
        
    }


    public void Credits()
    {
        Debug.Log("Credits!");
        SceneManager.LoadScene(2);
        
    }

    
}
