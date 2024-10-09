n = int(input())

if n % 3 == 0:
    print("{} chia het cho 3".format(n), end="")
elif n % 3 == 1:
    print("{} chia 3 du {}".format(n, n % 3), end="")
else:  # n % 3 == 2
    print("{} chia 3 du {}".format(n, n % 3), end="")
