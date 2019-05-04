using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatEnemy : MonoBehaviour {
    public List<Transform> CreatPoint = new List<Transform>();
    public GameObject prefabEnemy;
	// Use this for initialization
	void Start () {
        InvokeRepeating("CreratEnemys",5,2);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreratEnemys()
    {
        int num = Random.Range(0, CreatPoint.Count);
        GameObject go = Instantiate(prefabEnemy, CreatPoint[num].position, CreatPoint[num].rotation);
    }
}
