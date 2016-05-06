using UnityEngine;
using System.Collections;

public class Segue : MonoBehaviour
{

    public Transform pos;
    	
	// Update is called once per frame
	void Update ()
    {
        transform.position = pos.position;
	}
}
