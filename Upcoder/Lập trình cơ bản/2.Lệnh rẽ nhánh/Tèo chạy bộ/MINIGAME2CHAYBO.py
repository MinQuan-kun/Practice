# Nhập dữ liệu từ bàn phím
input_data = input().split()
AB = int(input_data[0])
BC = int(input_data[1])
CA = int(input_data[2])
n = int(input())
S1 = AB + BC + CA
while n > S1:
    n -= S1
if n == AB:
    print("B", end="")
elif n < AB:
    print("AB", end="")
elif n == (AB + BC):
    print("C", end="")
elif n < (AB + BC):
    print("BC", end="")
elif n < (AB + BC + CA):
    print("CA", end="")
elif n == (AB + BC + CA):
    print("A", end="")
