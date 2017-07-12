using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToMenuPage : MonoBehaviour
{
    public void changetofirstmenu(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }

}
