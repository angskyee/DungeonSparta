using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
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
        GameObject.FindWithTag("StartSceneBackground").SetActive(false);
        GameObject.FindWithTag("ChooseSceneBackground").SetActive(true);

    }

    public void LoadChoosedToStartScene()
    {
        GameObject.FindWithTag("StartSceneBackground").SetActive(true);
        GameObject.FindWithTag("ChooseSceneBackground").SetActive(false);
    }

    public void ChooseWizzard()
    {
        GameObject.FindWithTag("StartSceneWizzard").SetActive(true);
        GameObject.FindWithTag("StartSceneKnight").SetActive(false);
    }

    public void ChooseKnight()
    {
        GameObject.FindWithTag("StartSceneWizzard").SetActive(false);
        GameObject.FindWithTag("StartSceneKnight").SetActive(true);
    }

}
