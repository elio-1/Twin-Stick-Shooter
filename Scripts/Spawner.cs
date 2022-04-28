using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region Exposed
    [SerializeField]
    private IntData _enemyCount;
    [SerializeField]
    private IntData _waveCount;
    [SerializeField]
    private int _enemyNumber = 1;
    public GameObject m_enemyChaser;
    public GameObject m_enemyShoter;

    [SerializeField]
    private GameObject _player;

#endregion

#region Lifecycle

   void Awake()
    {
    }

    void Start()
    {
        SpawnEnemyAtRandomPos(m_enemyChaser, _enemyNumber);
        waveKilled = false;
        _waveCount.lifePoints = 1;
    }


    void Update()
    {
        
        _enemyCount.lifePoints = GameObject.FindGameObjectsWithTag("Enemy").Length; 
        if (_enemyCount.lifePoints <= 0)
        {
            waveKilled = true;
            //_player.transform.position = new Vector3(_player.transform.position.x, 0.05000001f, _player.transform.position.x);
        }
        if(_enemyCount.lifePoints <= 0 && waveKilled == true && _waveCount.lifePoints >= 2)
        {
            waveKilled = false;
            _waveCount.lifePoints += 1;
            SpawnEnemyAtRandomPos(m_enemyChaser, _waveCount.lifePoints);
            SpawnEnemyAtRandomPos(m_enemyShoter, _waveCount.lifePoints);
        }
        if (_enemyCount.lifePoints <= 0 && waveKilled == true && _waveCount.lifePoints < 2)
        {
            waveKilled = false;
            _waveCount.lifePoints += 1;
            SpawnEnemyAtRandomPos(m_enemyChaser, _waveCount.lifePoints);
        }
    }

   void FixedUpdate()
    {
       
    }

#endregion
#region Main Methods
    
    void SpawnEnemyAtRandomPos(GameObject enemy, int numberOfEnnemy)
    {
        for(int i=0; i < numberOfEnnemy; i++)
        {
        Instantiate(enemy, new Vector3(Random.Range(2.0f, 27.0f), 0, Random.Range(2.0f, 27.0f)), m_enemyChaser.transform.rotation);
        }


    }
    #endregion
    #region Private & Protected
    private Vector3 randomV3;
    private bool waveKilled;
#endregion
}
