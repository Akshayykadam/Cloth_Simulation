using UnityEngine;

public class ClothController : MonoBehaviour
{
    public Cloth clothComponent;
    public float stiffness = 0.5f;
    public float bendingStiffness = 0.5f;
    public float damping = 0.1f;

    public float updateFrequency = 60f;
    void Start()
    {
        // Access the Cloth component
        clothComponent = GetComponent<Cloth>();

        // Adjust cloth parameters
        clothComponent.stretchingStiffness = stiffness;
        clothComponent.bendingStiffness = bendingStiffness;
        clothComponent.damping = damping;

        // Adjust cloth update frequency
        clothComponent.clothSolverFrequency = updateFrequency;
    }
}
