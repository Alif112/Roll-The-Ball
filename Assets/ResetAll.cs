using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAll : MonoBehaviour {
    public GUISkin theSkin;
    public Texture2D resetimage;
    GUIContent content = new GUIContent();
    // Use this for initialization
    void Start () {
        content.image = (Texture2D)resetimage;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(500, 270, 40, 40), content))
        {
            PlayerPrefs.DeleteAll();
        }

    }
}
