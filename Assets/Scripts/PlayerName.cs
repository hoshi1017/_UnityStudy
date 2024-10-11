using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public InputField playerNameInput; 

    private void Start()
    {
        if (playerNameInput == null)
        {
            Debug.LogError("InputField�� �������� �ʾҽ��ϴ�!");
            return;
        }

        
        playerNameInput.onEndEdit.AddListener(OnNameEntered);
    }

    
    private void OnNameEntered(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            DataManager.Instance.SettingPlayerName(name);
            Debug.Log("�÷��̾� �̸��� �����Ǿ����ϴ�: " + name);
        }
        else
        {
            Debug.Log("�г����� �Է��ϼ���.");
        }
    }
}