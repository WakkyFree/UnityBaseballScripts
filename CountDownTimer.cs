using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

  private int gameTimerInt;
  private float gameTimerFloat;
  public Text timeText;

	// Use this for initialization
	void Start () {
    gameTimerFloat = 60.0f;
    gameTimerInt = (int) gameTimerFloat;
    timeText.text =  "" + gameTimerInt.ToString(); 
	}
	
	// Update is called once per frame
	void Update () {
    if(gameTimerFloat > 0.0f){
      gameTimerFloat -= Time.deltaTime;
      gameTimerInt = (int) gameTimerFloat;
      timeText.text =  "" + gameTimerInt.ToString(); 
    }
  
    if(gameTimerFloat <= 0.0f){
      gameTimerInt = 0;
      timeText.text =  "" + gameTimerInt.ToString(); 
    }
	}

}
