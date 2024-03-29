using UnityEngine;

public class INandOUT : MonoBehaviour
{
    public GameObject Out, Out1, Out2, Out3;
    public GameObject In, In2;
    public Material skyboxChange;
    
    void OnCollisionEnter(Collision colisionInfo)
    {

        if (colisionInfo.collider.name == "SphereT")
        {
            Debug.Log(colisionInfo.collider.name);
            In.SetActive(true);
            In2.SetActive(true);
            Out.SetActive(false);
            Out1.SetActive(false);
            Out2.SetActive(false);
            Out3.SetActive(false);
            RenderSettings.skybox = skyboxChange;
        }

    }
}


