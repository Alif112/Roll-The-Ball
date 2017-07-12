using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToMainFromFirst : MonoBehaviour {
    public void changetofirstmenu(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
}
