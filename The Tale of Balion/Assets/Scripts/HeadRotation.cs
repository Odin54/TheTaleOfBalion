using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    public Transform playerBody;
    public float HeadOffset;
    public float HeadRotateLimit;    //75
    private int CircleFullAngle = 360;

    void Update()
    {
        Vector3 Difference          = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float RawRotateZ            = Mathf.Atan2(Difference.y, Difference.x) * Mathf.Rad2Deg;
        float TrueRotateZ           = RawRotateZ + HeadOffset;
        float PlayerBodyZ           = playerBody.eulerAngles.z;
        if (RawRotateZ < 0)
        {
            RawRotateZ += CircleFullAngle;
        }
        if (RawRotateZ > CircleFullAngle)
        {
            RawRotateZ -= CircleFullAngle;
        }
        if (TrueRotateZ < 0)
        {
            TrueRotateZ += CircleFullAngle;
        }
        if (TrueRotateZ > CircleFullAngle)
        {
            TrueRotateZ -= CircleFullAngle;
        }
        float BodyHeadDifference    = PlayerBodyZ - TrueRotateZ;

        if (BodyHeadDifference > (CircleFullAngle / 2))
        {
            BodyHeadDifference -= CircleFullAngle;
        }
        if (BodyHeadDifference < -(CircleFullAngle / 2))
        {
            BodyHeadDifference += CircleFullAngle;
        }

        if (BodyHeadDifference > -HeadRotateLimit) 
        {
            if (BodyHeadDifference < HeadRotateLimit)
            {
                transform.rotation  = Quaternion.Euler(0f, 0f, TrueRotateZ);
            }
        }
    }
}
