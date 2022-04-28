using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilleMovement : MonoBehaviour
{
    #region Exposed
    public float speed = 20.0f;
    private Rigidbody _rb;
    [SerializeField]
    private IntData _enemyCount;
    #endregion

    #region Lifecycle

    void Awake()
    {
        
        _rb = this.GetComponent<Rigidbody>();
    }

    void Start()
    {
    }

    
    void Update()
    {
        Destroy(gameObject, 1);
    }
    
   void FixedUpdate()
    {

        _rb.AddForce(-transform.forward * speed);
    }

    #endregion
    #region Main Methods
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            _enemyCount.lifePoints -= 1;
            
            
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
    #endregion
    #region Private & Protected
    #endregion
}
