using UnityEngine;

public class Player : MonoBehaviour
{
    private CapsuleCollider _capsuleCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        _capsuleCollider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalVector("_Player", transform.position + Vector3.up *_capsuleCollider.radius);
    }
}
