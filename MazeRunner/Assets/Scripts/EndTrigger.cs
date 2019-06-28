using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour {

    public Timer timer;
    public GameObject endGate;
    public GameObject player;
    public PlayerMovement playerMovement1;
    public GameObject gameover;
    public GameObject leaders;
    // Use this for initialization
    void Awake () {
        player = GameObject.FindGameObjectWithTag("Player");
        timer = timer.GetComponent<Timer>();
        endGate = GameObject.FindGameObjectWithTag("EndGate");
        playerMovement1 = playerMovement1.GetComponent<PlayerMovement>();
        gameover = GameObject.FindGameObjectWithTag("Finish");
        leaders = GameObject.FindGameObjectWithTag("LEADER");
        gameover.SetActive(false);
       leaders.SetActive(false);
    }

// Update is called once per frame
    void Update(){
     }


    private void OnTriggerEnter(Collider other)
    {
        endGate.SetActive(false);
        timer.Finish();
        FindObjectOfType<GameManager>().EndGame();
        Debug.Log("GAME OVER");
     
        playerMovement1.speed = 0f;
        gameover.SetActive(true);
        gameover.SetActive(false);
        leaders.SetActive(true);
        Invoke("Restart",7);
    }
    void Restart(){
        SceneManager.LoadScene("SampleScene");
    }
}
