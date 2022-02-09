using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Board", menuName = "Chess/BoardConfig", order = 0)]
    public class BoardConfig : ScriptableObject
    {
        [SerializeField] private BoardPosition[] points;

        public BoardPosition[] Points => points;

        public Vector3[] GetVectorPositions()
        {
            return points.Select(point => point.Position).ToArray();
        }
        
        public BoardPosition GetPointByVector(Vector3 vector)
        {
            return points.FirstOrDefault(point => point.Position == vector);
        }
    }
}