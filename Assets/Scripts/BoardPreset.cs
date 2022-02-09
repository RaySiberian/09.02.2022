using System;
using UnityEngine;


[CreateAssetMenu(fileName = "BoardPreset", menuName = "Chess/BoardPreset", order = 0)]
public class BoardPreset : ScriptableObject
{
    [SerializeField] private BoardPoint[] boardPoints;
    public BoardPoint[] BoardPoints => boardPoints;
    
}