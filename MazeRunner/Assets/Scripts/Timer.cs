using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float startTime;
    public float endTime;
    private bool finished = false;
    public Leaderboard leader;
    public InputField playerName; 
	// Use this for initialization
	void Start () {
        startTime = Time.time;

	}

    private void Awake()
    {
        leader = leader.GetComponent<Leaderboard>();

    }
    // Update is called once per frame
    void Update () {

        if (finished) 
            return;

        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
	}

    public void Finish(){
        finished = true; 
        endTime = Time.time - startTime;
      //  InitialsEntered();
        Debug.Log(endTime);
        timerText.color = Color.yellow;
       
            
    }

    public void InitialsEntered(){
        leader.CheckForHighScore(endTime,playerName.text);
    }
}
