using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();


	}
	void StartGame() {
		max = 1000;
		min = 1;
		guess = 500;

		print ("=======================================");
		print("Welcome to Number Wizard!");
		print ("Pick a number in your head, but do not tell me!");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess);
		print ("Up = higher, Down = lower, return = equal");

		max = max + 1;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		}
	}

	void NextGuess ()
	{
		guess = (max + min) / 2;
		print ("Is the number higher or lower than " + guess);
		print ("Up = higher, Down = lower, return = equal");
	}
}
