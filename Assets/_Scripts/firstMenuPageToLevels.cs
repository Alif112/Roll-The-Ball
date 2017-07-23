using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class firstMenuPageToLevels : MonoBehaviour {
    // Assign /Initilize from Editor or code
    //public Button levelButton2;

    //public float  x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6, x7, y7, x8, y8, x9, y9, x10, y10;
    public GUISkin theSkin;
    public Texture2D star1, star2, star3, lockedImage, unlockedImage,backimage,nextimage;
    
    
    GUIContent content1 = new GUIContent();
    GUIContent content2 = new GUIContent();
    GUIContent content3 = new GUIContent();
    GUIContent content4 = new GUIContent();
    GUIContent content5 = new GUIContent();
    GUIContent content6 = new GUIContent();
    GUIContent content7 = new GUIContent();
    GUIContent content8 = new GUIContent();
    GUIContent content9 = new GUIContent();
    GUIContent content10 = new GUIContent();
    GUIContent content11 = new GUIContent();
    GUIContent content12 = new GUIContent();


    bool locked2 = true;
    bool locked3 = true;
    bool locked4 = true;
    bool locked5 = true;
    bool locked6 = true;
    bool locked7 = true;
    bool locked8 = true;
    bool locked9 = true;
    bool locked10 = true;


    void Start()
    {
        //PlayerPrefs.DeleteAll();
        content1.image = (Texture2D)unlockedImage;
        PlayerPrefs.SetInt("PrevTime", 0);

        content11.image = (Texture2D)backimage;
        content12.image = (Texture2D)nextimage;

        content2.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level1Passed") == 10)
        {
            //Debug.Log("lev1 p called");
            if (PlayerPrefs.GetInt("Level1Score") == 1) content1.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level1Score") == 2) content1.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level1Score") == 3) content1.image = (Texture2D)star3;

            content2.image = (Texture2D)unlockedImage;
        }

        content3.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level2Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level2Score") == 1) content2.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level2Score") == 2) content2.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level2Score") == 3) content2.image = (Texture2D)star3;

            content3.image = (Texture2D)unlockedImage;
        }

        content4.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level3Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level3Score") == 1) content3.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level3Score") == 2) content3.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level3Score") == 3) content3.image = (Texture2D)star3;

            content4.image = (Texture2D)unlockedImage;
        }

        content5.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level4Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level4Score") == 1) content4.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level4Score") == 2) content4.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level4Score") == 3) content4.image = (Texture2D)star3;

            content5.image = (Texture2D)unlockedImage;
        }

        content6.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level5Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level5Score") == 1) content5.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level5Score") == 2) content5.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level5Score") == 3) content5.image = (Texture2D)star3;

            content6.image = (Texture2D)unlockedImage;
        }

        content7.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level6Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level6Score") == 1) content6.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level6Score") == 2) content6.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level6Score") == 3) content6.image = (Texture2D)star3;

            content7.image = (Texture2D)unlockedImage;
        }


        content8.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level7Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level7Score") == 1) content7.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level7Score") == 2) content7.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level7Score") == 3) content7.image = (Texture2D)star3;

            content8.image = (Texture2D)unlockedImage;
        }

        content9.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level8Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level8Score") == 1) content8.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level8Score") == 2) content8.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level8Score") == 3) content8.image = (Texture2D)star3;

            content9.image = (Texture2D)unlockedImage;
        }

        content10.image = (Texture2D)lockedImage;
        if (PlayerPrefs.GetInt("Level9Passed") == 10)
        {
            if (PlayerPrefs.GetInt("Level9Score") == 1) content9.image = (Texture2D)star1;
            if (PlayerPrefs.GetInt("Level9Score") == 2) content9.image = (Texture2D)star2;
            if (PlayerPrefs.GetInt("Level9Score") == 3) content9.image = (Texture2D)star3;

            content10.image = (Texture2D)unlockedImage;
        }

 



    }
    void OnGUI() {
        GUI.skin = theSkin;

        if (GUI.Button(new Rect(40,60, 70, 50), content1))
        {
            Application.LoadLevel(2);
        }

        if (GUI.Button(new Rect(140 , 60 , 70 , 50), content2))
        {
            if(PlayerPrefs.GetInt("Level1Passed")==10)
                Application.LoadLevel(4);
         
        }

        if (GUI.Button(new Rect(240, 60, 70, 50), content3))
        {
            if (PlayerPrefs.GetInt("Level2Passed") == 10)
                Application.LoadLevel(6);
        }

        if (GUI.Button(new Rect(340, 60, 70, 50), content4))
        {
            if (PlayerPrefs.GetInt("Level3Passed") == 10)
                Application.LoadLevel(8);

        }
        if (GUI.Button(new Rect(440, 60, 70, 50), content5))
        {
            if (PlayerPrefs.GetInt("Level4Passed") == 10)
                Application.LoadLevel(10);
        }

        if (GUI.Button(new Rect(40, 160, 70, 50), content6))
        {
            if (PlayerPrefs.GetInt("Level5Passed") == 10)
                Application.LoadLevel(12);

        }
        if (GUI.Button(new Rect(140, 160, 70, 50), content7))
        {
            if (PlayerPrefs.GetInt("Level6Passed") == 10)
                Application.LoadLevel(14);
        }

        if (GUI.Button(new Rect(240, 160, 70, 50), content8))
        {
            if (PlayerPrefs.GetInt("Level7Passed") == 10)
                Application.LoadLevel(16);

        }
        if (GUI.Button(new Rect(340, 160, 70, 50), content9))
        {
            if (PlayerPrefs.GetInt("Level8Passed") == 10)
                Application.LoadLevel(18);
        }

        if (GUI.Button(new Rect(440, 160, 70, 50), content10))
        {
            if (PlayerPrefs.GetInt("Level9Passed") == 10)
                Application.LoadLevel(20);

        }
        if (GUI.Button(new Rect(40, 250, 60, 40), content11))
        {

            Application.LoadLevel(0);

        }
        if (GUI.Button(new Rect(440, 250, 60, 40), content12))
        {
            

        }



    }




    public void fromFirstMenuPageToLevel1(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
        
    }

    public void fromFirstMenuPageToLevel2(int scenetochange)
    {
        if (PlayerPrefs.GetInt("Level2Unlocked") == 2)
        {
               
            Application.LoadLevel(scenetochange);
            //levelButton2.image.sprite = Unlocked;
        }
    }
    public void fromFirstMenuPageToLevel3(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
    public void fromFirstMenuPageToLevel4(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
    public void fromFirstMenuPageToLevel5(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
    public void fromFirstMenuPageToLevel6(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
    public void fromFirstMenuPageToLevel7(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
    public void fromFirstMenuPageToLevel8(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }
    public void fromFirstMenuPageToLevel9(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }

    public void fromFirstMenuPageToLevel10(int scenetochange)
    {
        Application.LoadLevel(scenetochange);
    }




}
