using UnityEngine;
using UnityEngine.UI;

public class PlayerNameDisplay : MonoBehaviour
{
    public Text playerNameText; 
    private GameObject player;


    private void Start()
    {
        
        FindPlayer();
        UpdatePlayerName();
    }

    private void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        
        if (player == null)
        {
            FindPlayer();
        }

        if (player != null && playerNameText != null)
        {
            
            Vector3 offset = new Vector3(0, 1.8f, 0);
            playerNameText.transform.position = Camera.main.WorldToScreenPoint(player.transform.position + offset);
        } // 이름을 표시하는 UI의 위치 -> 플레이어 보다 살짝 위
    }

    private void UpdatePlayerName()
    {
        
        string playerName = DataManager.Instance.OutputPlayerName();
        if (!string.IsNullOrEmpty(playerName))
        {
            playerNameText.text = playerName;
        }
        else
        {
            
            playerNameText.text = "<color=#FF0000>" + "Unknown" + "</color>";
        }
    }
}