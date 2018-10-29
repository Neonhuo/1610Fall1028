using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchStatements : MonoBehaviour
{

	public GameStates.States GameState;
	public UnityEvent Starting, Loading, Playing, Ending, Dying;

	void Update () 
	{
		switch (GameState)
		{
				case GameStates.States.Starting:
					print("We are starting the Game");
					break;
				case GameStates.States.Loading:
					print("We are loading the Game");
					break;
				case GameStates.States.Menu:
					print("The menu is open");
					break;
				case GameStates.States.Saving:
					print("Saving the Game");
					break;
				case GameStates.States.Playing:
					print("We are playing the Game");
					break;
				case GameStates.States.Dying:
					print("You are dead");
					break;
				
				case GameStates.States.Ending:
					print("We are ending the Game");
					break;
		}
	}
}
