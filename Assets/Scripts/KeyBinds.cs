using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBinds : MonoBehaviour
{
    public KeyCode Forward;
    public KeyCode Back;
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode Dash;
    public KeyCode Pickup;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Forward"))
            Forward = (KeyCode)PlayerPrefs.GetInt("Forward");
        else
            Forward = KeyCode.W;
        if (PlayerPrefs.HasKey("Back"))
            Back = (KeyCode)PlayerPrefs.GetInt("Back");
        else
            Back = KeyCode.S;
        if (PlayerPrefs.HasKey("Left"))
            Left = (KeyCode)PlayerPrefs.GetInt("Left");
        else
            Left = KeyCode.A;
        if (PlayerPrefs.HasKey("Right"))
            Right = (KeyCode)PlayerPrefs.GetInt("Right");
        else
            Right = KeyCode.D;
        if (PlayerPrefs.HasKey("Dash"))
            Dash = (KeyCode)PlayerPrefs.GetInt("Dash");
        else
            Dash = KeyCode.LeftShift;
        if (PlayerPrefs.HasKey("Pickup"))
            Pickup = (KeyCode)PlayerPrefs.GetInt("Pickup");
        else
            Pickup = KeyCode.Mouse0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
