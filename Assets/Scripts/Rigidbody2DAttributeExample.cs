using UnityEngine;

public class Rigidbody2DAttributeExample : MonoBehaviour
{
    [Rigidbody2DType(RigidbodyType2D.Dynamic)]
    [SerializeField] private Rigidbody2D _r1;
    
    [Rigidbody2DType(RigidbodyType2D.Kinematic)]
    [SerializeField] private Rigidbody2D _r2;
    
    [Rigidbody2DType(RigidbodyType2D.Static)]
    [SerializeField] private Rigidbody2D _r3;

    private void Start()
    {
        _r1 = transform.GetChild(0).GetComponent<Rigidbody2D>();
        _r2 = transform.GetChild(1).GetComponent<Rigidbody2D>();
        _r3 = transform.GetChild(2).GetComponent<Rigidbody2D>();
    }
}
