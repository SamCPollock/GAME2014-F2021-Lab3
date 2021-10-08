using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class scr_GameController : MonoBehaviour
{
    public Rect screenRect;

    public Rect safeArea;

    public Rect backButtonRect;


    void Start()
    {
        backButtonRect = GameObject.Find("BackButton").GetComponent<RectTransform>().rect;
    }

    void Update()
    {
        screenRect = new Rect(0, 0, Screen.width, Screen.height);
        safeArea = Screen.safeArea;

        CheckOrientation();
    }

    void CheckOrientation()
    {
        switch (Screen.orientation)
        {
            case ScreenOrientation.LandscapeLeft:
                break;
            case ScreenOrientation.LandscapeRight:
                break;
            case ScreenOrientation.Portrait:
                break;
        }
    }
}
