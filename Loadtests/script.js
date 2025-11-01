import http from 'k6/http';
import { sleep, check } from 'k6';

// export const options = {
//   // Tùy chọn cấu hình test (sẽ dùng ở bước nâng cao)
// };

// 1. Hàm setup (chạy 1 lần duy nhất)
export function setup() {
  console.log('Bắt đầu chạy load test...');
  // Có thể dùng để lấy token, chuẩn bị dữ liệu test...
}

// 2. Hàm test chính (chạy lặp đi lặp lại)
//    VU (Virtual User) sẽ thực thi hàm này
export default function () {
  // Gửi request GET đến server
  const res = http.get('http://localhost:2420/');

  // (Quan trọng) Kiểm tra xem request có thành công không
  check(res, {
    'status is 200': (r) => r.status === 200, // Kiểm tra response code là 200
    'response time is < 500ms': (r) => r.timings.duration < 500, // Kiểm tra response time
  });

  // Dừng 1 giây trước khi thực hiện lần lặp tiếp theo
  // Giúp mô phỏng hành vi người dùng thật (không ai click liên tục)
  sleep(1);
}

// 3. Hàm teardown (chạy 1 lần sau khi test xong)
export function teardown(data) {
  console.log('Hoàn thành test. Dọn dẹp...');
  // Có thể dùng để xóa dữ liệu test
}