using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlGroupPageCard : MonoBehaviour
{
    public Transform posRight, posCenter, posLeft;
    public Transform movePage1, movePage2;
    public Button buttonPage1, buttonPage2;
    public bool selectPage1, selectPage2;
    public int speed;

    void Update()
    {
        if (selectPage2)
        {
            movePage1.transform.position = Vector2.MoveTowards(movePage1.transform.position, posRight.transform.position, Time.deltaTime * 100 * speed);
            movePage2.transform.position = Vector2.MoveTowards(movePage2.transform.position, posCenter.transform.position, Time.deltaTime * 100 * speed);

            if (movePage1.transform.position == posRight.transform.position && movePage2.transform.position == posCenter.transform.position)
            {
                selectPage2 = false;
            }
        }

        if (selectPage1)
        {
            movePage2.transform.position = Vector2.MoveTowards(movePage2.transform.position, posLeft.transform.position, Time.deltaTime * 100 * speed);
            movePage1.transform.position = Vector2.MoveTowards(movePage1.transform.position, posCenter.transform.position, Time.deltaTime * 100 * speed);

            if (movePage2.transform.position == posLeft.transform.position && movePage1.transform.position == posCenter.transform.position)
            {
                selectPage1 = false;
            }
        }

        if(!selectPage1 && !selectPage2)
        {
            buttonPage1.enabled = true;
            buttonPage2.enabled = true;
        }
        
    }

    public void resetPos()
    {
        movePage1.transform.position = posCenter.transform.position;
        movePage2.transform.position = posLeft.transform.position;
    }

    public void clickPage1()
    {
        selectPage1 = true;
        buttonPage1.enabled = false;
        buttonPage2.enabled = false;
    }

    public void clickPage2()
    {
        selectPage2 = true;
        buttonPage1.enabled = false;
        buttonPage2.enabled = false;
    }
}
