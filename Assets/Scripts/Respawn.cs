using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject[] charPrefabs;
    public GameObject player;
    void Start()
    {
        player = Instantiate(charPrefabs[(int)DataManager.Instance.currentCharacter]);


        player.transform.position = transform.position;


        player.tag = "Player";
    }
}
