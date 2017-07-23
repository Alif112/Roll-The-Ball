using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishBall9 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BallTag2"))
        {
            other.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Level9Passed", 10);

            Application.LoadLevel(19);
            Debug.Log("Inside method");
        }

        Debug.Log("outside");


    }
}
