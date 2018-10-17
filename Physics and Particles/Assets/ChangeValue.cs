using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
//Made by Perry Williams
public class ChangeValue : ScriptableObject
{
    public FloatData Data;

    public void AddValue(FloatData obj)
    {
        Data.Value += obj.Value;
    }
    
    public void SubtractValue(FloatData obj)
    {
        Data.Value -= obj.Value;
    }
    
}