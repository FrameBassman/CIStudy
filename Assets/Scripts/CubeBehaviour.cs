using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public Color CurColor => GetComponent<Renderer>().material.GetColor("_Color");
    
    private float _counter;
    private bool _hasHit;
    

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Hit");
        GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
    }
}
