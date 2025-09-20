using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextField : MonoBehaviour
{
    string word = null;
    public int wordIndex;
    string alpha = null;
    string alpha2 = null;
    public int maxText;
    public Text myName = null;
    public char[] nameChar = new char[0];
    public Text index = null;
    bool shift;
    public GameObject keyboard, keyboardShift;
    public DataText _dataText;

    bool clear;

    private void Start()
    {
        keyboardShift.SetActive(false);
        keyboard.SetActive(true);
    }

    public void shiftFunction()
    {
        if (!shift)
        {
            shift = true;
            keyboardShift.SetActive(true);
            keyboard.SetActive(false);
        }
        else
        {
            shift = false;
            keyboardShift.SetActive(false);
            keyboard.SetActive(true);
        }
        
    }

    public void nameFunc(string alphabet)
    {
        if (!shift)
        {
            if (wordIndex <= maxText - 1) addWord(alphabet);
        }
        else
        {
            if (wordIndex <= maxText-1)
            {
                addWord(alphabet);

                shift = false;
                keyboardShift.SetActive(false);
                keyboard.SetActive(true);
            }
        }
    }

    public void addWord(string alphat)
    {
        wordIndex++;
        char[] keepchar = alphat.ToCharArray();
        nameChar[wordIndex - 1] = keepchar[0];
        alpha = nameChar[wordIndex - 1].ToString();
        word += alpha;
        myName.text = word;
        index.text = wordIndex.ToString();
    }

    public void pallawaFunction(GameObject prefab)
    {
        _dataText.go[wordIndex-1] = prefab;
    }

    public void backspaceFunction()
    {
        if (wordIndex > 0)
        {
            nameChar[wordIndex - 1] = '\r';
            _dataText.go[wordIndex - 1] = null;
            wordIndex--;
            alpha2 = null;
            for(int i = 0; i < wordIndex + 1; i++)
            {
                alpha2 = alpha2 + nameChar[i].ToString();
            }
            word = alpha2;
            myName.text = word;
            index.text = wordIndex.ToString();
        }
    }

    // Clear text in text box
    public void clearFunction()
    {
        if(wordIndex > 0)
        {
            clear = true;
        }
    }

    private void Update()
    {
        if(clear)
        {
            for (int i =0; i < wordIndex; i++)
            {
                nameChar[wordIndex - 1] = '\r'; // key input spacebar
                _dataText.go[wordIndex - 1] = null;
                wordIndex--;
            }

            if(wordIndex <= 0)
            {
                _dataText.myword = null;
                word = null;
                myName.text = word;
                index.text = wordIndex.ToString();

                clear = false;
            }
            
        }
    }
}
