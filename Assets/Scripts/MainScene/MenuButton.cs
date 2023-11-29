using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public GameObject SideBarUI;
    public GameObject NameChange;
    public GameObject CharacterSelect;
    public GameObject ViewOtherPlayer;

    // Start is called before the first frame update
    void Start()
    {
        SideBarUI.SetActive(false);
        NameChange.SetActive(false);
        CharacterSelect.SetActive(false);
        ViewOtherPlayer.SetActive(false);
    }

    public void ToggleMenuButton()
    {
        SideBarUI.SetActive(!SideBarUI.activeSelf);
    }

    public void ToggleNameChangeButton()
    {
        NameChange.SetActive(!NameChange.activeSelf);
    }
    public void ToggleCharacterSelectButton()
    {
        CharacterSelect.SetActive(!CharacterSelect.activeSelf);
    }
    public void ToggleViewOtherPlayerButton()
    {
        ViewOtherPlayer.SetActive(!ViewOtherPlayer.activeSelf);
    }
}
