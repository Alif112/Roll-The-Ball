using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishBall7 : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BallTag2"))
        {
            other.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Level7Passed", 10);

            Application.LoadLevel(15);
            Debug.Log("Inside method");
        }

        Debug.Log("outside");


    }

}
