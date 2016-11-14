using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Entity : MonoBehaviour {

    [SerializeField, Tooltip("HP")]
    private int _hp = 0;
    [SerializeField, Tooltip("Mana")]
    private int _mana = 0;
    [SerializeField, Tooltip("")]
    private float _moveSpeed = 0;
    [SerializeField, Tooltip("")]
    private float _jumpForce = 0;


    [SerializeField]
    private Rigidbody2D m_Rigidbody2D;

    [SerializeField]
    private List<Collider2D> collider = new List<Collider2D>();

    void Start()
    {
        m_Rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        if (m_Rigidbody2D.Equals("null"))
            m_Rigidbody2D = gameObject.AddComponent(typeof(Rigidbody2D)) as Rigidbody2D;

    }

}
