using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyShooter : MonoBehaviour
{
    #region Exposed
    [SerializeField]
    private float rotateSpeed = 20.0f;

    public Transform _cannon;
    public Transform _cannon2;
    public Transform _cannon3;
    public Transform _cannon4;
    public GameObject _bulletPrefab;

    [SerializeField]
    private float _delayBetweenShots;


    private float _nextShotTime;
    #endregion

    #region Lifecycle

    void Awake()
    {
        _nextShotTime = Time.time;
    }

   void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);
        if (Time.time >= _nextShotTime)
        {
            _nextShotTime = Time.time + _delayBetweenShots;
            Instantiate(_bulletPrefab, _cannon.position, _cannon.rotation);
            Instantiate(_bulletPrefab, _cannon2.position, _cannon2.rotation);
            Instantiate(_bulletPrefab, _cannon3.position, _cannon3.rotation);
            Instantiate(_bulletPrefab, _cannon4.position, _cannon4.rotation);
        }
    }

#endregion
#region Main Methods
#endregion
#region Private & Protected
#endregion 
}
