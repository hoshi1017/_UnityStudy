using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnToField : MonoBehaviour
{
    public GameObject InputField;
    void Start()
    {

    }
    public void SetInputField()
    {
        InputField.SetActive(true);
    }
}
