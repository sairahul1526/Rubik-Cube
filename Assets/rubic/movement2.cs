using UnityEngine;
using System.Collections;

public class movement2 : MonoBehaviour 
{
	public static int x;
	public float rotateangle2=0.59987f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (cubegen.val2)
		{
			if (rotateangle2 < 90)
			{
				for (int i=0; i<3; i++) 
				{
					for (int j=0; j<3; j++) 
					{
						for(int k=0; k<3; k++)
						{
							Vector3 vec=cubegen.grd[i,j,k].transform.position-new Vector3(x,1,1);
							GameObject gm=GameObject.FindGameObjectWithTag("GameController");
							vec=Quaternion.Euler(Mathf.RoundToInt(cubegen.grd[i,j,k].transform.rotation.x),Mathf.RoundToInt(cubegen.grd[i,j,k].transform.rotation.y),Mathf.RoundToInt(cubegen.grd[i,j,k].transform.rotation.z)) * vec+new Vector3(x,1,1);
							Vector3 v2=new Vector3(Mathf.RoundToInt(vec.x), Mathf.RoundToInt(vec.y), Mathf.RoundToInt(vec.z));
							if(v2.x==x)
							{
							//	if(Mathf.Abs(x-gm.transform.position.x)<=0.5)
								//	gm.transform.RotateAround (new Vector3 (x,1,1), Vector3.right, 1.5f);
								cubegen.grd [i,j,k].transform.RotateAround (new Vector3 (x,1,1), Vector3.right, 1.5f);
							}

						}
					}
				}
				rotateangle2 += 1.5f;
			}
			else
			{
				cubegen.val2=false;
				rotateangle2=0.59987f;
			}
		}

	}
}
