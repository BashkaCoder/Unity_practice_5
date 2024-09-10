using UnityEngine;

public class Rigidbody2DTypeAttribute : PropertyAttribute
{
    public RigidbodyType2D BodyType { get; private set; }

    public Rigidbody2DTypeAttribute(RigidbodyType2D bodyType)
    {
        BodyType = bodyType;
    }
}