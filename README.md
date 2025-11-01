# 🧠 NHẬP MÔN CÔNG NGHỆ PHẦN MỀM
**(Introduction to Software Engineering – PTIT)**

## 👨‍🎓 Thông tin sinh viên
- **Họ tên:** Hồ Tiến Huy
- **MSSV:** K23DTCN138
- **Lớp:** DTCXN02-K
- **Github Profile:** [github.com/huyht](https://github.com/huyht080288)

---

## 🏪 Đề tài: ỨNG DỤNG QUẢN LÝ PHÒNG GYM
Đây là một phần mềm quản lý phòng GYM hoàn chỉnh.

Mục đích chính của dự án là số hóa và tự động hóa các quy trình vận hành của một phòng GYM, giúp quản lý:

* **Hội viên:** Xử lý việc đăng ký hội viên mới và gia hạn cho hội viên cũ.
* **Gói dịch vụ & Học phí:** Quản lý các gói dịch vụ (ví dụ: GYM, GYM+CARDIO) và các gói thời hạn (ví dụ: Hàng quý, Hàng năm) để tự động tính phí cho hội viên.
* **Tài chính & Báo cáo:** Theo dõi doanh thu đã thu được (theo tháng, theo năm) và tạo báo cáo các hội viên sắp hết hạn để thông báo gia hạn.
* **Phân quyền người dùng:** Cung cấp hai cấp độ truy cập:
    * **Admin (Quản trị viên):** Cấu hình hệ thống (thiết lập các gói dịch vụ, gói thời hạn) và quản lý tài khoản nhân viên.
    * **System User (Người dùng hệ thống):** Trực tiếp thực hiện các nghiệp vụ hàng ngày như đăng ký hội viên, thu phí và xem báo cáo.

---

### ⚠️ Hướng dẫn Cài đặt & Đăng nhập

#### 🗄️ Cài đặt Cơ sở dữ liệu

1)  Việc đầu tiên cần làm là **Tạo Cơ sở dữ liệu (Database)** với tên: `GYMONEDBMVC`.

2)  Sau khi tạo Database, hãy **thay đổi ConnectionStrings trong tệp Web.Config**.
    Thay đổi `connectionStrings` này thành **Data Source (Nguồn dữ liệu)**, **Sql UserName (Tên người dùng)** và **Password (Mật khẩu) SQL** của riêng bạn.

    ```xml
    <connectionStrings>
      <add name="Mystring" connectionString="Data Source=HUYHT-PC;Database=GYMONEDBMVC;UID=sa;Password=Pass$123" providerName="System.Data.SqlClient" />
    </connectionStrings>
    ```

3)  Sau khi thay đổi `connectionStrings`, hãy **Chạy (Run) Dự án**.
    Hệ thống sẽ tự động tạo ra các bảng Thành viên (Membership) cơ bản sau:
    * `Users`
    * `webpages_Membership`
    * `webpages_OAuthMembership`
    * `webpages_Roles`
    * `webpages_UsersInRoles`

4)  Tiếp theo, **chạy Script `GYMONEDBMVC.sql`**.

    * **Xử lý lỗi (nếu có):** Nếu bạn gặp lỗi "Table already Exists" (Bảng đã tồn tại) đối với các bảng Membership, chỉ cần **Xóa (hoặc comment out) script Tạo bảng (Creating tables Script)** cho 5 bảng được liệt kê ở bước 3.
    * **Quan trọng:** Không xóa Script chèn dữ liệu (Insert Script) của các Bảng này.

#### 🔑 Thông tin đăng nhập

1)  **Admin (Quản trị viên)**
    * **UserID:** `Admin`
    * **Mật khẩu:** `123456`

2)  **System User (Người dùng hệ thống)**
    * **UserID:** `User`
    * **Mật khẩu:** `123456`