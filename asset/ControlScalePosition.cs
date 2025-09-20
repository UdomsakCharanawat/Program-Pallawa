using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlScalePosition : MonoBehaviour
{
    public RectTransform cardPallawa, cardName;
    public float scale;
    public float position;

    public GameObject cPallawa, cName;
    public bool pallawaSelect, nameSelect;

    private void Update()
    {
        if (pallawaSelect)
        {
            cPallawa.SetActive(true);
            cName.SetActive(false);
        }
        else if (nameSelect)
        {
            cPallawa.SetActive(false);
            cName.SetActive(true);
        }
        else if(!pallawaSelect & !nameSelect)
        {
            cPallawa.SetActive(false);
            cName.SetActive(false);
        }
    }

    public void backToSelectCard()
    {
        //pallawaSelect = false;
        //nameSelect = false;
    }

    public void cardPallawaSelect()
    {
        if (!pallawaSelect)
        {
            pallawaSelect = true;
            nameSelect = false;
        }
        //else
        //{
        //    pallawaSelect = false;
        //}
        
    }

    public void cardNameSelect()
    {
        if (!nameSelect)
        {
            pallawaSelect = false;
            nameSelect = true;
        }
        //else
        //{
        //    nameSelect = false;
        //}
        
    }


    public void ScaleUp()
    {
        if (pallawaSelect)
        {
            cardPallawa.localScale += new Vector3(scale, scale, 0);
        }
        else if (nameSelect)
        {
            cardName.localScale += new Vector3(scale, scale, 0);
        }
        
    }

    public void ScaleDown()
    {
        if (pallawaSelect)
        {
            cardPallawa.localScale -= new Vector3(scale, scale, 0);
        }
        else if (nameSelect)
        {
            cardName.localScale -= new Vector3(scale, scale, 0);
        }
    }

    public void GoRight()
    {
        if (pallawaSelect)
        {
            cardPallawa.anchoredPosition += new Vector2(position, 0);
        }
        else if (nameSelect)
        {
            cardName.anchoredPosition += new Vector2(position, 0);
        }
        
    }

    public void GoLeft()
    {
        if (pallawaSelect)
        {
            cardPallawa.anchoredPosition -= new Vector2(position, 0);
        }
        else if (nameSelect)
        {
            cardName.anchoredPosition -= new Vector2(position, 0);
        }
    }

    public void GoUp()
    {
        if (pallawaSelect)
        {
            cardPallawa.anchoredPosition += new Vector2(0, position);
        }
        else if (nameSelect)
        {
            cardName.anchoredPosition += new Vector2(0, position);
        }
    }

    public void GoDown()
    {
        if (pallawaSelect)
        {
            cardPallawa.anchoredPosition -= new Vector2(0, position);
        }
        else if (nameSelect)
        {
            cardName.anchoredPosition -= new Vector2(0, position);
        }
    }
}
