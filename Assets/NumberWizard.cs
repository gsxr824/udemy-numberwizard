using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	// Use this for initialization
	int max; 
	int min;
	int guess;
	int MaxGuessesAllowed;

	public Text text;

	void Start () {
		StartGame ();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		MaxGuessesAllowed = 8;

		max = max + 1;
	
	}

	public void GuessHigher () {
		min = guess;
		NextGuess ();
	}

	public void GuessLower () {
		max = guess;
		NextGuess ();
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		text.text = guess.ToString();
		MaxGuessesAllowed = MaxGuessesAllowed - 1;
		if (MaxGuessesAllowed <= 0) {
			Application.LoadLevel ("Lose");
		}
	} 


}
