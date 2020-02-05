using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuEvents : MonoBehaviour
{
    public UnityEvent pressPlay;
    public Button button;

    void Start()
    {
        
    }

    void Update()
    {
        if(button.enabled == true)
        {
            pressPlay.Invoke();
        }
    }
}
