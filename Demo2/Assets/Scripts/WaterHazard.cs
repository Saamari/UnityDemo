using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHazard : MonoBehaviour {

    // Use this for initialization
    private Controls player;
    public Transform start;
    


	void Start () {

        player = FindObjectOfType<Controls>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            player.transform.position = start.position;
        }
    }

}
