using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevels : MonoBehaviour {

    public void resetLevels(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
}
