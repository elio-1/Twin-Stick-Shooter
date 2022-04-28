using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    #region Exposed

    #endregion
    public GameObject _bulletPrefab;
    public Transform _cannon;

    [SerializeField]
    private float _delayBetweenShots;
    [SerializeField]
    private AudioClip _shootSound;


    private float _nextShotTime;
#region Lifecycle

    void Awake()
    {
        _nextShotTime = Time.time;
    }

    void Start()
    {
        
    }

    
    void Update()
    {

        
    }

   void FixedUpdate()
    {
        if(Input.GetButton("Fire1") == true && Time.time >= _nextShotTime)
        {
            _nextShotTime = Time.time + _delayBetweenShots;
            FireBullet();
           // AudioSource.PlayClipAtPoint(_shootSound, transform.position);
        }
       
    }

#endregion
#region Main Methods
    void FireBullet()
    {
        Instantiate(_bulletPrefab, _cannon.position, _cannon.rotation);
    }
#endregion
#region Private & Protected
#endregion 
}
