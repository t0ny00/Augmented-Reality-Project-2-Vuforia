using UnityEngine;
using System.Collections;

public class VBBrushHandler : MonoBehaviour {

    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Picked()
    {
        c1.GetComponent<OutlineChanger>().Picked();
        c2.GetComponent<OutlineChanger>().Picked();
        c3.GetComponent<OutlineChanger>().Picked();
    }

    public void Unpicked()
    {
        c1.GetComponent<OutlineChanger>().Unpicked();
        c2.GetComponent<OutlineChanger>().Unpicked();
        c3.GetComponent<OutlineChanger>().Unpicked();
    }
}
