using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangePlayerName : MonoBehaviour
{
    public InputField NameField;
    private PlayerNameDisplay playerNameDisplay;
    
    public void ChangeName()
    {
        string newName = NameField.text;
        DataManager.Instance.SettingPlayerName(newName);

        playerNameDisplay.UpdatePlayerName(newName);

        Debug.Log($"이름이 바뀌었습니다.: {newName}");
    }
    
    
}


