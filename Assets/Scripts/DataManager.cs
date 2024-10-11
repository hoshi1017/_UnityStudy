using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    MaskDude, NinjaFrog, PinkMan
}
public class DataManager : MonoBehaviour
{

    public static DataManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Character currentCharacter;
}
