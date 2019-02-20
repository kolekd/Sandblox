using UnityEngine;

public class mouseCameraController : MonoBehaviour{
    //keeps track of mouse movement
    Vector2 mouseLook;
    // this is magic it smooths the mouse movement... lol
    Vector2 mouseSmooth;
    public float mouseSensitivity = 5.0F;
    public float smoothing = 2.0F;
    //object for our character and is set uped in Start method
    GameObject player;

    // Start is called before the first frame update
    void Start(){
        //the plazer character is parent of the main camera si here ve are pointing to our character
        player = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update(){
        //after each update ve get mouse movement and its change
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        //multipling change bz sensitivitz and smoothing
        md = Vector2.Scale(md, new Vector2(mouseSensitivity * smoothing, mouseSensitivity * smoothing));
        // lerp = linear interpertation of movement - it makes camera to move smoothlz no instantlz from one direction to other
        mouseSmooth.x = Mathf.Lerp(mouseSmooth.x, md.x, 1F / smoothing);
        mouseSmooth.y = Mathf.Lerp(mouseSmooth.y, md.y, 1F / smoothing);
        mouseLook += mouseSmooth;

        //magic
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);

    }
}
