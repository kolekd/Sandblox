using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyQuit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyQuit))
            Application.Quit();
    }
}
