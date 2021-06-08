using UnityEngine;

public class ClickableTile : MonoBehaviour
{
    private MeshRenderer _thisMeshRenderer;
    public void Awake()
    {
        _thisMeshRenderer = GetComponent<MeshRenderer>();
    }
    public void OnMouseUp()
    {
            _thisMeshRenderer.material.color = Color.green;

    }
}
