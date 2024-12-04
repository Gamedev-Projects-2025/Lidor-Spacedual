using UnityEngine;
using UnityEngine.SceneManagement;

public class upDownTeleport : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "PlayerSpaceship1")
        {
            //Vector3 newPosition = other.transform.position;
            //newPosition.y = this.transform.position.y;
            //other.transform.position = newPosition;

            //other.transform.position.y = Mathf.Clamp(other.position.y, -(this.transform.position.y), this.transform.position.y);

        }
    }

    void update()
    {
        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, -5.5f, 5.5f);
        transform.position = position;
    }

}
