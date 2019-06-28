using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateManager3 : MonoBehaviour {
    public PlayerMovement playerMovement;
    public GameObject player;
    public GameObject gate3;
    // Use this for initialization
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerMovement.GetComponent<PlayerMovement>();
        gate3 = GameObject.FindGameObjectWithTag("Gate3");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            if (playerMovement.key3 == 1)
            {
                gate3.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
