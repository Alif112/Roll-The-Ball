// this is working on the Goalpost and 
// the OnTriggerEnter2D method vanish the collided ball with Tag "Ball Tag"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishBall : MonoBehaviour {
    public int flag = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // the OnTriggerEnter2D method vanish the collided ball with Tag "Ball Tag"

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BallTag"))
        {
            other.gameObject.SetActive(false);

            flag = 1;
            Application.LoadLevel(3);
            Debug.Log("Inside method");
        }

        

    
    }
    

}
