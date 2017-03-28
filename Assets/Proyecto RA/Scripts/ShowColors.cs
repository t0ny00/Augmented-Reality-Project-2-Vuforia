using UnityEngine;
using System.Collections;


public class ShowColors : MonoBehaviour {

    GameObject[] buttons;
    // Use this for initialization
    void Start () {
        buttons = GameObject.FindGameObjectsWithTag("Color Pick");
    }
	
	// Update is called once per frame
	void Update () {
	    if (gameObject.GetComponent<Vuforia.DefaultTrackableEventHandler>().track)
        {
           foreach (GameObject button in buttons) button.SetActive(true);
        }
        else
        {
            foreach (GameObject button in buttons) button.SetActive(false);
        }
	}
}
