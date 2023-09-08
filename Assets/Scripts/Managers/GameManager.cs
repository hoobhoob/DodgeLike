using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private MonsterSpawnController _monsterSpawnController;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _endPanel;

    // Start is called before the first frame update
    void Awake()
    {
        _monsterSpawnController = GetComponent<MonsterSpawnController>();
        _monsterSpawnController.SetFullCount(10);
        _monsterSpawnController.SetSpawnPosition(new Vector2(_player.transform.position.x, _player.transform.position.y));
    }

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenEndPanel()
    {
        Time.timeScale = 0.0f;
        _endPanel.SetActive(true);
    }
}
