using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Leaderboard : MonoBehaviour {

    public Text[] highScores;
    float[] highScoreValues;
    string[] highScoreNames;
	// Use this for initialization
	void Start () {
        highScoreValues = new float[highScores.Length];
        highScoreNames = new string[highScores.Length];
        for (int x = 0; x < highScores.Length; x++){
            highScoreValues[x] = PlayerPrefs.GetFloat("highScoreValues" + x);
            highScoreNames[x] = PlayerPrefs.GetString("highScoreNames" + x);


        }
        DrawScores();
	}
    void SaveScores(){
        for (int x = 0; x < highScores.Length; x++)
        {
            PlayerPrefs.SetFloat("highScoreValues" + x, highScoreValues[x]);
            PlayerPrefs.SetString("highScoreNames" + x, highScoreNames[x]);
        }
    }

    public void CheckForHighScore(float _value, string _userName){
        for (int x = 0; x < highScores.Length; x++){
            if (_value > highScoreValues[x]){
                for (int y = highScores.Length - 1; y > x; y--){
                    highScoreValues[y] = highScoreValues[y - 1];
                    highScoreNames[y] = highScoreNames[y - 1];
                }
                highScoreValues[x] = _value;
                highScoreNames[x] = _userName;
                DrawScores();
                SaveScores();
                break;

            }
        }
    }

    void DrawScores(){
        for (int x = 0; x < highScores.Length; x++)
        {
            highScores[x].text = highScoreNames[x] + ":" + highScoreValues[x].ToString();

        }
    }
	// Update is called once per frame
	void Update () {
		
	}

   public void BackToMain(){
        SceneManager.LoadScene("MainMenu");
    }
}
