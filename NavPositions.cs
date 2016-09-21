using UnityEngine;
using System.Collections;

public class NavPositions : MonoBehaviour {

    public Vector3[] path = new Vector3[5];

    int pathIndex = 0;

    float speed = 4;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	Vector3 target =path[pathIndex];
    Vector3 newPos = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        transform.position = newPos;
        transform.LookAt(target);

        if (Vector3.Distance(newPos, target) == 0){
            pathIndex = ++pathIndex % path.Length;
        }
	}
}
