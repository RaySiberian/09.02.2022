using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "MovePoint", menuName = "Chess/MovementPattern", order = 0)]
    public class MovementPattern : ScriptableObject
    {
        public Vector3[] MovePoints;
    }
}