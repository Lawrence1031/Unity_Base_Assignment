using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerNameChangeButton : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI PlayerName;
    public GameObject NameChange;
    public Button CheckButton;

    // Start is called before the first frame update
    void Start()
    {
        CheckButton.onClick.AddListener(NameChangeBtnClick);
        CheckButton.onClick.AddListener(CloseNameChangeUI);
    }


    private void NameChangeBtnClick()
    {
        string playerName = inputField.text;

        if (!string.IsNullOrEmpty(playerName) && playerName.Length >= 2 && playerName.Length <= 8)
        {
            PlayerPrefs.SetString("Name", playerName);
            PlayerPrefs.Save();
            PlayerName.text = playerName;
        }
    }

    void CloseNameChangeUI()
    {
        NameChange.SetActive(false);
    }
}
