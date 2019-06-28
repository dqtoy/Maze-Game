using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateManager2 : MonoBehaviour {
    public PlayerMovement playerMovement;
    public GameObject player;
    public GameObject gate2;
    // Use this for initialization
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerMovement.GetComponent<PlayerMovement>();
        gate2 = GameObject.FindGameObjectWithTag("Gate2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            if (playerMovement.key2 == 1)
            {
                gate2.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
