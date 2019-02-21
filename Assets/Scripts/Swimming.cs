using UnityEngine;

public class Swimming : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
    }

    bool IsUnderWater()
    {
        return gameObject.transform.position.y < 16.0F;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsUnderWater())
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;

        }
    }
}
