using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameObject levelCompleteUI;
    private void OnTriggerEnter(Collider other)
    {
        levelCompleteUI.SetActive(true);
    }
}
