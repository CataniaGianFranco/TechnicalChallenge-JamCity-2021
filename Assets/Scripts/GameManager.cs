using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(BoardManager))]
    public class GameManager : MonoBehaviour
    {
        /* This class contains Singleton */
        private GameObject _initialHexagon, _targetHexagon;
        private static GameManager _instanceGameManager;
        private BoardManager _boardManager;

        private int _countClick = 2;
        public int CountClick { get => _countClick; set => _countClick = value; }
        public GameObject InitialHexagon { get => _initialHexagon; set => _initialHexagon = value; }
        public GameObject TargetHexagon { get => _targetHexagon; set => _targetHexagon = value; }
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
