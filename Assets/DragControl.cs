using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragControl : MonoBehaviour
{
    public GameObject itemOne, itemTwo, itemThree, itemFour;
    Vector2 itemOneInitial, itemTwoInitial, itemThreeInitial, itemFourInitial;
    public Canvas canvas;
    public static bool isDrag;

    void Start()
    {
        itemOneInitial = itemOne.transform.position;
        itemTwoInitial = itemTwo.transform.position;
        itemThreeInitial = itemThree.transform.position;
        itemFourInitial = itemFour.transform.position;
        isDrag = false;
    }

    public void DragitemOne()
    {
        itemOne.transform.position = Input.mousePosition;
    }

    public void DragitemTwo()
    {
        itemTwo.transform.position = Input.mousePosition;
    }

    public void DragitemThree()
    {
        itemThree.transform.position = Input.mousePosition;
    }

    public void DragitemFour()
    {
        itemFour.transform.position = Input.mousePosition;
    }

    private void OnMouseDown()
    {
        isDrag = true;
        Debug.Log("true");
    }

    private void OnMouseUp()
    {
        isDrag = false;
        Debug.Log("false");
    }
}