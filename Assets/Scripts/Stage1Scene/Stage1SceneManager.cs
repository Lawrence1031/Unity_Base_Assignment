using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Stage1SceneManager : MonoBehaviour
{
    public TextMeshProUGUI PlayerName;
    public TextMeshProUGUI UnderUIText;

    private void Awake()
    {

        string playerNameData = PlayerPrefs.GetString("Name");

        GameObject playerObject = GameObject.Find("Player");
        GameObject UnderUIObject = GameObject.Find("UnderUI");

        UnderUIText.text = " ";

        if (!string.IsNullOrEmpty(playerNameData))
            PlayerName.text = playerNameData;
        else
            PlayerName.text = "Player";
    }
}
