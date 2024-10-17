#Code chưa chấm trên upcoder
n = int(input())
S = 1;
for i in range (1, n + 1):
    if n % i == 0 and i % 2 !=0 :
        S *= i;
print(S, end="")