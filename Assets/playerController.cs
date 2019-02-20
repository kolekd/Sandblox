using UnityEngine;

public class playerController : MonoBehaviour{

    public float speed = 10.0F;

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

        //unlock cursor ingame
        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
}
