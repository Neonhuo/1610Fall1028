using UnityEngine;
using UnityEngine.Events;

//Made By Perry Williams
public class TriggerEventBehavior : MonoBehaviour
{

    public UnityEvent Enable;
    public UnityEvent Trigger;

    void OnEnable()
    {
        Enable.Invoke();
    }

    void OnTriggerEnter()
    {
        Trigger.Invoke();
    }
}
