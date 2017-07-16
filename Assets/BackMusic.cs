using UnityEngine;
using System.Collections;

public class BackMusic : MonoBehaviour
{

    void Start()
    {
        Debug.Log(">>> Sound Called");
        DontDestroyOnLoad(gameObject);
    }
}
