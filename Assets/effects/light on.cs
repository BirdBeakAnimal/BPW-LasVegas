using UnityEngine;

public class collorchange : MonoBehaviour
{
    public MeshRenderer kameli;
    public Material mat1;
    
    void OnCollisionEnter(Collision colisionInfo)
    {
        
        if (colisionInfo.collider.name == "SphereT")
        {
            Debug.Log(colisionInfo.collider.name);
            kameli.material = mat1;
        }

     }
}
