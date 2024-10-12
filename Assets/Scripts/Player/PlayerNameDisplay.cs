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
            Vector3 playerWorldPosition = player.transform.position + offset;
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(playerWorldPosition);

            playerNameText.transform.position = screenPosition;
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
            
            playerNameText.text = "<color=#FF0000>" + "Unknown" + "</color>";
        }
    }
}