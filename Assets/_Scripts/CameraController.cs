using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    [Header ("Rotation Limitation")]
    [SerializeField] private float maxUp;
    [SerializeField] private float maxDown;
    [SerializeField] private float maxLeft;
    [SerializeField] private float minRight;

    float xRotation = 0f;
    float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        Vector3 rot = transform.localRotation.eulerAngles;
        yRotation = rot.y;
        xRotation = rot.x;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY; 
        yRotation += mouseX;

        xRotation = Mathf.Clamp(xRotation, maxUp, maxDown);
        yRotation = Mathf.Clamp(yRotation, maxLeft, minRight);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
