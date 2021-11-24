using UnityEngine;

public class Bunkers : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Invader"))
        {
            Debug.Log("Hello world!");
            this.gameObject.SetActive(false);
        }
    }
}
