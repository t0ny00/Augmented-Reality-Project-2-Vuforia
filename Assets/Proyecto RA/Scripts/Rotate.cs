using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public float speed = 10;
    public Vector3 axis;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(speed * Time.deltaTime * axis.x, speed * Time.deltaTime * axis.y,speed*Time.deltaTime*axis.z));
	}

    
}
