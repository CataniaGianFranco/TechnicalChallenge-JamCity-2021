using PathFinding;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject gameManager;

    private void Awake()
    {
        if (GameManager.InstanceGameManager == null)
            Instantiate<GameObject>(gameManager);
    }
}
