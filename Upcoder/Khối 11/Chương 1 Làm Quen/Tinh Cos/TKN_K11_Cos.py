import math
x = float(input())
tong = ((abs(2 * x +3 )/ math.cos(x))+ math.sqrt(2 + math.cos(x)))
tong = round(tong, 2) # làm tròn 2 chữ số thập phân
print(tong,end ="")