using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset = new Vector3(0, 2, -10);
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    private void Update()
    {
        if (player != null)
        {
            
            this.transform.position = player.transform.position + offset;
        }
        else
        {
            player = GameObject.FindWithTag("Player");
        }
    }
}
