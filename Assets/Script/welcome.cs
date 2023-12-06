using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class welcome: MonoBehaviour
{
    [SerializeField] private Button startBtn;

    

    // Start is called before the first frame update
    
    public void Start()
    {
        startBtn.onClick.AddListener(NewGame);
    }
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

