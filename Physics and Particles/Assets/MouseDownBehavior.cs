using UnityEngine;
using UnityEngine.Events;

//Made by Perry Williams
public class MouseDownBehavior : MonoBehaviour
{
    public UnityEvent Event;

    private void OnMouseDown()
    {
        Event.Invoke();
    }
}