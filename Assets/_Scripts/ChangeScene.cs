using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
    public void changemenuToScene1(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
    public void changeScene1ToScene2(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }

    public void changeScene1completedTomainmenu(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
    public void changeScene2ToScene1Retry(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }


    public void changeScene2ToScene3(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
    public void changeScene2completedTomainmenu(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }

    public void changeScene3ToScene4(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }

}
