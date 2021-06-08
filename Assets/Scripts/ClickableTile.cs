using UnityEngine;

public class ClickableTile : MonoBehaviour
{
    private GameManager _scriptGameManager;
    private MeshRenderer _thisMeshRenderer;
    public void Start()
    {
        _thisMeshRenderer = GetComponent<MeshRenderer>();
        _scriptGameManager = GameObject.Find("GameManager(Clone)").GetComponent<GameManager>();
        
    }
    public void OnMouseUp()
    {
        if (_scriptGameManager.CountClick != 0 && _thisMeshRenderer.material.color != Color.green)
        {
            _thisMeshRenderer.material.color = Color.green;
            _scriptGameManager.CountClick--;

            if (_scriptGameManager.InitialHexagon == null) 
                _scriptGameManager.InitialHexagon = this.gameObject;

            if (_scriptGameManager.TargetHexagon == null)
                _scriptGameManager.TargetHexagon = this.gameObject;

        }
    }
}
