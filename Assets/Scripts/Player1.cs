using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

    public GameObject preKnight;

	// Use this for initialization
	void Start () {

        GameObject k = Instantiate(preKnight);
        k.transform.parent = transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
