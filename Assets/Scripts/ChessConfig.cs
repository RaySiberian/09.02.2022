using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ChessConfig", menuName = "Chess/ChessConfig")]
public class ChessConfig : ScriptableObject
{
    [SerializeField] private ChessFigure[] chessFigures;

    public ChessFigure[] ChessFigures => chessFigures;

    public ChessFigure[] GetWhiteFigures()
    {
        return chessFigures.Where(figure => figure.ChessSide == ChessSide.White).ToArray();
    }
    
    public ChessFigure[] GetDarkFigures()
    {
        return chessFigures.Where(figure => figure.ChessSide == ChessSide.Dark).ToArray();
    }

    public ChessFigure GetFigureById(string id)
    {
        return chessFigures.FirstOrDefault(figure => figure.ID == id);
    }
}