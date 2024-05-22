using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour {

    public GameObject completeLevelUI;
    public void CounterEnquiry()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("Got Hit By Block");
    }
    
}
