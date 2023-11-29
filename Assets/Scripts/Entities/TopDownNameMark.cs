using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TopDownNameMark : MonoBehaviour
{
    public TextMeshProUGUI playerName;

    void Start()
    {
        Load();
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            playerName.text = PlayerPrefs.GetString("Name");
        }
    }
}
