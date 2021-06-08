using System.Collections.Generic;
using UnityEngine;

namespace PathFinding
{
    public class Select : IAStarNode
    {
        private GameObject _initialHexagon, _targetHexagon;
        public GameObject InitialHexagon { get => _initialHexagon; set => _initialHexagon = value; }
        public GameObject TargetHexagon { get => _targetHexagon; set => _targetHexagon = value; }

        IEnumerable<IAStarNode> IAStarNode.Neighbours => throw new System.NotImplementedException();

        float IAStarNode.CostTo(IAStarNode neighbour)
        {
            throw new System.NotImplementedException();
        }

        float IAStarNode.EstimatedCostTo(IAStarNode target)
        {
            throw new System.NotImplementedException();
        } 
    }
}
