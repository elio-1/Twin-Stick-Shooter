using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMovement : MonoBehaviour
{
    #region Exposed
    private Transform m_player;
    public float rotationSpeed = 40.0f;
    public float speed = 10.0f;
    private Rigidbody _rb;

    [SerializeField]
    private IntData _playerCurrentHP;
#endregion

#region Lifecycle

   void Awake()
    {
        _rb = this.GetComponent<Rigidbody>();
        m_player = GameObject.Find("Player").transform;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
    }

   void FixedUpdate()
    {
        _rb.velocity = transform.forward * speed ;       
        //_rb.AddForce(transform.forward * speed);
        TurnTowardPlayer();
    }

#endregion
#region Main Methods
    void TurnTowardPlayer()
    {
        Vector3 direction = m_player.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, rotationSpeed * Time.fixedDeltaTime);
        _rb.MoveRotation(rotation);
        //Quaternion rotation =  Quaternion.LookRotation(direction);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player") 
        {
            _playerCurrentHP.lifePoints -= 1;
            
        }
        
    }
    
    #endregion
    #region Private & Protected
    #endregion
}
