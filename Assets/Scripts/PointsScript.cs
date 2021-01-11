//using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsScript : MonoBehaviour
{
    public int points = 0;
    Vector2 nativeSize = new Vector2(640, 480);
    public GameObject Day;
    public GameObject Night;

    public Font newfont;
    void OnGUI()
    {
    
    GUIStyle style = new GUIStyle();
        style.fontSize = (int)(20.0f * ((float)Screen.width / (float)nativeSize.x));
        style.normal.textColor = Color.cyan;
        style.font = newfont;

        GUI.Label(new Rect(10, 10, 100, 20), "Gems : " + points, style);
        GUI.Label(new Rect(10, 60, 100, 20), "Use \"Z\" for Night\nand \"X\" for Day", style);

        GUIStyle style2 = new GUIStyle();
        style2.fontSize = (int)(20.0f * ((float)Screen.width / (float)nativeSize.x));
        style2.normal.textColor = Color.black;
        style2.font = newfont;

        if (Day.activeSelf)
        {
            GUI.Label(new Rect(1800, 10, 100, 20), "Day", style);
            GUI.Label(new Rect(1800, 60, 100, 20), "Night", style2);
        }

        if (!(Day.activeSelf))
        {
            GUI.Label(new Rect(1800, 10, 100, 20), "Day", style2);
            GUI.Label(new Rect(1800, 60, 100, 20), "Night", style);
        }



    }
}
