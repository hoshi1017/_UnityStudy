using System;
using UnityEngine;
using UnityEngine.UI;

public class SettingTimeUI : MonoBehaviour
{
    public Text TimeTxt;
    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        TimeTxt.text = DateTime.Now.ToString("HH:mm");

    }
}
