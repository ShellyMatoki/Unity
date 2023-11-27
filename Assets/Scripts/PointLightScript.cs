using UnityEngine;

public class PointLightScript : MonoBehaviour
{
    public GameObject Light;
    // Start is called before the first frame update

    void Start()
    {
        Light.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Light.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        Light.SetActive(false);
    }
}
