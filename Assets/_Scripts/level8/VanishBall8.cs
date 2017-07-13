using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishBall8 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BallTag2"))
        {
            other.gameObject.SetActive(false);


            Application.LoadLevel(17);
            Debug.Log("Inside method");
        }

        Debug.Log("outside");


    }
}

