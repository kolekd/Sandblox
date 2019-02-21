using UnityEngine;

public class MouseCameraController : MonoBehaviour
{
    public string mouseXName, mouseYName;
    public float mouseSensitivity;
    private float xAxisClamp;
    public Transform playerBody;

    void Start()
    {
        xAxisClamp = 0.0F;
    }
    // Update is called once per frame
    void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYName) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if(xAxisClamp > 90.0F)
        {
            xAxisClamp = 90.0F;
            mouseY = 0.0F;
            ClampXaxisRotation(270.0F);
        }

        else if (xAxisClamp < -90.0F)
        {
            xAxisClamp = -90.0F;
            mouseY = 0.0F;
            ClampXaxisRotation(90.0F);

        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ClampXaxisRotation(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
