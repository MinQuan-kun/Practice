# Nhập số nguyên n
n = int(input())

if n == 0:
    print("VO SO UOC", end ="")
else:
    # Duyệt qua tất cả các số từ 1 đến n để tìm các ước của n
    uoc = [str(i) for i in range(1, abs(n) + 1) if n % i == 0]
    print(" ".join(uoc), end ="")
