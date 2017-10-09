using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class suncheck : MonoBehaviour {

	public Button button;
	GameObject verticalPanel;
	//public Image winImage;
	//public Image LostImage;
	public GameObject winObj;
	public GameObject lostObj;
	//public Text wintext;
	Subtraction subtractionScript;
	public Text scoreText; 
	int score;

	public void Start()  
	{
		verticalPanel = GameObject.Find ("BGPannel");

		//winImage.enabled = !winImage.enabled;
		//LostImage.enabled = !LostImage.enabled;
		subtractionScript = verticalPanel.GetComponent<Subtraction> ();

		///Button btn = button.GetComponent<Button> ();
		//btn.onClick.AddListener (ifCorrectAns);
		//wintext.enabled = !wintext.enabled;
		winObj.gameObject.SetActive(false);
		lostObj.gameObject.SetActive(false);
		score = 0;
	}
	public void ifCorrectAns()
	{
		//Debug.Log (button.GetComponentInChildren<Text> ().text);
		//Debug.Log (additionScript.answer.ToString());

		if (button.GetComponentInChildren<Text> ().text == subtractionScript.answer.ToString()) {
			Debug.Log ("hi");
			score = score + 50;
			scoreText.text = score.ToString ();
			winObj.gameObject.SetActive (true);
			Time.timeScale = 0;

		}
		//LostImage.enabled = !LostImage.enabled;
		else {
			lostObj.gameObject.SetActive (true);
			score = 0;
			scoreText.text = score.ToString ();
            Time.timeScale = 0;
		}
	}
}
