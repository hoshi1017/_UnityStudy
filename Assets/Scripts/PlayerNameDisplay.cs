using UnityEngine;
using UnityEngine.UI;

public class PlayerNameDisplay : MonoBehaviour
{
    public Text playerNameText; // Legacy Text 컴포넌트
    private GameObject player;

    private void Start()
    {
        // 초기 씬 로드 시 Player 오브젝트를 찾고 이름을 설정
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
        // 플레이어가 아직 null인 경우, 계속 찾음
        if (player == null)
        {
            FindPlayer();
        }

        if (player != null && playerNameText != null)
        {
            // 플레이어의 위치에 따라 텍스트 위치 업데이트
            Vector3 offset = new Vector3(0, 1.5f, 0); // 텍스트가 스프라이트 위로 올라가도록 오프셋 설정
            playerNameText.transform.position = Camera.main.WorldToScreenPoint(player.transform.position + offset);
        }
    }

    private void UpdatePlayerName()
    {
        // DataManager에서 플레이어 이름을 가져와 설정
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