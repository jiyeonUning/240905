using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] float sesitivity = 8f; // ���콺 �ΰ���
    public float rotationX = 0f; // = X�� ��ġ
    public float rotationY = 0f; // = Y�� ��ġ

    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;

    void LateUpdate()
    {
        MouseMove();
        if (Input.GetMouseButton(1) == false) return;
        MouseRotate();
    }

    void MouseRotate()
    {
        rotationX += Input.GetAxis("Mouse X") * sesitivity;
        rotationY -= Input.GetAxis("Mouse Y") * sesitivity;

        rotationY = Mathf.Clamp(rotationY, -90f, 90f);
        transform.localEulerAngles = new Vector3 (rotationY, rotationX, 0);
    }

    void MouseMove()
    {
        transform.position = target.position + offset;
        transform.LookAt(transform.position);
    }
}
