using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SausageCamera: MonoBehaviour
{


    //FIRST PASS OF CODE!

    public Transform target;

    public Vector3 offset;

    public bool useOffsetValues;

    public float rotateSpeed;

    public Transform pivot;
    // Start is called before the first frame update
    void Start()
    {
        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }

        pivot.position = target.position;
        pivot.transform.parent = target.transform;

       // Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);

        float Vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(-Vertical, 0, 0);

        float desiredYAngle = target.eulerAngles.y;
        float desiredXAngle = pivot.eulerAngles.x;


        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);

        transform.LookAt(target);
    }
}

