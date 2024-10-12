using UnityEngine;
using UnityEngine.UI;

public class PlayerNameDisplay : MonoBehaviour
{
    public Text playerNameText;
    private GameObject player;


    private void Start()
    {

        FindPlayer();
        UpdatePlayerName(DataManager.Instance.OutputPlayerName());
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
        }
    }

    public void UpdatePlayerName(string name)
    {

        
        if (!string.IsNullOrEmpty(name))
        {
            playerNameText.text = name;
        }
        else
        {

            playerNameText.text = "<color=#FF0000>" + "Unknown" + "</color>";
        }
    }

}