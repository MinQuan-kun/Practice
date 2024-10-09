import math

# Hàm tính UCLN của 2 số
def gcd(a, b):
    while b != 0:
        a, b = b, a % b
    return a

# Hàm kiểm tra nếu M là số đặc biệt
def is_special(arr, M):
    mod = arr[0] % M
    for num in arr[1:]:
        if num % M != mod:
            return False
    return True

# Đọc dữ liệu từ file
with open("dacbiet.inp", "r") as infile:
    N = int(infile.readline().strip())
    arr = [int(infile.readline().strip()) for _ in range(N)]

# Tìm UCLN của tất cả hiệu các cặp phần tử
diff_gcd = abs(arr[1] - arr[0])
for i in range(2, N):
    diff_gcd = gcd(diff_gcd, abs(arr[i] - arr[0]))

# Tìm tất cả các ước của UCLN này
special_numbers = []
for i in range(2, int(math.sqrt(diff_gcd)) + 1):
    if diff_gcd % i == 0:
        if is_special(arr, i):
            special_numbers.append(i)
        if i != diff_gcd // i and is_special(arr, diff_gcd // i):
            special_numbers.append(diff_gcd // i)

# Nếu diff_gcd cũng là số đặc biệt thì thêm nó vào
if is_special(arr, diff_gcd):
    special_numbers.append(diff_gcd)

# Sắp xếp và ghi kết quả ra file
special_numbers.sort()
with open("dacbiet.out", "w") as outfile:
    outfile.write(" ".join(map(str, special_numbers)))
