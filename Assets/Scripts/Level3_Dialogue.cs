using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3_Dialogue : MonoBehaviour {
    public UnityEngine.UI.Text currentText;
    public void changeText(int seqnumber)
    {
        switch(seqnumber)
        {
            case 1: currentText.text = "Hi, there.";break;
            case 2: currentText.text = "Hello";break;
            case 3: currentText.text = "I just learnt about the basics of banking. I want to know more"; break;

        }
    }
	
}
