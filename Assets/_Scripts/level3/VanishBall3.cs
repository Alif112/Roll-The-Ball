using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishBall3 : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BallTag2"))
        {
            other.gameObject.SetActive(false);


            Application.LoadLevel(7);
            Debug.Log("Inside method");
        }

        Debug.Log("outside");


    }
}
