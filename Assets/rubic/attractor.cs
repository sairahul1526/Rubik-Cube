using UnityEngine;
using System.Collections;

public class attractor : MonoBehaviour {

	public void attract(Transform body)
	{
		Vector3 gravityup = (body.position - transform.position).normalized;

		body.rigidbody.AddForce (gravityup * -10);

		Quaternion targetrot = Quaternion.FromToRotation (body.up, gravityup) ;
		body.rotation = Quaternion.Slerp (body.rotation, targetrot, 50 * Time.deltaTime);
	}
	// Use this for initialization
	
}
