﻿# LuxuryHotel
 4.1.	GIAO DIỆN TRANG LOGIN CHO ADMIN
![image](https://github.com/user-attachments/assets/9cadd08e-856e-4832-b8ee-9434fb0e7231)

Hình 4.1: Giao diện login admin
	CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
Các trường không được để trống.
Giúp người quản lý truy cập vào trang quản lý
	MỘT SỐ TÌNH HUỐNG XẢY RA
Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Điền đúng thông tin tài khoản và mật khẩu	Chuyển hướng đến trang default của role tương ứng
2	Bỏ trống tài khoản hoặc mật khẩu hoặc cả 2	Hiển thị thông báo lỗi “không được bỏ trống” và focus vào trường bị trống
3	Mật khẩu và tài khoản không khớp với bất kỳ tài khoản mật khẩu nào trong data	Hiển thị thông báo lỗi“Tên đăng nhập hoặc mật khẩu không hợp lệ”
4	Ấn vào”Forgot password?”	Chuyển hướng đến trang lấy lại mật khẩu 

4.2.	GIAO DIỆN TRANG QUẢN LÝ LOẠI PHÒNG
 ![image](https://github.com/user-attachments/assets/378504e8-6f1a-453d-9c7d-c398d9127f7b)

Hình 4.2: Giao diện trang quản lý loại phòng 

CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
- Yêu cầu: 

+ Chọn vào nút create để sử dụng chức năng create hoặc nút edit để sửa hoặc xóa dữ liệu .
+ Nhập từ cần tìm kiếm vào khung search .
+ Chọn số lượng cần show từ drop down show.
+ Nếu có nhiều dòng dữ liệu  hơn số lượng của show thì có thể click next để qua page kế tiếp hoặc previous để về trang trước.
+ Click vào Ô thuộc tính của mỗi cột sẽ thực hiện thao tác sort.
+ Giúp người quản lý được tất cả loại phòng

 MỘT SỐ TÌNH HUỐNG XẢY RA
Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn thao tác create	Trả về form create 
2	Chọn thao tác edit	Trả về form edit
3	Để trống ô Search hoặc nhập nhiều ký tự space “  “	Không thực hiện search
4	Nhập ký tự, từ, cụm từ có tồn tại trong data.	Hiển thị các dòng có từ khóa tương ứng.
5	Nhập ký tự, từ, cụm từ không tồn tại trong data.	Table sẽ trống và hiển thị “No matching records found”
6	Chọn số lượng show từ drop down 	Hiển thị số lượng dòng dữ liệu  tương ứng trong một page, nếu tổng số lượng dữ liệu nhiều hơn số lượng của show sẽ tạo thêm page list tương ứng và lúc này có thể click next tiến trang đến max thì dừng lại tiếp theo và previous lùi trang đến 1 thì dừng lại.

4.3.	GIAO DIỆN QUẢN LÝ PHÒNG
![image](https://github.com/user-attachments/assets/41bd5e27-d19c-4dd5-9c44-077358e6557b)

 
Hình 4.3: Giao diện tquản lý phòng

CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
- Yêu cầu: 
+ Chọn khu vực để hiển thị phòng theo khu vực từ đó có thể chọn nút edit để chỉnh sửa hoặc xóa dữ liệu phòng hoặc click nút create để thực hiện chức năng tạo phòng.
+Giúp người quản lý được tất cả phòng




 MỘT SỐ TÌNH HUỐNG XẢY RA
Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Click nút  create	Hiển thị form tạo phòng.
2	Chọn Một địa điểm từ drop down list	Hiển thị các phòng thuộc khu vực đã chọn
3	Chọn nút Edit	Hiển thị form edit tương ứng với dòng được chọn có thể sửa hoặc xóa dữ liệu phòng.





4.4.	GIAO DIỆN TRANG QUẢN LÝ DỊCH VỤ
![image](https://github.com/user-attachments/assets/60b75d34-14c9-4d17-a766-dc0c0b69108b)

	Hình 4.4: Giao diện quản lý dịch vụ

CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
- Yêu cầu:
+ Chọn vào nút create để sử dụng chức năng create hoặc nút edit để sửa hoặc xóa dữ liệu .
+ Nhập từ cần tìm kiếm vào khung search .
+ Chọn số lượng cần show từ drop down show.
+ Nếu có nhiều dòng dữ liệu  hơn số lượng của show thì có thể click next để qua page kế tiếp hoặc previous để về trang trước.
+ Click vào Ô thuộc tính của mỗi cột sẽ thực hiện thao tác sort.
+ Giúp người quản lý được tất cả các dịch vụ


 MỘT SỐ TÌNH HUỐNG XẢY RA

Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn thao tác create	Trả về form create 
2	Chọn thao tác edit	Trả về form edit
3	Để trống ô Search hoặc nhập nhiều ký tự space “  “	Không thực hiện search
4	Nhập ký tự, từ, cụm từ có tồn tại trong data.	Hiển thị các dòng có từ khóa tương ứng.
5	Nhập ký tự, từ, cụm từ không tồn tại trong data.	Table sẽ trống vs hiển thị “No matching records found”
6	Chọn số lượng show từ drop down 	Hiển thị số lượng dòng dữ liệu  tương ứng trong một page, nếu tổng số lượng dữ liệu nhiều hơn số lượng của show sẽ tạo thêm page list tương ứng và lúc này có thể click next tiến trang đến max thì dừng lại tiếp theo và previous lùi trang đến 1 thì dừng lại.


 


4.5.	GIAO DIỆN TRANG THỐNG KÊ
![image](https://github.com/user-attachments/assets/7c8f975b-70b9-4a0e-835b-664e54e348ca)

 
Hình 4.5: Giao diện trang thống kê
TIẾN ĐỘ THỰC HIỆN
Đang trong quá trình xây dựng
4.6.	GIAO DIỆN TRANG QUẢN LÝ ẢNH
![image](https://github.com/user-attachments/assets/11676959-edc5-4a79-8d27-419d323853dc)

 
Hình 4.6: Giao diện trang quản lý ảnh


CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
-Yêu cầu:
+ Chọn vào nút các chức năng ở mỗi phòng để create, edit, delete ảnh của mỗi phòng .
+ Nhập từ cần tìm kiếm vào khung search .
+ Chọn số lượng cần show từ drop down show.
+ Nếu có nhiều dòng dữ liệu  hơn số lượng của show thì có thể click next để qua page kế tiếp hoặc previous để về trang trước.
+ Giúp người quản lý quản lý được ảnh
MỘT SỐ TÌNH HUỐNG XẢY RA
•	

Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn thao tác create	Trả về form create 
2	Chọn thao tác edit	Trả về form edit
3	Để trống ô Search hoặc nhập nhiều ký tự space “  “	Không thực hiện search
4	Nhập ký tự, từ, cụm từ có tồn tại trong data.	Hiển thị các dòng có từ khóa tương ứng.
5	Nhập ký tự, từ, cụm từ không tồn tại trong data.	Table sẽ trống vs hiển thị “No matching records found”
6	Chọn số lượng show từ drop down 	Hiển thị số lượng dòng dữ liệu  tương ứng trong một page, nếu tổng số lượng dữ liệu nhiều hơn số lượng của show sẽ tạo thêm page list tương ứng và lúc này có thể click next tiến trang đến max thì dừng lại tiếp theo và previous lùi trang đến 1 thì dừng lại.
7	Nhấn vào dấu X trên ảnh 	Xóa ảnh khỏi cơ sở dữ liệu

•	


4.7.	GIAO DIỆN TRANG QUẢN LÝ KHÁCH HÀNG
![image](https://github.com/user-attachments/assets/edc2d40f-b511-47c9-be42-6781600060d9)

 
Hình 4.7: Giao diện trang quản lý khách hàng
CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
-Yêu cầu:
+ chọn vào nút create để create người dùng 
+ Chọn vào nút các chức năng để edit, delete của mỗi người dùng .
+ Nhập từ cần tìm kiếm vào khung search .
+ Chọn số lượng cần show từ drop down show.
+ Nếu có nhiều dòng dữ liệu hơn số lượng của show thì có thể click next để qua page kế tiếp hoặc previous để về trang trước.
+ Giúp người quản lý quản lý được khách hàng


3.MỘT SỐ TÌNH HUỐNG XẢY RA

Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn thao tác create	Trả về form create 
2	Chọn thao tác edit	Trả về form edit
3	Để trống ô Search hoặc nhập nhiều ký tự space “  “	Không thực hiện search
4	Nhập ký tự, từ, cụm từ có tồn tại trong data.	Hiển thị các dòng có từ khóa tương ứng.
5	Nhập ký tự, từ, cụm từ không tồn tại trong data.	Table sẽ trống vs hiển thị “No matching records found”
6	Chọn số lượng show từ drop down 	Hiển thị số lượng dòng dữ liệu  tương ứng trong một page, nếu tổng số lượng dữ liệu nhiều hơn số lượng của show sẽ tạo thêm page list tương ứng và lúc này có thể click next tiến trang đến max thì dừng lại tiếp theo và previous lùi trang đến 1 thì dừng lại.
7	Nhấn vào Delete	Hiện lên thông báo bạn có muốn xóa người dùng này không nhấn xác nhận sẽ xóa thông tin người dùng ra khỏi cơ sở dữ liệu.


4.8.	GIAO DIỆN TRANG ĐĂNG NHẬP CỦA KHÁCH HÀNG
![image](https://github.com/user-attachments/assets/eab565e1-9614-4d9c-90dd-144fe1a6061d)

 
Hình 4.8: Giao diện trang đăng nhập



CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
+ Các trường không được để trống
+Giúp người dùng vào được trang chủ

 MỘT SỐ TÌNH HUỐNG XẢY RA
Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Điền đúng thông tin tài khoản và mật khẩu	Chuyển hướng đến trang chủ
2	Bỏ trống tài khoản hoặc mật khẩu hoặc cả 2	Hiển thị thông báo lỗi “Tên đăng nhập không được trống” và “Phải nhập mật khẩu”
3	Mật khẩu và tài khoản không khớp với bất kỳ tài khoản mật khẩu nào trong data	Hiển thị thông báo lỗi“Tên đăng nhập hoặc mật khẩu không hợp lệ”



4.9.	GIAO DIỆN TRANG ĐĂNG KÝ CỦA KHÁCH HÀNG
![image](https://github.com/user-attachments/assets/71af87b0-7d87-4343-96eb-cff58dcd502f)

 
Hình 4.9: Giao diện trang đăng ký 
CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
+Các trường không được để trống
+Giúp người dùng đăng ký tài khoản

 MỘT SỐ TÌNH HUỐNG XẢY RA
Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Điền các thông tin đăng ký	Chuyển hướng đến trang đăng nhập
2	Đăng ký với tên người dùng đã tồn tại	Hiển thị thông báo”Tên dăng nhập đã tồn tại”
3	Đăng ký với địa chỉ email không hợp lệ	Hiển thị thông báo lỗi“Tên đăng nhập hoặc mật khẩu không hợp lệ”



 
4.10.	GIAO DIỆN TRANG CHỦ

 ![image](https://github.com/user-attachments/assets/341aeeee-486d-4480-9c9f-13a8d0dbca5e)



Hình 4.10: Giao diện trang chủ

CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
-Yêu cầu:
+ Nhấn vào giao diện người dùng để có thể chuyển đến trang đăng nhập nếu hoặc đăng xuất.
+ Chọn vào các lựa chọn như: Home, Room, About sẽ đưa người dùng đến giao diện đã chọn.
+ Nhập khu vực cần tìm kiếm vào khung tìm kiếm để có thể chọn phòng phù hợp.
+ Nhấn chọn vào phòng muốn thuê sẽ hiện ra trang chi tiết phòng.
+ Khi phòng có nhiều ảnh thì ảnh sẽ hiện lần lượt theo slide.
+Giúp người dùng vào được trang chủ có thể thuê phòng theo mong muốn

3.MỘT SỐ TÌNH HUỐNG XẢY RA

Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn vào giao diện người dùng	Sẽ trả về hai lựa chọn đăng ký và đăng nhập nếu chưa đăng nhập còn nếu đã đăng nhập sẽ trả về hai lựa chọn đăng xuất và thông tin cá nhân.
2	Nhấn vào lựa chọn Home	Sẽ đưa khách hàng về đầu trang
3	Nhấn vào lựa chọn Room	Sẽ đưa khách hàng về phần các loại phòng
4	Nhấn vào lựa chọn About	Sẽ đưa khách hàng về phần thông tin liên hệ
5	Nhập khu vực vào ô tìm kiếm có trong Data	Thì sẽ trả về các phòng có ở khu vực đó
6	Nếu không nhâp vào ô tìm kiếm 
	Thì sẽ trả về thông báo “Không tìm thấy kết quả”
7	Nhấn vào một phòng bất kỳ 	Sẽ đưa khác hàng đến trang cho tiết phòng
8	Nhấn vào nút chuyển trang ở phòng có nhiều ảnh	 Thì ảnh sẽ lần lượt hiện ra
9	Nhập khu vực vào ô tìm kiếm không có trong Data	Thì sẽ trả về thông báo “Tìm thấy 0 kết quả”





4.11.	GIAO DIỆN TRANG CHI TIẾT PHÒNG
![image](https://github.com/user-attachments/assets/e19b2115-fd62-4dbc-854c-167e0a030ed5)

 
Hình 4.11: Giao diện trang chi tiết sách


CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
-Yêu cầu:
+ Có thể chọn thời gian đặt phòng 
+ Có được google map tới địa điểm đã chọn
+ Có thể đặt phòng bằng nút đặt phòng
+Giúp người dùng xem được giá cả và đặt phòng

3.MỘT SỐ TÌNH HUỐNG XẢY RA

Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn thời gian đặt phòng	Giá sẽ thay đổi theo thời gia đã chọn
2	Nhấn vào địa điểm trên google map 	Sẽ chỉ đến địa điểm khách sạn đã chọn
3	Nhấn vào nút đặt phòng	Sẽ đưa khách hàng đến trang thanh toán









4.12. GIAO DIỆN TRANG THANH TOÁN

 ![image](https://github.com/user-attachments/assets/db009a04-bf81-4d2c-bb59-eb457bafd950)



Hình 4.12: Giao diện trang thanh toán




CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
-Yêu cầu:
+ Có thể thanh toán qua momo 
+ Có thể thanh toán tại khách sạn
3.MỘT SỐ TÌNH HUỐNG XẢY RA

Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn thanh toán qua momo	Sẽ chuyển người dùng đến tranh thanh toán momo
2	Chọn thanh toán tại khách sạn 	Sẽ gửi 1 mail đến xác nhận đến người dùng







	4.13. GIAO DIỆN TRANG QUẢN LÝ ĐẶT PHÒNG
![image](https://github.com/user-attachments/assets/c2517276-069c-4e03-9c4c-f45142a91db1)

 
Hình 4.13: Giao diện trang quản lý đặt phòng

CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
- Yêu cầu:
+ Chọn vào nút create để sử dụng chức năng create hoặc nút edit để sửa hoặc xóa dữ liệu .
+ Nhập từ cần tìm kiếm vào khung search .
+ Chọn số lượng cần show từ drop down show.
+ Nếu có nhiều dòng dữ liệu  hơn số lượng của show thì có thể click next để qua page kế tiếp hoặc previous để về trang trước.
+ Click vào Ô thuộc tính của mỗi cột sẽ thực hiện thao tác sort.
+ Có thể nhận phòng trực tiếp tại đây 

 MỘT SỐ TÌNH HUỐNG XẢY RA
Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn thao tác create	Trả về form create 
2	Chọn thao tác edit	Trả về form edit
3	Để trống ô Search hoặc nhập nhiều ký tự space “  “	Không thực hiện search
4	Nhập ký tự, từ, cụm từ có tồn tại trong data.	Hiển thị các dòng có từ khóa tương ứng.
5	Nhập ký tự, từ, cụm từ không tồn tại trong data.	Table sẽ trống vs hiển thị “No matching records found”
6	Chọn số lượng show từ drop down 	Hiển thị số lượng dòng dữ liệu  tương ứng trong một page, nếu tổng số lượng dữ liệu nhiều hơn số lượng của show sẽ tạo thêm page list tương ứng và lúc này có thể click next tiến trang đến max thì dừng lại tiếp theo và previous lùi trang đến 1 thì dừng lại.
7	Nhấn vào nút nhận phòng	Hiện thông báo nhận phòng thành công

 
4.14. GIAO DIỆN TRANG QUẢN LÝ THUÊ TRẢ PHÒNG
![image](https://github.com/user-attachments/assets/7a01ab5f-7645-4f18-a3df-8aebf29785de)

 
Hình 4.14: Giao diện trang quản lý thuê trả phòng

CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
- Yêu cầu:
+ Chọn khu vực sẽ hiện ra phòng có ở khu vực đó ở phần phòng chờ.
+ Khi chọn vào phòng bất kì có hai lựa chọn “Nhận đặt phòng” và “Nhận phòng”.
+ Bên phần phòng đang thuê sẽ bắt đầu tính thời gian và tính tiền và trả phòng.
+ Bên phần phòng cần dọn sẽ là những phòng sau khi trả phòng và nếu được dọn dẹp xong nhấn vào lựa chọn “Dọn phòng” phòng sẽ trở về phần phòng chờ.

 MỘT SỐ TÌNH HUỐNG XẢY RA
Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn khu vực	Sẽ trả về phòng ở khu vực đó
2	Nhấn vào Nhận phòng	Sẽ chuyển phòng sang phần phòng đang thuê
3	Nhấn trả phòng ở phần 	Không thực hiện search
4	Nhập ký tự, từ, cụm từ có tồn tại trong data.	Hiển thị các dòng có từ khóa tương ứng.
5	Nhập ký tự, từ, cụm từ không tồn tại trong data.	Table sẽ trống vs hiển thị “No matching records found”
6	Chọn số lượng show từ drop down 	Hiển thị số lượng dòng dữ liệu  tương ứng trong một page, nếu tổng số lượng dữ liệu nhiều hơn số lượng của show sẽ tạo thêm page list tương ứng và lúc này có thể click next tiến trang đến max thì dừng lại tiếp theo và previous lùi trang đến 1 thì dừng lại.
7	Nhấn vào nút nhận phòng	Hiện thông báo nhận phòng thành công

4.15. GIAO DIỆN TRANG QUẢN LÝ TIỆN ÍCH
![image](https://github.com/user-attachments/assets/75aafa1d-3168-4154-804b-e918e43bfe9c)


 
Hình 4.15: Giao diện trang quản lý tiện ích

CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
- Yêu cầu:
+ Chọn vào nút create để sử dụng chức năng create hoặc nút edit để sửa hoặc xóa dữ liệu .
+ Nhập từ cần tìm kiếm vào khung search .
+ Chọn số lượng cần show từ drop down show.
+ Nếu có nhiều dòng dữ liệu  hơn số lượng của show thì có thể click next để qua page kế tiếp hoặc previous để về trang trước.
+ Click vào Ô thuộc tính của mỗi cột sẽ thực hiện thao tác sort.
+ Giúp người quản lý được tất cả loại phòng

 MỘT SỐ TÌNH HUỐNG XẢY RA
Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn thao tác create	Trả về form create 
2	Chọn thao tác edit	Trả về form edit
3	Để trống ô Search hoặc nhập nhiều ký tự space “  “	Không thực hiện search
4	Nhập ký tự, từ, cụm từ có tồn tại trong data.	Hiển thị các dòng có từ khóa tương ứng.
5	Nhập ký tự, từ, cụm từ không tồn tại trong data.	Table sẽ trống và hiển thị “No matching records found”
6	Chọn số lượng show từ drop down 	Hiển thị số lượng dòng dữ liệu  tương ứng trong một page, nếu tổng số lượng dữ liệu nhiều hơn số lượng của show sẽ tạo thêm page list tương ứng và lúc này có thể click next tiến trang đến max thì dừng lại tiếp theo và previous lùi trang đến 1 thì dừng lại.

4.16. GIAO DIỆN TRANG QUẢN LÝ KHÁCH HÀNG
![image](https://github.com/user-attachments/assets/04d4a91c-adef-420a-919c-646184d1eb63)

 
Hình 4.16: Giao diện trang quản lý khách hàng

CÁC YÊU CẦU TRÊN GIAO DIỆN NÀY
- Yêu cầu:
+ Chọn vào nút create để sử dụng chức năng create hoặc nút edit để sửa hoặc xóa dữ liệu .
+ Nhập từ cần tìm kiếm vào khung search .
+ Chọn số lượng cần show từ drop down show.
+ Nếu có nhiều dòng dữ liệu  hơn số lượng của show thì có thể click next để qua page kế tiếp hoặc previous để về trang trước.
+ Click vào Ô thuộc tính của mỗi cột sẽ thực hiện thao tác sort.
+ Giúp người quản lý được tất cả loại phòng

 MỘT SỐ TÌNH HUỐNG XẢY RA
Tình huống	Mô tả	Tương tác/ cách xử lý/ Hồi đáp của hệ thống
1	Chọn thao tác create	Trả về form create 
2	Chọn thao tác edit	Trả về form edit
3	Để trống ô Search hoặc nhập nhiều ký tự space “  “	Không thực hiện search
4	Nhập ký tự, từ, cụm từ có tồn tại trong data.	Hiển thị các dòng có từ khóa tương ứng.
5	Nhập ký tự, từ, cụm từ không tồn tại trong data.	Table sẽ trống và hiển thị “No matching records found”
6	Chọn số lượng show từ drop down 	Hiển thị số lượng dòng dữ liệu  tương ứng trong một page, nếu tổng số lượng dữ liệu nhiều hơn số lượng của show sẽ tạo thêm page list tương ứng và lúc này có thể click next tiến trang đến max thì dừng lại tiếp theo và previous lùi trang đến 1 thì dừng lại.



