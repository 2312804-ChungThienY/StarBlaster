# Lab 03 -- Khám phá & Phát triển dự án Star Blaster (Space Shooter)

**Thông tin sinh viên**
- Họ tên: Chung Thiện Ý
- MSSV: 2312804
- Lớp: CKT47C

**Mô tả**  
Bài thực hành môn Game 2D Development with Unity.

Trong bài lab này, sinh viên tiến hành phân tích, thiết kế và phát triển dự án game bắn súng không gian 2D (Space Shooter / Star Blaster). Mục tiêu của bài lab tập trung vào việc áp dụng các kỹ thuật lập trình nâng cao trong Unity:

- Hiểu và phân tích cấu trúc thư mục dự án chuẩn Assets/ (Fonts, Prefabs, Scripts, Sprites...).
- Làm chủ kỹ thuật Instantiate, Coroutine và Scene Management.
- Khai thác tính năng Prefab Variant để mở rộng hệ thống nhân vật/quái vật.

**Các tính năng & Thay đổi đã thực hiện**

**1. Mở rộng hệ thống Quái vật (Enemy) bằng Prefab Variant**  
Thực hiện: Thay vì tạo quái vật mới từ đầu, tiến hành tạo các biến thể từ Prefab gốc Enemy.  

Dữ liệu: Tạo thêm các loại quái vật mới như **Enemy_Elite 1** và **Enemy_Elite 2** đưa vào mảng danh sách Enemy Prefabs.  

Kết quả: Quái vật mới kế thừa toàn bộ logic di chuyển, va chạm từ bản gốc, chỉ cần thay đổi ngoại hình và tinh chỉnh các chỉ số (Buff) như tăng máu, tăng sát thương để tăng độ khó.

**2. Object buff chỉ số cho player**  

Thực hiện: Sử dụng cảm biến Collider 2D để bắt va chạm. Khi tàu người chơi chạm vào cục Item, thay vì gọi hàm TakeDamage, sẽ kích hoạt hàm buff thêm **fire rate** và **movement speed**, 
sau đó tự động Destroy Item. Hiệu ứng được apply lên người chơi và tồn tại vĩnh viễn.  

Va chạm: Cấu hình Rigidbody2D và Trigger Collider2D. Xây dựng logic trừ máu thông qua script DamageDealer mỗi khi tàu người chơi va chạm trực tiếp với quái vật hoặc trúng đạn.

**Kiến thức đã học được**
- Nắm vững cấu trúc thư mục thực tế của một dự án 2D Unity.
- Hiểu Singleton Pattern để quản lý dữ liệu.
- Biết cách sử dụng Prefab Variant để kế thừa và tối ưu hóa tài nguyên hệ thống.
- Hiểu cơ chế hoạt động của vòng lặp thời gian Coroutine trong việc quản lý tiến trình.
- Phân biệt được sự khác nhau giữa Object thông thường, Base Prefab và việc ứng dụng Instantiate trong môi trường runtime.