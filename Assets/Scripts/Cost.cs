using UnityEngine;

public class Cost : MonoBehaviour
{
    [SerializeField]
    private uint _costHexagon;
    public uint CostHexagon { get => _costHexagon; set => _costHexagon = value; }
}
