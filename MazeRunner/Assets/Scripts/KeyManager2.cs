using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager2 : MonoBehaviour {


    public PlayerMovement playerMovement;
    public GameObject player;
    public GameObject sphere2;
    // Use this for initialization
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerMovement.GetComponent<PlayerMovement>();
        sphere2 = GameObject.FindGameObjectWithTag("Sphere2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerMovement.key2 = 1;
            sphere2.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
