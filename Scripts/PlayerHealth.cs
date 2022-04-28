using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    #region Exposed
    [SerializeField]
    private IntData _playerStartHP;
    [SerializeField]
    private IntData _playerCurrentHP;

    public GameObject m_prisme;
    public GameObject m_prisme2;
    #endregion

    #region Lifecycle

    void Awake()
    {
        //Debug.Log(_playerCurrentHP.lifePoints);
       // Debug.Log(_playerStartHP.lifePoints);
    }

    void Start()
    {
        _playerCurrentHP.lifePoints = _playerStartHP.lifePoints;
        
    }

    
    void Update()
    {
        if(_playerCurrentHP.lifePoints <= 2)
        {
        m_prisme.SetActive(false);

        }
        if (_playerCurrentHP.lifePoints <= 1)
        {
            m_prisme2.SetActive(false);

        }
        if (_playerCurrentHP.lifePoints <= 0)
        {
            gameObject.SetActive(false);

        }
    }

   void FixedUpdate()
    {
       
    }

#endregion
#region Main Methods
#endregion
#region Private & Protected
#endregion 
}
