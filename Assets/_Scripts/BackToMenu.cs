using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour {

    public void changetomainfromlevels(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
}
