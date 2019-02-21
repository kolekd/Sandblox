using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask movementMask;
    public Interactable focus;
    public float speed = 10.0F;
    bool onGround = true;
    Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        // disables mouse cursore in-game, to ulock cursor press esc
        Cursor.lockState = CursorLockMode.Locked;
        cam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        float forwards = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        forwards *= Time.deltaTime;
        straffe *= Time.deltaTime;
        transform.Translate(straffe, 0, forwards);
        RaycastHit hit;
        Vector3 jumpCentre = this.transform.position + this.GetComponent<BoxCollider>().center;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit2;
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
//                Debug.Log("We Hit" + hit.collider.name + " " + hit.point);
            }

        }
        if (Physics.Raycast(jumpCentre, Vector3.down, out hit, 1F))
        {
            if (hit.transform.gameObject.tag != "Player")
            {
                onGround = true;
            }
        }
        else
        {
            onGround = false;
        }
        Debug.Log(onGround);
  

        //jumping
        if (Input.GetKeyDown("space") && onGround)
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
        //unlock cursor ingame
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
            //if(Physics.Raycast(ray, out hit, 100){
            //    Interactable interactable = hit.collider.GetComponent<Interactable>();
            //    if(interactable != null)
            //    {
            //        SetFocus(interactable);
            //    }
        }
    }
}

    //public void SetFocus(Interactable newFocus)
    //{
    //    focus = newFocus;
    //}

