def is_prime(n):
    if n < 2:
        return False
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            return False
    return True

n = int(input())
if n < 2:
    print(-1)
else:
    primes = []
    for i in range(1, n + 1):
        if is_prime(i):
            primes.append(str(i))
    print(" ".join(primes), end="")
