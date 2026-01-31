using UnityEngine;

public class PlayerRaycastSystem : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private LayerMask ballLayer;
    [SerializeField] private float maxDistance = 100f;
    [SerializeField] private float damangePower = 1f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootRay();
        }
    }

    private void ShootRay()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, ballLayer))
        {
            Entities entity = hit.collider.GetComponentInParent<Entities>();

            if (entity != null) {
                entity.OnRayHit(damangePower);
            }
        }
    }
}
