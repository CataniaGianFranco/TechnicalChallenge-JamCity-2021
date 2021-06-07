using UnityEngine;

[RequireComponent(typeof(BoardManager))]

public class GameManager : MonoBehaviour
{
    /* This class contains Singleton */
    private static GameManager _instanceGameManager;    
    private BoardManager _boardManager;

    public static GameManager InstanceGameManager { get => _instanceGameManager; set => _instanceGameManager = value; }

    private void Awake()
    {
        if (_instanceGameManager == null)
            _instanceGameManager = this;
        else if (_instanceGameManager != this)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

        _boardManager = GetComponent<BoardManager>();
    }

    private void Start()
    {
        _boardManager.Setup();
    }
}
