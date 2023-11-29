using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {

    }

    public void LoadMainScene()
    {
        if (gameManager.inputName.text.Length < 2)
        {
            return;
        }
        PlayerPrefs.SetString("Name", gameManager.inputName.text);
        SceneManager.LoadScene("MainScene");

    }

    public void LoadChooseCharacterScene()
    {
        SceneManager.LoadScene("ChooseCharacter");
        
    }

    public void LoadChoosedToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
