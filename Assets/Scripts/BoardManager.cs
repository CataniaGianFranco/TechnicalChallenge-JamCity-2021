using UnityEngine;

public class BoardManager : MonoBehaviour
{
    private int _height = 8;
    private int _width = 8;

    public GameObject[] hexagon;
    
    private Transform _boardHolder;

    private GameObject[] hexagonTile = new GameObject[64];
    private int _indexHexagonTile = 0;
    public void Setup() => BoardSetup();

    private void BoardSetup() => FirstBoard();
    
    #region FirstBoard
    
    private void FirstBoard()
    {
        _boardHolder = new GameObject("Board").transform;
        FirstRow();
        SecondRow();
        ThirdRow();
        FourthRow();
        FifthRow();
        SixthRow();
        SeventhRow();
        EighthRow();

        SetFirstGridPosition();
    }
    
    #endregion

    private void GetHexagon(int index, float x, float z)
    {
        GameObject newHexagon = hexagon[index];
        Vector3 hexagonPosition = new Vector3(x, 0f, z);

        GameObject hexagonInstance = Instantiate<GameObject>(newHexagon, hexagonPosition, Quaternion.identity);
        hexagonInstance.transform.SetParent(_boardHolder);

        hexagonTile[_indexHexagonTile] = hexagonInstance;

        _indexHexagonTile++;
    }    

    // Deserte 0 ; Forest 1; Grass 2; Mountain 3; Water 4
    private void FirstRow() 
    {
        GetHexagon(0, 0f, 0f);
        GetHexagon(0, 1f, 0f);
        GetHexagon(2, 2f, 0f);
        GetHexagon(4, 3f, 0f);
        GetHexagon(2, 4f, 0f);
        GetHexagon(3, 5f, 0f);
        GetHexagon(3, 6f, 0f);
        GetHexagon(2, 7f, 0f);
    }
    private void SecondRow()
    {
        GetHexagon(0, 0.5f, -0.75f);
        GetHexagon(0, 1.5f, -0.75f);
        GetHexagon(0, 2.5f, -0.75f);
        GetHexagon(1, 3.5f, -0.75f);
        GetHexagon(2, 4.5f, -0.75f);
        GetHexagon(1, 5.5f, -0.75f);
        GetHexagon(3, 6.5f, -0.75f);
        GetHexagon(1, 7.5f, -0.75f);
    }
    private void ThirdRow()
    {
        GetHexagon(0, 0f, -1.5f);
        GetHexagon(1, 1f, -1.5f);
        GetHexagon(0, 2f, -1.5f);
        GetHexagon(2, 3f, -1.5f);
        GetHexagon(2, 4f, -1.5f);
        GetHexagon(3, 5f, -1.5f);
        GetHexagon(0, 6f, -1.5f);
        GetHexagon(0, 7f, -1.5f);
    }
    private void FourthRow()
    {
        GetHexagon(0, 0.5f, -2.25f);
        GetHexagon(1, 1.5f, -2.25f);
        GetHexagon(4, 2.5f, -2.25f);
        GetHexagon(1, 3.5f, -2.25f);
        GetHexagon(3, 4.5f, -2.25f);
        GetHexagon(1, 5.5f, -2.25f);
        GetHexagon(0, 6.5f, -2.25f);
        GetHexagon(0, 7.5f, -2.25f);

    }
    private void FifthRow()
    {
        GetHexagon(4, 0f, -3f);
        GetHexagon(4, 1f, -3f);
        GetHexagon(4, 2f, -3f);
        GetHexagon(1, 3f, -3f);
        GetHexagon(3, 4f, -3f);
        GetHexagon(1, 5f, -3f);
        GetHexagon(2, 6f, -3f);
        GetHexagon(0, 7f, -3f);
    }
    private void SixthRow()
    {
        GetHexagon(1, 0.5f, -3.75f);
        GetHexagon(1, 1.5f, -3.75f);
        GetHexagon(0, 2.5f, -3.75f);
        GetHexagon(2, 3.5f, -3.75f);
        GetHexagon(4, 4.5f, -3.75f);
        GetHexagon(4, 5.5f, -3.75f);
        GetHexagon(2, 6.5f, -3.75f);
        GetHexagon(4, 7.5f, -3.75f);
    }
    private void SeventhRow()
    {
        GetHexagon(2, 0f, -4.5f);
        GetHexagon(1, 1f, -4.5f);
        GetHexagon(3, 2f, -4.5f);
        GetHexagon(1, 3f, -4.5f);
        GetHexagon(1, 4f, -4.5f);
        GetHexagon(2, 5f, -4.5f);
        GetHexagon(4, 6f, -4.5f);
        GetHexagon(4, 7f, -4.5f);
    }
    private void EighthRow()
    {
        GetHexagon(3, 0.5f, -5.25f);
        GetHexagon(3, 1.5f, -5.25f);
        GetHexagon(3, 2.5f, -5.25f);
        GetHexagon(1, 3.5f, -5.25f);
        GetHexagon(2, 4.5f, -5.25f);
        GetHexagon(1, 5.5f, -5.25f);
        GetHexagon(2, 6.5f, -5.25f);
        GetHexagon(4, 7.5f, -5.25f);
    }
    private void SetFirstGridPosition()
    {
        int currentIndex = 0;
        for (int x = 0; x < _height; x++)
        {
            for (int y = 0; y < _width; y++)
            {
                hexagonTile[currentIndex].GetComponent<NodePosition>().NodeCurrentPosition = new Vector2(x, y);
                currentIndex++;
            }
        }
    }
}
