using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sharechoice : MonoBehaviour {
    public UnityEngine.UI.Text finalchoice;
	public void choice_one()
    {
        finalchoice.text = "50000 Shares each of worth $2";
    }
    public void choice_two()
    {
        finalchoice.text = "20000 Shares each of worth $5";
    }
    public void choice_three()
    {
        finalchoice.text = "10000 Shares each of worth $10";
    }


}
