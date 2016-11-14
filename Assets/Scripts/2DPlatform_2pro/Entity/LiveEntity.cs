using UnityEngine;
using System.Collections;

public class LiveEntity : Entity
{

    enum MoveType { All, LEFT_RIGHT, UP_DOWN, None }
    [SerializeField, Tooltip("")]
    private MoveType _moveType;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
