using UnityEngine;
using System.Collections;

public class movement1 : MonoBehaviour 
{
	public static int y;
	public float rotateangle=0.59987f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (cubegen.val1) 
		{
			if (rotateangle < 90)
			{
				for (int i=0; i<3; i++) 
				{
					for (int j=0; j<3; j++) 
					{
						for(int k=0; k<3; k++)
						{
							Vector3 vec=cubegen.grd[i,j,k].transform.position-new Vector3(1,y,1);
							GameObject gm=GameObject.FindGameObjectWithTag("GameController");
							vec=Quaternion.Euler(Mathf.RoundToInt(cubegen.grd[i,j,k].transform.rotation.x),Mathf.RoundToInt(cubegen.grd[i,j,k].transform.rotation.y),Mathf.RoundToInt(cubegen.grd[i,j,k].transform.rotation.z)) * vec+new Vector3(1,y,1);
							Vector3 v2=new Vector3(Mathf.RoundToInt(vec.x), Mathf.RoundToInt(vec.y), Mathf.RoundToInt(vec.z)); 
							if(v2.y==y)
							{
								//if(Mathf.Abs (y-gm.transform.position.y)<=0.5)
								//	gm.transform.RotateAround (new Vector3 (1, y, 1), Vector3.up, 1.5f);
								cubegen.grd [i, j, k].transform.RotateAround (new Vector3 (1, y, 1), Vector3.up, 1.5f);
							}
						}
					}
				}
				rotateangle += 1.5f;
			} 
			else 
			{
				cubegen.val1 = false;
				rotateangle = 0.59987f;



			}
		} 
		
	}
}
