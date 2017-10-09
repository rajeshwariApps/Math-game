using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using System.Collections.Generic;

public class Subtraction : MonoBehaviour {
	public Text firstNum;
	public Text secondNum;
	int counter = 0;

	int firstNumMin = 10;
	int firstNumMax = 20;
	int seconfNumMin = 5;
	int secondNumMax = 9;

	public int answer;
	void Start () 
	{
	}
	

	void Update () 
	{
		counter++;
		if (counter == 1) {
			SubtractingNums ();
		}
	}

	public  void SubtractingNums()
	{
		int randomIstNum = Random.Range (firstNumMin, firstNumMax);
		int random2ndNum = Random.Range (seconfNumMin, secondNumMax);

		firstNum.text = randomIstNum.ToString();
		secondNum.text = random2ndNum.ToString();
		if (randomIstNum > random2ndNum) {
			answer = (randomIstNum - random2ndNum);
		} else {
			answer = -(random2ndNum - randomIstNum);
		}

		int randomButtonIndex = Random.Range (0, 4);
		AssignOptions (answer, randomButtonIndex);
		Debug.Log ("answetr" + answer);
	}

	private void AssignOptions(int answer, int answerButtonIndex) {
		ButtonCls button;
		for (int i = 0; i < 4; i++) {
			if (i == answerButtonIndex) {
				button = new ButtonCls (answerButtonIndex, answer.ToString());
			} else {
				int r;
				do {
					r = Random.Range (0, 20);
					button = new ButtonCls (i, r.ToString ());
				} while (r == answer);
			}
			button.Display ();
		}
	}
}

public class ButtonCls
{
	private string buttonText;
	private int buttonIndex;

	public ButtonCls(int n, string t)
	{
		this.buttonIndex = n;
		this.buttonText = t;
	}

	public int getButtonIndex()
	{
		return this.buttonIndex;
	}
	public string getButtonText()
	{
		return this.buttonText;
	}
	public string setButtonText(string t)
	{
		return this.buttonText = t;
	}

	public void Display() 
	{
		GameObject buttonObj = GameObject.Find ("MCQ" + (buttonIndex+1)+"Button");
		buttonObj.GetComponentsInChildren<Text> () [0].text = this.buttonText;
	}
}
