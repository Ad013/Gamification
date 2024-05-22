using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc2 : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    public GameObject conver;
    public float restartdelay = 0.5f;
    void restart()
    {
        scoreText.text = "End of conversation";
        FindObjectOfType<control>().resetval();
        conver.SetActive(false);
    }
    public void Loan_Eq(int x, int y)
    {
        if (x == 1)
            scoreText.text = "Employee : Good Morning. ";
        if (y == 1)
            scoreText.text = "You : Thank you";
        if (x == 2)
            scoreText.text = "Employee : How may I help You?";
        if (y == 2)
            scoreText.text = "You : I like to know how loan works";
        if (x == 3)
            scoreText.text = "Employee : Sure sir/madam ";
        if (y > 2 || x > 3)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);
        }
    }
    public void Loan_Home(int x, int y)
    {
        if (x == 1)
            scoreText.text = "Employee : Welcome to Home Loan ";
        if (y == 1)
            scoreText.text = "You : what is Home Loan";
        if (x == 2)
            scoreText.text = "Employee : We give you money to by a house";
        if (y == 2)
            scoreText.text = "You : So I can live in it and need not repay you";
        if (x == 3)
            scoreText.text = "Employee : No we will have the papers of the house ";
        if (y > 2 || x > 3)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);
        }
    }
    public void Loan_Per(int x, int y)
    {
        if (x == 1)
            scoreText.text = "Employee : Welcome to Personal ";
        if (y == 1)
            scoreText.text = "You : So I can take money for anything";
        if (x == 2)
            scoreText.text = "Employee : Kind of";
        if (y == 2)
            scoreText.text = "You : Thats good";
        if (x == 3)
            scoreText.text = "Employee : Yes it is";
        if (y > 2 || x > 3)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);

        }
    }
    public void Loan_Car(int x, int y)
    {
        if (x == 1)
            scoreText.text = "You : What is Car Loan";
        if (y == 1)
            scoreText.text = "Employee : You can by a car with the loan";
        if (x == 2)
            scoreText.text = "You : Can I buy a Bike with it";
        if (y == 2)
            scoreText.text = "Employee : No ony cars no bikes or helicopters";
        if (y > 2 || x > 2)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);
        }
    }
    public void Loan_Edu(int x, int y)
    {
        if (x == 1)
            scoreText.text = "You : How Education loan is helpful";
        if (y == 1)
            scoreText.text = "Employee : If somebody need to study and lacks money then it comes in handy";
        if (x == 2)
            scoreText.text = "You : Can any body have it ";
        if (y == 2)
            scoreText.text = "Employee : Only students may have it";
        if (y > 2 || x > 2)
        {
            FindObjectOfType<PointCount>().setPoint();
            Invoke("restart", restartdelay);
        }
    }
    public void Loan_Boss(int x, int y)
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
