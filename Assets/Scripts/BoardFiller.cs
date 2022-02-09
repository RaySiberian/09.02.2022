using UnityEngine;

public class BoardFiller : MonoBehaviour
{
    [SerializeField] private BoardPreset boardPreset;
    private void Start()
    {
        foreach (var t in boardPreset.BoardPoints)
        {
            GameObject obj  = Instantiate(t.ChessFigure.Prefab, t.Position,
                Quaternion.identity);
            obj.transform.localScale = new Vector3(1, 1, 1);
            obj.name = t.ChessFigure.ID;
            if (t.ChessFigure.ChessSide == ChessSide.Dark)
            {
                obj.transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
        }
    }
}
