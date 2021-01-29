using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchManager : MonoBehaviour
{

    public Text textSearched;
    public Text textBord;
    public Text outPutText;
    bool enter = false;

    public string searchedWord;
    public string bordWord;

    // Start is called before the first frame update
    void Start()
    {
        textBord.text = "Lemon " + "\r\n" + "Banana"+ "\r\n"+"Coconat"+ "\r\n" +"Orage"+ "\r\n"+ "Mango";
        ////print("texB"+textBord.text);
        ////print("texS" + textSearched.text);
    }

    // Update is called once per frame
    void Update()
    {
        //searchedWord = textSearched.text;
        //print("texS" + searchedWord);
        ////bordWord = textBord.text;

        if (Input.GetKeyDown(KeyCode.Return))
        //if(enter == true)
        {
            //bordWord = textBord.text;
            if (bordWord.Contains(searchedWord))
            {

            Debug.Log("This one works");
            outPutText.text = "<color=#008000>" + textSearched.text + "</color>" + " is found";


        }
        //else if (textSearched.text.StartsWith("/Add"))
        //{
        //    textBord.text = textBord.text  + textSearched.text + "\r\n";
        //    //}
        else
        {
            outPutText.text = "<color=#ff0000>" + textSearched.text + "</color>" + " isn't found";


        }
    }

}


    public void EnterButton(string searchedWorded)
    {
        enter = true;
        print(enter);
        //searchedWorded = searchedWord;
        //print("texS" + searchedWorded);
        //if (textBord.text.Contains(searchedWord))
        //{

        //    Debug.Log("This one works");
        //    outPutText.text = "<color=#008000>" + textSearched.text + "</color>" + " is found";


        //}
   
        //else
        //{
        //    outPutText.text = "<color=#ff0000>" + textSearched.text + "</color>" + " isn't found";


        //}
    }
    private void Null()
    {

    }
}
