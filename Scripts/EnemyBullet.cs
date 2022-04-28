using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    #region Exposed
    public float speed = 20.0f;
    private Rigidbody _rb;
    [SerializeField]
    private IntData _playerCurrentHP;
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
        Destroy(gameObject, 2);
    }

   void FixedUpdate()
    {
        _rb.AddForce(transform.forward * speed);
    }

    #endregion
    #region Main Methods
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            _playerCurrentHP.lifePoints -= 1;
            Destroy(gameObject);
        }

    }
    
    #endregion
    #region Private & Protected
    #endregion
}
