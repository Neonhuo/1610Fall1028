using UnityEngine;

//Made By Anthony Romrell
[CreateAssetMenu]
public class PowerUp : ScriptableObject
{
	public FloatData Data;
	
	public void OnPowerUp (FloatData outsideData)
	{
		outsideData.Value += Data.Value;
	}
}
