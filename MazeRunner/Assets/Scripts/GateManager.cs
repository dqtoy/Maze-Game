using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateManager : MonoBehaviour {
    public PlayerMovement playerMovement;
    public GameObject player;
    public GameObject gate1;
    // Use this for initialization
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerMovement.GetComponent<PlayerMovement>();
        gate1 = GameObject.FindGameObjectWithTag("Gate1");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            if (playerMovement.key1 == 1)
            {
                gate1.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
