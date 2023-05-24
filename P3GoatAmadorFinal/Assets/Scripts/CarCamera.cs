using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCamera : MonoBehaviour
{
    public Transform carTransform;     // Reference to the car's transform
    public Vector3 cameraOffset;       // Offset from the car's position

    public float smoothSpeed = 0.5f;   // Speed of camera movement
    public float rotationDamping = 5f; // Speed of camera rotation

    private Vector3 desiredPosition;   // Position the camera wants to be in
    private Quaternion desiredRotation; // Rotation the camera wants to have

    private void LateUpdate()
    {
        // Calculate the desired position and rotation based on the car's position
        desiredPosition = carTransform.position + carTransform.TransformDirection(cameraOffset);
        desiredRotation = Quaternion.LookRotation(carTransform.position - desiredPosition, carTransform.up);

        // Smoothly move the camera towards the desired position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Smoothly rotate the camera towards the desired rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, rotationDamping * Time.deltaTime);
    }
}

