using UnityEngine;


public class PlayerCollision : MonoBehaviour {

    //public GameManeger game;
    public GameObject conver;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
            
        Debug.Log(collisionInfo.collider.name);

        if(collisionInfo.collider.name == "Cheque")
        {
            conver.SetActive(true);
                FindObjectOfType<control>().func4();
            //conver.SetActive(false);
        }
        if (collisionInfo.collider.name == "Manager")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func6();
            //conver.SetActive(false);
        }
        if (collisionInfo.collider.name == "New Account")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func1();
            //conver.SetActive(false);
        }
        if (collisionInfo.collider.name == "Deposit")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func2();
            //conver.SetActive(false);
        }
        if (collisionInfo.collider.name == "Widrawl")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func3();
            //conver.SetActive(false);
        }
        if (collisionInfo.collider.name == "Passbook Update")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func5();
            //conver.SetActive(false);
        }
        //game.CounterEnquiry();
        if (collisionInfo.collider.name == "Loan Enquiry")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func7();
            //conver.SetActive(false);
        }
        if (collisionInfo.collider.name == "Home Loan")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func8();
            //conver.SetActive(false);
        }
        if (collisionInfo.collider.name == "Car Loan")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func10();
            //conver.SetActive(false);
        }
        if (collisionInfo.collider.name == "Personal Loan")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func9();
            //conver.SetActive(false);
        }
        if (collisionInfo.collider.name == "Education Loan")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func11();
            //conver.SetActive(false);
        }
        if (collisionInfo.collider.name == "Loan Boss")
        {
            conver.SetActive(true);
            FindObjectOfType<control>().func12();
            //conver.SetActive(false);
        }
        if(collisionInfo.collider.name == "Cube")
        {
            conver.SetActive(true);
            FindObjectOfType<Level3_DControl>().conversation_seq();
        }

    }
  


}
