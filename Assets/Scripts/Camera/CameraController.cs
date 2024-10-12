using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 10.0f;

    private GameObject player;
    private void Start()
    {
        player = GameObject.FindWithTag("Player");

    }

    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }

        if (player != null)
        {
            Vector2 dir = player.transform.position - this.transform.position;
            Vector2 moveVector = new Vector2(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime);
            this.transform.Translate(moveVector);
        }
    }

}
