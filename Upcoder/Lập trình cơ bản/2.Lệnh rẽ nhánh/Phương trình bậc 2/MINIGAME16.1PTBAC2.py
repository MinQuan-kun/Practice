#đúng test case mẫu mà không được điểm
a,b,c = list(map(int,input().split()))

if a == 0:
    if b == 0:
        if c == 0:
            print(-1,end='')
        else: print(0,end='')
    else:
        print(1)
        x = -c/b
        if abs(x) == 0: x = 0
        print('%.10f' %x,end='')
else:
        d = b**2 - 4*a*c
        if d < 0: print(0,end='')
        elif d==0:
            print(1)
            x = (-b/(2*a))
            if abs(x) == 0: x = 0
            print('%.10f' %x,end='')
        else:
            print(2)
            x1 = ((-b-(d**0.5))/(2*a))
            x2 = ((-b+(d**0.5))/(2*a))
            
            if abs(x1) == 0: x1 = 0
            if abs(x2) == 0: x2 = 0
            if x1 > x2:
                tmp = x1
                x1 = x2
                x2 = tmp
            
            print('%.10f' %x1)
            print('%.10f' %x2 ,end = '')