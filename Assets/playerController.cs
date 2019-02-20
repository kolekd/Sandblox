using UnityEngine;

public class playerController : MonoBehaviour{

    public float speed = 10.0F;
    bool onGround = true;

    // Start is called before the first frame update
    void Start(){
        // disables mouse cursore in-game, to ulock cursor press esc
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update(){
        float forwards = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        forwards *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, forwards);

        RaycastHit hit;
        Vector3 jumpCentre = this.transform.position + this.GetComponent<BoxCollider>().center;

        if(Physics.Raycast(jumpCentre, Vector3.down, out hit, 0.5F))
        {
            if(hit.transform.gameObject.tag != "Player")
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
            Cursor.lockState = CursorLockMode.None;
    }
}
