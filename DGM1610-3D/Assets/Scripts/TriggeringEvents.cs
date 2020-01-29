using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    int health;
    float speed;
    string username;
    public UnityEvent enterEvent;
    public UnityEvent stayEvent;
    public UnityEvent exitEvent;

    private void OnTriggerEnter(Collider other)
    {
        enterEvent.Invoke();
    }
    private void OnTriggerStay(Collider other)
    {
        stayEvent.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        exitEvent.Invoke();
    }
}
