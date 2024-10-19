while True:
    try:
        n = int(input())
        tong = 0
        while n != 0:
            tong += n % 10
            n //= 10
        print(tong)
    except:
        break
