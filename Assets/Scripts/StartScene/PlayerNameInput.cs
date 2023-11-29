using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserNameInput : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI PlayerName;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.Find("Player");

        if (playerObject != null)
        {
            Transform canvasTransform = playerObject.transform.Find("TextMeshProParent/Canvas");

            if (canvasTransform != null)
            {
                canvasTransform.gameObject.SetActive(true);
            }
        }

        inputField.onValueChanged.AddListener(PlayerNameInput);
    }

    void PlayerNameInput(string PName)
    {
        PlayerName.text = PName;
    }
}
