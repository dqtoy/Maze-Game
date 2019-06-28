using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour {


    public PlayerMovement playerMovement;
    public GameObject player;
    public GameObject sphere1;
	// Use this for initialization
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerMovement.GetComponent<PlayerMovement>();
        sphere1 = GameObject.FindGameObjectWithTag("Sphere1");
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerMovement.key1 = 1;
            sphere1.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
