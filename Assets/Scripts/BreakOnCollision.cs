using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            //  Destroy(GetComponent<Rigidbody>());
            //            GetComponent<Rigidbody>().velocity += new Vector3(0 , 0, 20);


            //            for(int i = 0; i < collision.contactCount; i++)
            //            {
            //                Renderer renderer = collision.contacts[0].thisCollider.GetComponent<Renderer>();
            //                renderer.material.shader = Shader.Find("_Color");
            //                renderer.material.SetColor("_Color", Color.cyan);
            // CHILD OF PARENT CHANGES ON CONTACT
            //            }

            Destroy(GetComponent<Rigidbody>());

            Component[] components = GetComponentsInChildren<Component>();

            foreach(Component value in components)
            {
                value.gameObject.AddComponent<Rigidbody>();
                value.gameObject.AddComponent<PickUp>();
            }

//            Renderer[] renderer = GetComponentsInChildren<Renderer>();
//                       
//            foreach(Renderer value in renderer)
//            {
//                value.material.shader = Shader.Find("_Color");
//                value.material.SetColor("_Color", Color.cyan);
//            }

        }
    }

}
