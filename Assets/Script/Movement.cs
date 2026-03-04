using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;   // ความเร็วในการเดิน
    public float rotateSpeed = 700f; // ความเร็วในการหมุน

    void Update()
    {
        // รับค่าปุ่มกดแนวตั้ง (W/S หรือ ↑/↓)
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // รับค่าปุ่มกดแนวนอน (A/D หรือ ←/→)
        float rotate = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;

        // เดินหน้า-ถอยหลัง
        transform.Translate(Vector3.forward * move);

        // หมุนซ้าย-ขวา
        transform.Rotate(Vector3.left * rotate);
    }

}