using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;

    public float dist = 5f;

    public float xSpeed = 220.0f;
    public float ySpeed = 100.0f;

    private float x = 0.0f;
    private float y = 0.0f;

    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;

    float ClampAngle(float angle,float min,float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle = -360;
        return Mathf.Clamp(angle, min, max);
    }
    private Transform cam;

    void Start()
    {
        cam = GetComponent<Transform>();
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }

    // Update is called once per frame
    void LateUpdate()//업데이트 하고 뒤에 따라붙는 얘들
    {
        if (target)
        {
            dist -= .5f * Input.mouseScrollDelta.y;
            if (dist < 0.5)
            {
                dist = 1;
            }
            if (dist >= 10)
            {
                dist = 10;
            }

            x += Input.GetAxis("Mouse X") * xSpeed * 0.01f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

            y = ClampAngle(y, yMinLimit, yMaxLimit);




            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector3(0.652f, 5.8f, -10f) + target.position ;

            transform.rotation = rotation;
            transform.position = position ;

        }
    }
}
