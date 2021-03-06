﻿using System.Collections;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public enum RotationAxes
    {

        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2

    }

    public RotationAxes axes = RotationAxes.MouseXAndY;

    public float horizontalSensitivity = 9.0f;
    public float verticalSensitivity = 9.0f;

    public float verticalMin = -35.0f;
    public float verticalMax = 80.0f;

    public float _rotationX = 0;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.visible = false;

        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
        {

            body.freezeRotation = true;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
        if (axes == RotationAxes.MouseX)
        {

            transform.Rotate(0, Input.GetAxis("Mouse X") * horizontalSensitivity, 0);

        }
        else if (axes == RotationAxes.MouseY)
        {

            _rotationX -= Input.GetAxis("Mouse Y") * verticalSensitivity;
            _rotationX = Mathf.Clamp(_rotationX, verticalMin, verticalMax);

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);

        }
        else
        {

            _rotationX -= Input.GetAxis("Mouse Y") * verticalSensitivity;
            _rotationX = Mathf.Clamp(_rotationX, verticalMin, verticalMax);

            float delta = Input.GetAxis("Mouse X") * horizontalSensitivity;
            float rotationY = transform.localEulerAngles.y + delta;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);

        }

    }

}
