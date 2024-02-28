using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CCTVCameraContoller : MonoBehaviour
{
    public float turnSpeed = 5f;
    public float turnAngle = 90;
    bool turningRight = !true;
    Transform cameraLens;
    void Start()
    {
        Transform CameraPosition = transform.Find("CameraPosition");
        cameraLens = CameraPosition.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, Mathf.PingPong(Time.time, 9) * 10 - 45, 0));
    }

    void CheckIfPlayerVisible()
    {
        Debug.DrawRay(cameraLens.position, cameraLens.TransformDirection(Vector3.down) * 100, Color.yellow);
    }
}
                              