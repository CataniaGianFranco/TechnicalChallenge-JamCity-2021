using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public GameObject[] hexagon;
    
    private Transform _boardHolder;

    public void Setup() => BoardSetup();

    private void BoardSetup() => FirstBoard();
    
    #region FirstBoard
    
    private void FirstBoard()
    {
        _boardHolder = new GameObject("Board").transform;
        HexagonDesert(0);
        HexagonForest(1);
        HexagonGrass(2);
        HexagonMountain(3);
        HexagonWater(4);
    }
    
    private void HexagonDesert(int index)
    {   // First row.
        GetHexagon(index, 0f, 0f);
        GetHexagon(index, 1f, 0f);

        // Second row.
        GetHexagon(index, 0.5f, -0.75f);
        GetHexagon(index, 1.5f, -0.75f);
        GetHexagon(index, 2.5f, -0.75f);

        // Third row.
        GetHexagon(index, 0f, -1.5f);
        GetHexagon(index, 2f, -1.5f);
        GetHexagon(index, 6f, -1.5f);

        // Fourth row.
        GetHexagon(index, 0.5f, -2.25f);
        GetHexagon(index, 6.5f, -2.25f);
        GetHexagon(index, 7.5f, -2.25f);

        // Fifth row.
        GetHexagon(index, 7f, -3f);

        // Sixth row.
        GetHexagon(index, 2.5f, -3.75f);
    }

    private void HexagonForest(int index)
    {
        // Second row.
        GetHexagon(index, 3.5f, -0.75f);
        GetHexagon(index, 5.5f, -0.75f);
        GetHexagon(index, 7.5f, -0.75f);

        // Third row.
        GetHexagon(index, 1f, -1.5f);

        // Fourth row.
        GetHexagon(index, 1.5f, -2.25f);
        GetHexagon(index, 3.5f, -2.25f);
        GetHexagon(index, 5.5f, -2.25f);

        // Fifth row.
        GetHexagon(index, 3f, -3f);
        GetHexagon(index, 5f, -3f);

        // Sixth row.
        GetHexagon(index, 0.5f, -3.75f);
        GetHexagon(index, 1.5f, -3.75f);

        // Seventh row.
        GetHexagon(index, 1f, -4.5f);
        GetHexagon(index, 3f, -4.5f);
        GetHexagon(index, 4f, -4.5f);

        // Eighth row.
        GetHexagon(index, 3.5f, -5.25f);
        GetHexagon(index, 5.5f, -5.25f);

    }

    private void HexagonGrass(int index)
    {
        // First row.
        GetHexagon(index, 2f, 0f);
        GetHexagon(index, 4f, 0f);
        GetHexagon(index, 7f, 0f);

        // Second row.
        GetHexagon(index, 4.5f, -0.75f);

        // Third row.
        GetHexagon(index, 3f, -1.5f);
        GetHexagon(index, 4f, -1.5f);
        GetHexagon(index, 7f, -1.5f);

        // Fifth row.
        GetHexagon(index, 6f, -3f);

        // Sixth row.
        GetHexagon(index, 3.5f, -3.75f);
        GetHexagon(index, 6.5f, -3.75f);

        // Seventh row.
        GetHexagon(index, 0f, -4.5f);
        GetHexagon(index, 5f, -4.5f);

        // Eighth row.
        GetHexagon(index, 4.5f, -5.25f);
        GetHexagon(index, 6.5f, -5.25f);
    }

    private void HexagonMountain(int index)
    {
        // First row.
        GetHexagon(index, 5f, 0f);
        GetHexagon(index, 6f, 0f);
        
        // Second row.
        GetHexagon(index, 6.5f, -0.75f);

        // Third row.
        GetHexagon(index, 5f, -1.5f);

        // Fourth row.
        GetHexagon(index, 4.5f, -2.25f);

        // Fifth row.
        GetHexagon(index, 4f, -3f);

        // Seventh row.
        GetHexagon(index, 2f, -4.5f);
        
        // Eighth row.
        GetHexagon(index, 0.5f, -5.25f);
        GetHexagon(index, 1.5f, -5.25f);
        GetHexagon(index, 2.5f, -5.25f);
    }

    private void HexagonWater(int index)
    {
        // First row.
        GetHexagon(index, 3f, 0f);

        // Fourth row.
        GetHexagon(index, 2.5f, -2.25f);

        // Fifth row.
        GetHexagon(index, 0f, -3f);
        GetHexagon(index, 1f, -3f);
        GetHexagon(index, 2f, -3f);

        // Sixth row.
        GetHexagon(index, 4.5f, -3.75f);
        GetHexagon(index, 5.5f, -3.75f);
        GetHexagon(index, 7.5f, -3.75f);

        // Seventh row.
        GetHexagon(index, 6f, -4.5f);
        GetHexagon(index, 7f, -4.5f);

        // Eighth row.
        GetHexagon(index, 7.5f, -5.25f);        

    }
    
    #endregion

    private void GetHexagon(int index, float x, float z)
    {
        GameObject newHexagon = hexagon[index];
        Vector3 hexagonPosition = new Vector3(x, 0f, z);
        Instantiate<GameObject>(newHexagon, hexagonPosition, Quaternion.identity).transform.SetParent(_boardHolder);
    }
}
