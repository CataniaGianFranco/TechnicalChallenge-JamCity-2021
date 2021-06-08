using System.Collections.Generic;
using UnityEngine;
using PathFinding;

public class NodePosition : MonoBehaviour, IAStarNode
{
    public Vector2 _nodeCurrentPosition;
    public Vector2 NodeCurrentPosition { get => _nodeCurrentPosition; set => _nodeCurrentPosition = value; }
    public IEnumerable<IAStarNode> Neighbours => throw new System.NotImplementedException();

    IEnumerable<IAStarNode> IAStarNode.Neighbours => throw new System.NotImplementedException();

    public float CostTo(IAStarNode neighbour)
    {
        throw new System.NotImplementedException();
    }

    public float EstimatedCostTo(IAStarNode target)
    {
        throw new System.NotImplementedException();
    }
}
