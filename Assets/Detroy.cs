using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detroy : MonoBehaviour
{
    private void OnColliderStay2D(Collider other)
    {
        if (other.tag == "Place1" && !DragControl.isDrag)
        {
            Destroy(gameObject, 1);
        }
    }
}
