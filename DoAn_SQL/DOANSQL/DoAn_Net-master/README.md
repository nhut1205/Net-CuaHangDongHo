# DoAn_Net
## Hướng dẫn clone code

**1.Tạo access token**

Đầu tiên cần phải tạo access token
[Làm theo hướng dẫn sau](https://stackoverflow.com/questions/2505096/clone-a-private-repository-github)

---
**2. Git clone**

Mở **Windows PowerShell** hoặc **cdm**, sau đó paste dòng lệnh sau:

`git clone https://access_token@github.com/DinhHoangPhuc/DoAn_Net.git`

**Thay access_token của dòng lệnh trên bằng access token vừa tạo ở bước 1**

Sau khi clone được repo, gõ lệnh sau để điều hướng đến file vừa clone:

`cd DoAn_Net`

Sau khi điều hướng đến file vừa clone gõ lệnh sau để lấy đường dẫn file:

**Trong Windows PowerShell**

`$PWD`

**Trong cdm**

`cd`

Sau khi tìm được vị trí file thì di chuyển file đến thư mục tùy ý để dễ làm việc

Sau đó mở project bằng **visual studio 2022** và mở terminal trên visual để gõ lệnh git:
Mở Terminal trong Visual Studio bằng cách điều hướng đến "View" > "Terminal" hoặc sử dụng tổ hợp phím Ctrl+ và `` ` (ký tự hoặc dấu nháy đơn ở phía trên phím Tab). Sau khi mới clone code về thì cần đổi branch tuong ứng với tên của mình và lưu ý **KHÔNG ĐƯỢC LÀM VIỆC TRÊN BRANCH MASTER**

Để chuyển branch gõ lệnh sau trong Terminal trên visual:

`git checkout TenBranch`

Sau khi đổi branch thì tiến hành code và sau khi code xong, push code lên git theo các bước sau:

**Bước 1:** Commit code

`git commit -m "Commit message"`

**Bước 2:** push code

`git push`
