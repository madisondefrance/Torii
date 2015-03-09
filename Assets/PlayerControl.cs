using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	private int count;
	public GUIText winText;
	public GUIText countText;
	
	
	void start()
	{
		count = 0;
		countText.text = "";
		winText.text = "";
	}
	

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Gift")
		{
			other.gameObject.SetActive(false);
			count = count + 1;
		}
		
		if(other.gameObject.tag == "End")
		{
			winText.text = "You win!";
			countText.text = "You collected " + count.ToString() + " out of 20 Gifts!";
		}
		
		
	}
}
