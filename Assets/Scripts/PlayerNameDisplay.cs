using UnityEngine;
using UnityEngine.UI;

public class PlayerNameDisplay : MonoBehaviour
{
    public Text playerNameText; // Legacy Text ������Ʈ
    private GameObject player;

    private void Start()
    {
        // �ʱ� �� �ε� �� Player ������Ʈ�� ã�� �̸��� ����
        FindPlayer();
        UpdatePlayerName();
    }

    private void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (player == null)
        {
            Debug.LogError("Player ������Ʈ�� ã�� �� �����ϴ�!");
        }
    }

    private void Update()
    {
        // �÷��̾ ���� null�� ���, ��� ã��
        if (player == null)
        {
            FindPlayer();
        }

        if (player != null && playerNameText != null)
        {
            // �÷��̾��� ��ġ�� ���� �ؽ�Ʈ ��ġ ������Ʈ
            Vector3 offset = new Vector3(0, 1.5f, 0); // �ؽ�Ʈ�� ��������Ʈ ���� �ö󰡵��� ������ ����
            playerNameText.transform.position = Camera.main.WorldToScreenPoint(player.transform.position + offset);
        }
    }

    private void UpdatePlayerName()
    {
        // DataManager���� �÷��̾� �̸��� ������ ����
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