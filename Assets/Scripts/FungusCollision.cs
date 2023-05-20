using Fungus;
using UnityEngine;

public class FungusCollision : MonoBehaviour
{
    public Flowchart fungusFlowchart;
    public string dialogBlockName;
    private bool dialogTriggered = false;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !dialogTriggered)
        {
            // Trigger the Fungus dialog flowchart block
            fungusFlowchart.ExecuteBlock(dialogBlockName);

            // Set the dialogTriggered variable to true to prevent further triggering
            dialogTriggered = true;
        }
    }
}
