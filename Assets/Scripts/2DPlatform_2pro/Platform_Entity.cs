using UnityEngine;
using System.Collections;
using UnityEditor;

public class Platform_Entity : MonoBehaviour
{

    [SerializeField, Tooltip("HP")]
    private int _hp = 0;
    [SerializeField, Tooltip("Mana")]
    private int _mana = 0;
    [SerializeField, Tooltip("")]
    private float _moveSpeed = 0;
    [SerializeField, Tooltip("")]
    private float _jumpForce = 0;

    enum MoveType { All, LEFT_RIGHT, UP_DOWN, None }
    [SerializeField, Tooltip("")]
    private MoveType _moveType;







    [SerializeField]
    private Rigidbody2D m_Rigidbody2D;

    BoxCollider2D box2d;
    
    void awake()
    {

    }

    // Use this for initialization
    void Start()
    {
        m_Rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        if(m_Rigidbody2D.Equals("null"))
            m_Rigidbody2D = gameObject.AddComponent(typeof(Rigidbody2D)) as Rigidbody2D;

        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
