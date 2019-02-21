using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{
    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0)) GetComponent<Animation>().Play("Half_Open");
        if (Input.GetMouseButtonUp(1)) GetComponent<Animation>().Play("Half_Close");
    }
}
