using UnityEngine;
using System.Collections;

public class movement3 : MonoBehaviour 
{
	public static int z;
	public float rotateangle3=0.59987f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (cubegen.val3) 
		{
			if (rotateangle3 < 90)
			{
				for (int i=0; i<3; i++) 
				{
					for (int j=0; j<3; j++) 
					{
						for(int k=0; k<3; k++)
						{
							Vector3 vec=cubegen.grd[i,j,k].transform.position-new Vector3(1,1,z);
							GameObject gm=GameObject.FindGameObjectWithTag("GameController");
							vec=Quaternion.Euler(Mathf.RoundToInt(cubegen.grd[i,j,k].transform.rotation.x),Mathf.RoundToInt(cubegen.grd[i,j,k].transform.rotation.y),Mathf.RoundToInt(cubegen.grd[i,j,k].transform.rotation.z)) * vec+new Vector3(1,1,z);
							Vector3 v2=new Vector3(Mathf.RoundToInt(vec.x), Mathf.RoundToInt(vec.y), Mathf.RoundToInt(vec.z)); 
							if(v2.z==z)
							{
								//if(Mathf.Abs(gm.transform.position.z-z)<=0.5)
								//{
								//	gm.transform.RotateAround (new Vector3 (1, 1, z), Vector3.forward, 1.5f);
								//}
									cubegen.grd [i, j, k].transform.RotateAround (new Vector3 (1, 1, z), Vector3.forward, 1.5f);

							}
						}
					}
				}
				rotateangle3 += 1.5f;
			} 
			else 
			{
				cubegen.val3 = false;
				rotateangle3 = 0.59987f;
				
				
				
			}
		} 
		
	}
}
