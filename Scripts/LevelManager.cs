using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    #region Exposed
    [SerializeField]
    private IntData _currentPlayerHP;
    [SerializeField]
    private IntData _enemyCount;
    [SerializeField]
    private GameObject _loseMenu;
    [SerializeField]
    private GameObject _pauseMenu;
    #endregion

    #region Lifecycle

    void Awake()
    {
        
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        if(_currentPlayerHP.lifePoints == 0)
        {
            Lose();
        }
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseTheGame();
        }

    }

   void FixedUpdate()
    {
       
    }

#endregion
#region Main Methods

    void Win()
    {
        Debug.Log("You Win!");
    }
    void Lose()
    {
        _loseMenu.SetActive(true);
    }

    void PauseTheGame()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    
    #endregion
    #region Private & Protected
    #endregion
}
