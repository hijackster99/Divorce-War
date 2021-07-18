using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public KeyBinds binds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getKey(KeyCode key) {
        return Input.GetKey(key);
    }
    public bool getKeyDown(KeyCode key)
    {
        return Input.GetKeyDown(key);
    }
    public bool getKeyUp(KeyCode key)
    {
        return Input.GetKeyUp(key);
    }

    public bool anyKey() {
        return Input.anyKey;
    }
    public bool anyDirection()
    {
        return (getKey(binds.Forward) ^ getKey(binds.Back)) || (getKey(binds.Left) ^ getKey(binds.Right));
    }
}
