using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateImageValue : MonoBehaviour
{
	public FloatData Data;
	private Image image;
	
	void Start ()
	{
		image = GetComponent<Image>();
		
		
	}
	
	
	void Update ()
	{
		image.fillAmount = Data.Value;

		if (image.fillAmount <= 0.5f)
		{
			image.color = Color.red;
		}
	}
}
