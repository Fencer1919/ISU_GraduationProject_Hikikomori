using Fungus;
using UnityEngine;

public class FungusCollision : MonoBehaviour
{
    public Flowchart fungusFlowchart;
    public string dialogBlockName;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        // Check if the collision object has the tag "Player" (you can customize the tag)
        if (collision.gameObject.CompareTag("Player"))
        {
            // Trigger the Fungus dialog flowchart block
            fungusFlowchart.ExecuteBlock(dialogBlockName);
        }
    }
}
