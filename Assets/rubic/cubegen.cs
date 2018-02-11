using UnityEngine;
using System.Collections;

public class cubegen : MonoBehaviour {
	public GameObject c;
	public static bool val1=false;
	public static bool val2 = false;
	public static bool val3 = false;
	public static GameObject[, ,] grd=new GameObject[3,3,3];
	public GameObject[] grd2=new GameObject[27];
	// Use this for initialization
	void Start () 
	{
		for (int i=0; i<27; i++) 
		{
			GameObject game=(GameObject)grd2[i];
			grd[Mathf.RoundToInt(game.transform.position.x), Mathf.RoundToInt(game.transform.position.y), Mathf.RoundToInt(game.transform.position.z)]=game;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Q) || Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.E)) {
						val1 = true;
						if (Input.GetKey (KeyCode.Q))
								movement1.y = 2;
						else if (Input.GetKey (KeyCode.W))
								movement1.y = 1;
						else
								movement1.y = 0;
						

				} else if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.D)) {

						if (Input.GetKey (KeyCode.D))
								movement2.x = 2;
						else if (Input.GetKey (KeyCode.S))
								movement2.x = 1;
						else
								movement2.x = 0;
						val2 = true;

				} 
		else if (Input.GetKeyDown (KeyCode.Z) || Input.GetKeyDown (KeyCode.X) || Input.GetKeyDown (KeyCode.C)) 
		{
			if(Input.GetKeyDown(KeyCode.Z))
				movement3.z=0;
			else if(Input.GetKeyDown(KeyCode.X))
			        movement3.z=1;
			else 
				movement3.z=2;
			        val3=true;
		}
	}
}
