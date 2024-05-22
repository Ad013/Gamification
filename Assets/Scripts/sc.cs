using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc : MonoBehaviour {
    public UnityEngine.UI.Text scoreText;
    public GameObject conver;
    public float restartdelay = 0.5f;
    void restart()
    {
        scoreText.text = "End of conversation";
        FindObjectOfType<control>().resetval();
        conver.SetActive(false);
    }
    public void na_employee(int x,int y)
    {
        if (x == 1)
            scoreText.text = "Employee : Good Morning. ";
        if (y == 1)
            scoreText.text = "You : Thank you";
        if (x == 2)
            scoreText.text = "Employee : How may I help You?";
        if (y == 2)
            scoreText.text = "You : I like to know how bank works";
        if (x == 3)
            scoreText.text = "Employee : Sure sir/madam "; 
        if (y>2 || x>3)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);
        }
    }
    public void de_employee(int x, int y)
    {
        if (x == 1)
            scoreText.text = "Employee : Welcome to deposit ";
        if (y == 1)
            scoreText.text = "You : what is deposit";
        if (x == 2)
            scoreText.text = "Employee : You give your money to us for safe keeping";
        if (y == 2)
            scoreText.text = "You : so is it secure";
        if (x == 3)
            scoreText.text = "Employee : Not if we are bankrupt ";
        if (y > 2 || x > 3)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);
        }
    }
    public void wi_employee(int x, int y)
    {
        if (x == 1)
            scoreText.text = "Employee : Welcome to withdrawl ";
        if (y == 1)
            scoreText.text = "You : How can I withdawl my money";
        if (x == 2)
            scoreText.text = "Employee : You have to fill-up your details and ammount";
        if (y == 2)
            scoreText.text = "You : thats it ??";
        if (x == 3)
            scoreText.text = "Employee : And you need to have the amount in your account";
        if (y > 2 || x > 3)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);

        }

    }
    public void ch_employee(int x, int y)
    {
        if (x == 1)
            scoreText.text = "Employee : How may I help You? ";
        if (y == 1)
            scoreText.text = "You : What is a cheque";
        if (x == 2)
            scoreText.text = "Employee : It is your permission to us to grant an amount to the cheque bearer";
        if (y == 2)
            scoreText.text = "You : so no cash uaha";
        if (x == 3)
            scoreText.text = "Employee : yo ";
        if (y > 2 || x > 3)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);
        }

    }
    public void pu_employee(int x, int y)
    {
        if (x == 1)
            scoreText.text = "You : What is passbook update";
        if (y == 1)
            scoreText.text = "Employee : We show you your transaction";        
        if (x == 2)
            scoreText.text = "You : is it free ??";
        if (y == 2)
            scoreText.text = "Employee : Yes";
        if (y > 2 || x > 2)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);
        }


    }
    public void bm_employee(int x, int y)
    {
        if (x == 1)
            scoreText.text = "Manager : Good Morning. ";
        if (y == 1)
            scoreText.text = "You : Same to you too";
        if (x == 2)
            scoreText.text = "Manager : did you get answers to your questions ";
        if (y == 2)
            scoreText.text = "You : Yes I did";
        if (x == 3)
            scoreText.text = "Manager : Have a good day ";
        if (y > 2 || x > 3)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);
        }
    }
    
}
