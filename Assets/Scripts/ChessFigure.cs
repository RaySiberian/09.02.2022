using DefaultNamespace;
using UnityEngine;

[CreateAssetMenu(fileName = "ChessFigure", menuName = "Chess/ChessFigure")]
public class ChessFigure : ScriptableObject
{
    [SerializeField] private MovementPattern movementPattern;
    [SerializeField] private GameObject prefab;
    [SerializeField] private ChessSide chessSide;
    [SerializeField] private string id;

    public string ID => id;
    public ChessSide ChessSide => chessSide;
    public MovementPattern MovementPattern => movementPattern;
    public GameObject Prefab => prefab;

    private void OnEnable()
    {
        id = name;
    }
}

public enum ChessSide
{
    White = 0,
    Dark = 1
}