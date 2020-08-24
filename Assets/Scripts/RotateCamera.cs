using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public Transform lookAt;
    private Transform camTransform;
    public float minYAngle = 0f;
    public float maxYAngle = 70f;

    private float distance;
    private float currentX;
    private float currentY;

    private void Start()
    {
        distance = 10f;
        currentX = 0f;
        currentY = 0f;
        camTransform = transform;
    }

    private void Update()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);

        if (Input.GetMouseButton(0))
        {
            currentX += Input.GetAxis("Mouse X");
            currentY += Input.GetAxis("Mouse Y");
            currentY = Mathf.Clamp(currentY, minYAngle, maxYAngle);
        }

    }
}
