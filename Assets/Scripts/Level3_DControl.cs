using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3_DControl : MonoBehaviour {
    int x;
    private void Start()
    {
        x = 1;
    }
    public void conversation_seq()
    {
        FindObjectOfType<Level3_Dialogue>().changeText(x);
        x++;
    }

}
