using UnityEngine;
using System.Collections;

public class RotateBomb : MonoBehaviour {

	void Update () 
	{
		transform.Rotate(new Vector3(10, 50, 10) * Time.deltaTime);
	}
}
