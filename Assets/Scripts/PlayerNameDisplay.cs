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

        if (player == null)
        {
            Debug.LogError("Player 오브젝트를 찾을 수 없습니다!");
        }
    }

    private void Update()
    {
        
        if (player == null)
        {
            FindPlayer();
        }

        if (player != null && playerNameText != null)
        {
            
            Vector3 offset = new Vector3(0, 1.5f, 0); 
            playerNameText.transform.position = Camera.main.WorldToScreenPoint(player.transform.position + offset);
        }
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
            playerNameText.text = "Unknown Player";
        }
    }
}