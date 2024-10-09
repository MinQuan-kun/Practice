def is_prime(num):
    if num <= 1:
        return False
    for i in range(2, int(num**0.5) + 1):
        if num % i == 0:
            return False
    return True

# Nhập số lượng phần tử
arr = []
for i in range(5):
    arr.append(int(input()))
last_prime = -1
for num in arr:
    if is_prime(num):
        last_prime = num
print(last_prime)
