using UnityEngine;

public class DeletOffScreen : MonoBehaviour
{

    void Update()
    {
        if (transform.position.y <= -5.0f)
            Destroy(gameObject);
    }
}
