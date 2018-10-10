using UnityEngine;

//Made by Perry Williams
public class WhatCanSeeIt : ScriptableObject
{
    private float health;
    protected float PowerLevel;
    public float EnergyLevel;

    private void AddHealth()
    {
        health += 100;
    }

    protected void AddPower()
    {
        AddHealth();
    }

    public void AddEnergy()
    {
        
    }
}

public class ICanSeeIt: MonoBehaviour
{
    private WhatCanSeeIt newObject;

    private void Start()
    {
        newObject.EnergyLevel = 100;
        newObject.AddEnergy();
    }
}

public class Child : WhatCanSeeIt
{
    void CallThings()
    {
        PowerLevel = 200;
        EnergyLevel = 300;
        AddPower();
        AddEnergy();
    }

}