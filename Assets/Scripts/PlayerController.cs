using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform leftFlipper;
    public Transform rightFlipper;

    public Quaternion leftRotationStart;
    public Quaternion rightRotationStart;

    public float rotateSpeed = 2f;

    void Update()
    {
        Quaternion leftTarget = Quaternion.Euler(0, 0, 80);
        if (Input.GetKey(KeyCode.A) && leftFlipper.rotation.z < leftTarget.z)
        {
            leftFlipper.rotation = leftFlipper.rotation * Quaternion.Euler(0, 0, rotateSpeed);
        }
        else if (leftFlipper.rotation.z > 0)
        {
            leftFlipper.rotation = leftFlipper.rotation * Quaternion.Euler(0, 0, -rotateSpeed);
        }

        Quaternion rightTarget = Quaternion.Euler(0, 0, -80);
        if (Input.GetKey(KeyCode.D) && rightFlipper.rotation.z > rightTarget.z)
        {
            rightFlipper.rotation = rightFlipper.rotation * Quaternion.Euler(0, 0, -rotateSpeed);
        }
        else if (rightFlipper.rotation.z < 0)
        {
            rightFlipper.rotation = rightFlipper.rotation * Quaternion.Euler(0, 0, rotateSpeed);
        }
    }
}
