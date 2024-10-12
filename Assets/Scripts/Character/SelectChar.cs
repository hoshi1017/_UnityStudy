using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectChar : MonoBehaviour
{
    public SelectChar[] chars;
    SpriteRenderer sr;
    public Character character;

    private Color selectedColor = new Color(1f, 1f, 1f);
    private Color deselectedColor = new Color(0.5f, 0.5f, 0.5f);

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        if (DataManager.Instance.currentCharacter == character)
        {
            OnSelect();
        }
        else
        {
            OnDeSelect();
        }
    }


    private void OnMouseUpAsButton()
    {
        DataManager.Instance.currentCharacter = character;
        OnSelect();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != this) 
            { 
                chars[i].OnDeSelect(); 
            }

        }

    }

    private void OnDeSelect()
    {
        sr.color = deselectedColor;
    }

    void OnSelect()
    {
        sr.color = selectedColor;
    }
}
