using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class firstmainscript : MonoBehaviour {

    public Canvas quitMenu;
    public Button starttext;
    public Button GotoMenu;
    public Button exitText; 

	// Use this for initialization
	void Start () {
        quitMenu = quitMenu.GetComponent<Canvas>();
        starttext = starttext.GetComponent<Button>();
        GotoMenu = GotoMenu.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExitPress()
    {
        quitMenu.enabled = true;
        starttext.enabled = false;
        exitText.enabled = false;
        GotoMenu.enabled = false;

    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        starttext.enabled = true;
        exitText.enabled = true;
        GotoMenu.enabled = true;
    }

    public void StartLevelfirst(int scenenumber)
    {
        Application.LoadLevel(scenenumber);
    }

    public void ExitGame()
    {
        Application.Quit ();
    }

}
