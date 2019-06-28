using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager3 : MonoBehaviour {

    public PlayerMovement playerMovement;
    public GameObject player;
    public GameObject sphere3;
    // Use this for initialization
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerMovement.GetComponent<PlayerMovement>();
        sphere3 = GameObject.FindGameObjectWithTag("Sphere3");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerMovement.key3 = 1;
            sphere3.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
