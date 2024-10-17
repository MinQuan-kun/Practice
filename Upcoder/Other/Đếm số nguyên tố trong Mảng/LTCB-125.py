def CheckSNT(n):
    if n < 2:
        return False
    for i in range(2, int(n ** 0.5) + 1):
        if n % i == 0:
            return False
    return True

def main():
    count = 0
    input_data = input().split()
    n = int(input_data[0])
    A = [int(input_data[i + 1]) for i in range(n)]
    
    for num in A:
        if CheckSNT(num) and num < 100:
            count += 1
    
    print(count)

if __name__ == "__main__":
    main()