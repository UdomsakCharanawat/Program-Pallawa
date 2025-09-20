using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doozy.Engine.UI;

public class DataText : MonoBehaviour
{
    public GameObject[] go;
    GameObject make1, make2, make3, make4, make5, make6, make7;
    GameObject make;
    public GameObject[] newParent;

    public TextField _textField;

    public Text[] myText;
    public string myword;

    public int numberCard;
    public Material[] matCard;
    public Image imgCard;
    public GridLayoutGroup[] gridSelect;
    public RectTransform[] rectSelect;
    public GridLayoutGroup gridCard;
    public RectTransform rectCard;
    public Text[] textSelect;
    public RectTransform[] textRectSelect;
    public Text textCard;
    public RectTransform textRectCard;
    public UIButton okButtonPageViewCard;

    private void Update()
    {
        GameObject mockup = GameObject.FindGameObjectWithTag("delete");
        Destroy(mockup);


        if (numberCard == 0)
        {
            okButtonPageViewCard.enabled = false;
        }
        else if (numberCard != 0)
        {
            okButtonPageViewCard.enabled = true;
        }
    }

    public void destroyOBJ()
    {
        // Destroy object in parent Group pallawa
        //////////////////////////////////////////////////////for(int i = 0; i < newParent[0].transform.childCount; i++)
        //////////////////////////////////////////////////////    Destroy(newParent[0].transform.GetChild(i).gameObject);
        //////////////////////////////////////////////////////for (int i = 0; i < newParent[1].transform.childCount; i++)
        //////////////////////////////////////////////////////    Destroy(newParent[1].transform.GetChild(i).gameObject);
        //////////////////////////////////////////////////////for (int i = 0; i < newParent[2].transform.childCount; i++)
        //////////////////////////////////////////////////////    Destroy(newParent[2].transform.GetChild(i).gameObject);
        //////////////////////////////////////////////////////for (int i = 0; i < newParent[3].transform.childCount; i++)
        //////////////////////////////////////////////////////    Destroy(newParent[3].transform.GetChild(i).gameObject);
        //////////////////////////////////////////////////////for (int i = 0; i < newParent[4].transform.childCount; i++)
        //////////////////////////////////////////////////////    Destroy(newParent[4].transform.GetChild(i).gameObject);
        //////////////////////////////////////////////////////for (int i = 0; i < newParent[5].transform.childCount; i++)
        //////////////////////////////////////////////////////    Destroy(newParent[5].transform.GetChild(i).gameObject);

        //////////////////////////////////////////////////////for (int i = 0; i < newParent[6].transform.childCount; i++)
        //////////////////////////////////////////////////////    Destroy(newParent[6].transform.GetChild(i).gameObject);
        for(int i = 0; i < newParent.Length; i++)
        {
            for(int a = 0;a < newParent[i].transform.childCount; a++)
            {
                Destroy(newParent[i].transform.GetChild(a).gameObject);
            }
        }


        for(int i =0; i < myText.Length; i++)
        {
            myText[i].text = "";
        }

        //////////////////////////////////////////////////////myText[0].text = "";
        //////////////////////////////////////////////////////myText[1].text = "";
        //////////////////////////////////////////////////////myText[2].text = "";
        //////////////////////////////////////////////////////myText[3].text = "";
        //////////////////////////////////////////////////////myText[4].text = "";
        //////////////////////////////////////////////////////myText[5].text = "";

        //////////////////////////////////////////////////////myText[6].text = "";

        _textField.clearFunction();
    }

    public void createWord()
    {
        for (int i = 0; i < _textField.wordIndex; i++)
        {
            //Write text name

            //Debug.Log(myword = myword + _textField.nameChar[i].ToString());
            myword = myword + _textField.nameChar[i].ToString();
            for(int a = 0;a < myText.Length; a++)
            {
                myText[a].text = myword;
            }
            ////////////////////////////////////////////////////////myText[0].text = myword;
            ////////////////////////////////////////////////////////myText[1].text = myword;
            ////////////////////////////////////////////////////////myText[2].text = myword;
            ////////////////////////////////////////////////////////myText[3].text = myword;
            ////////////////////////////////////////////////////////myText[4].text = myword;
            ////////////////////////////////////////////////////////myText[5].text = myword;

            ////////////////////////////////////////////////////////myText[6].text = myword;

            // Create Object text pallawa
            //Debug.Log(make = Instantiate(go[i], new Vector3(0, 0, 0), Quaternion.identity) as GameObject);
            //make1 = Instantiate(go[i], new Vector3(0, 0, 0), Quaternion.identity, newParent[0].transform);
            //////////////////////////////////////////////////////////////make1 = Instantiate(go[i], new Vector3(0, 0, 0), Quaternion.identity);
            //////////////////////////////////////////////////////////////make1.transform.parent = newParent[0].transform;

            //////////////////////////////////////////////////////////////make2 = Instantiate(go[i], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            //////////////////////////////////////////////////////////////make2.transform.parent = newParent[1].transform;

            //////////////////////////////////////////////////////////////make3 = Instantiate(go[i], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            //////////////////////////////////////////////////////////////make3.transform.parent = newParent[2].transform;

            //////////////////////////////////////////////////////////////make4 = Instantiate(go[i], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            //////////////////////////////////////////////////////////////make4.transform.parent = newParent[3].transform;

            //////////////////////////////////////////////////////////////make5 = Instantiate(go[i], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            //////////////////////////////////////////////////////////////make5.transform.parent = newParent[4].transform;

            //////////////////////////////////////////////////////////////make6 = Instantiate(go[i], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            //////////////////////////////////////////////////////////////make6.transform.parent = newParent[5].transform;


            //////////////////////////////////////////////////////////////make7 = Instantiate(go[i], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            //////////////////////////////////////////////////////////////make7.transform.parent = newParent[6].transform;

            for(int b = 0; b < newParent.Length; b++)
            {
                make = Instantiate(go[i], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                make.transform.parent = newParent[b].transform;
            }
        }
    }

    public void selectNumberCard(int c)
    {
        numberCard = c;

        if (numberCard != 0)
        {
            imgCard.material = matCard[numberCard - 1];
            gridCard.cellSize = gridSelect[numberCard - 1].cellSize * 3.75f;
            gridCard.spacing = -gridSelect[numberCard - 1].spacing * 0.65f;
            gridCard.childAlignment = gridSelect[numberCard - 1].childAlignment;
            rectCard.sizeDelta = rectSelect[numberCard - 1].sizeDelta;
            rectCard.anchoredPosition = rectSelect[numberCard - 1].anchoredPosition;
            textCard.fontSize = textSelect[numberCard - 1].fontSize;
            textCard.alignment = textSelect[numberCard - 1].alignment;
            textRectCard.sizeDelta = textRectSelect[numberCard - 1].sizeDelta;
            textRectCard.anchoredPosition = textRectSelect[numberCard - 1].anchoredPosition;
        }

        /*if(numberCard == c)
        {
           // transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        }
        else
        {
           // transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
        }*/
    }
}
