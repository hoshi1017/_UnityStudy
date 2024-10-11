using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public InputField playerNameInput; 

    private void Start()
    {
        if (playerNameInput == null)
        {
            Debug.LogError("InputField가 설정되지 않았습니다!");
            return;
        }

        
        playerNameInput.onEndEdit.AddListener(OnNameEntered);
    }

    
    private void OnNameEntered(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            DataManager.Instance.SettingPlayerName(name);
            Debug.Log("플레이어 이름이 설정되었습니다: " + name);
        }
        else
        {
            Debug.Log("닉네임을 입력하세요.");
        }
    }
}