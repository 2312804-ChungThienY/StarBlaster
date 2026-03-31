using UnityEngine;

public class PowerUp : MonoBehaviour 
{
    // Cấu hình buff (Mày có thể chỉnh ở ngoài Inspector cho tiện)
    [Header("Buff Chờ Bắn ")]
    [SerializeField] float fireRateMultiplier = 0.5f; // Giảm một nửa thời gian chờ (bắn nhanh gấp 2)

    [Header("Buff Tốc Độ Di Chuyển")]
    [SerializeField] float moveSpeedMultiplier = 1.5f; // Tăng 50% tốc độ di chuyển

    void OnTriggerEnter2D(Collider2D other) 
    {
        // Kiểm tra xem có phải Player đụng vào không
        if (other.CompareTag("Player")) 
        {
            // --- 1. Buff Tốc Độ Bắn ---
            Shooter shooter = other.GetComponent<Shooter>();
            if (shooter != null) 
            {
                shooter.BaseFireRate *= fireRateMultiplier; 
                // Chốt an toàn
                shooter.BaseFireRate = Mathf.Max(shooter.BaseFireRate, 0.05f);
            }

            // --- 2. Buff Tốc Độ Di Chuyển ---
            PlayerController playerMovement = other.GetComponent<PlayerController>();
            if (playerMovement != null) 
            {
                // Nhân tốc độ hiện tại với hệ số buff
                playerMovement.MoveSpeed *= moveSpeedMultiplier;
                // Chốt an toàn
                playerMovement.MoveSpeed = Mathf.Min(playerMovement.MoveSpeed, 20f);
            }

            // --- 3. Hủy Vật Phẩm ---
            Destroy(gameObject); 
        }
    }
}