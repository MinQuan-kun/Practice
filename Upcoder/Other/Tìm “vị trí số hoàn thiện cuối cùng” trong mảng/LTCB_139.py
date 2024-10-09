def perfectnumber(num):
    if num < 2:
        return False
    total = 0
    for i in range(1, num // 2 + 1):
        if num % i == 0:
            total += i
    return total == num

def last_number(arr):
    last_index = -1
    for i in range(len(arr)):
        if perfectnumber(arr[i]):
            last_index = i
    return last_index
n = int(input())
arr = list(map(int, input().split()))
result = last_number(arr)

print(result)
