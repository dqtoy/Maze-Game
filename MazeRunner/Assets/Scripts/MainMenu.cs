using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
  // public GameObject leaders;

    public void Awake()
    {
       //leaders = GameObject.FindGameObjectWithTag("LEADER");
    }
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void LeaderBoard(){
        SceneManager.LoadScene("Leaderboard");
       // leaders.SetActive(true);
    }
}
