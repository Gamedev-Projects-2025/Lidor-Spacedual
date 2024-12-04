using UnityEngine;

public class StayInBounds : MonoBehaviour
{
    public RectTransform canvasRect; 

    private Vector2 minBounds;
    private Vector2 maxBounds;

    void Start()
    {
        if (canvasRect == null)
        {
            Debug.LogError("Canvas Rect is not assigned! Please assign it in the Inspector.");
            return;
        }

        Vector3[] worldCorners = new Vector3[4];
        canvasRect.GetWorldCorners(worldCorners);

        minBounds = new Vector2(worldCorners[0].x, worldCorners[0].y); 
        maxBounds = new Vector2(worldCorners[2].x, worldCorners[2].y); 

        Debug.Log($"Canvas Bounds - Min: {minBounds}, Max: {maxBounds}");
    }

    void Update()
    {
        if (canvasRect == null) return;

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minBounds.x, maxBounds.x); 
        position.y = Mathf.Clamp(position.y, minBounds.y, maxBounds.y); 
        transform.position = position;
    }
}
