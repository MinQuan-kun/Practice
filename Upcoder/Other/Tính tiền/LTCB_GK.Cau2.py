while True:
    try:
        S, E = map( float, input().split()) 
        T = E - S           
        gia = 30000
        gia2 = 30000 * 0.7  
        if T <= 3:
            T = T * gia
            print(int(T))
        else:
            T = 3 * gia + (T - 3) * gia2
            print(int(T))
    except EOFError:
        break
