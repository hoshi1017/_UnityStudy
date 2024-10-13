using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject[] charPrefabs;
    private GameObject player;
    void Start()
    {
        player = Instantiate(charPrefabs[(int)DataManager.Instance.currentCharacter]);

        
        player.transform.position = transform.position;


        player.tag = "Player";
    }
}
