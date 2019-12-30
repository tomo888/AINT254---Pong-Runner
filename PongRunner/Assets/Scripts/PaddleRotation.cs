using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRotation : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.Rotate(0, 45, 0);
    }

}
