using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartButton : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI PlayerName;
    public Button StartBtn;


    private void Start()
    {
        StartBtn.onClick.AddListener(StartBtnClick);
    }

    private void StartBtnClick()
    {
        string playerName = inputField.text;



        if (!string.IsNullOrEmpty(playerName) && playerName.Length >= 2 && playerName.Length <= 8 )
        {
            PlayerPrefs.SetString("Name", playerName);
            PlayerPrefs.Save();

            GameObject StartUIObject = GameObject.Find("StartUI");

            StartUIObject.SetActive(false);
            SceneManager.LoadScene("02_MainScene");
        }
    }
}
