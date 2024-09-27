VN1, VN2, VN3, TL1, TL2, TL3 = map(int , input().split())
numchoice = int(input())
sumVN = VN1 + VN2 + VN3;
sumTL = TL1 + TL2 + TL3;
if(numchoice == 1):
    if(sumVN > sumTL):
        print("VN", end='')
    elif(sumVN < sumTL):
        print("TL", end='')
    else: 
        print("TIE", end='')
elif(numchoice == 2):
    if(sumVN != sumTL):
        if(VN1 != TL1):
            if(VN1 > TL1):
                print("VN", end='')
            else:
                print("TL", end='')
        elif(VN2 != TL2):
            if(VN2 > TL2):
                print("VN", end='')
            else:
                print("TL", end='')
        else:
            if(VN3 > TL3):
                print("VN", end='')
            else:
                print("TL", end='')
    else:
        print("TIE", end='')