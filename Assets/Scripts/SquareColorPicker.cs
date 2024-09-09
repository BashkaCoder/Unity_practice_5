using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SquareColorPicker : MonoBehaviour
{
    [SerializeField]
    private Color _color;

    private void Start()
    {
        GetComponent<SpriteRenderer>().color = _color;
    }
}
