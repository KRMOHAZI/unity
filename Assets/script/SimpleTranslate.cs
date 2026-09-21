using UnityEditor.U2D.Sprites;
using UnityEngine;

public class SimpleTranslate : MonoBehaviour
{
    public float delta = 5.0f;
    float y = 0.0f;

    private void Start()
    {
        y = transform.position.y;
    }

    private void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        transform.Translate(vec * delta * Time.deltaTime);
        //transform.Translate(new Vector3(delta, 0.0f, 0.0f) * Time.deltaTime);
    }
}

