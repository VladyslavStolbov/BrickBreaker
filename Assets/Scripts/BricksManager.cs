using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class BricksManager : MonoBehaviour
{
    public static BricksManager Instance;

    private Brick[] _bricks;
    [SerializeField] private GameObject[] _brickRows;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        AssignBricks();
    }
    public void ResetBricks()
    {
        foreach (var brick in _bricks)
        {
            brick.gameObject.SetActive(true);
        }
    }
    public bool IsCleared()
    {
        return _bricks.All(brick => !brick.gameObject.activeSelf);
    }

    private void AssignBricks()
    {
        var bricksList = new List<Brick>();
        foreach (var row in _brickRows)
        {
            foreach (Transform brick in row.transform)
            {
                bricksList.Add(brick.GetComponent<Brick>());
            }
        }
        _bricks = bricksList.ToArray();
    }

}
