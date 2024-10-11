using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public InputField playerNameInput;

    private void Start()
    {
        playerNameInput.onValueChanged.AddListener(OnNameChanged);
    }

    private void OnNameChanged(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            DataManager.Instance.SettingPlayerName(name);
        }
    }

}
