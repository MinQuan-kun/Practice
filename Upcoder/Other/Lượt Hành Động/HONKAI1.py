class NV:
    def __init__(self, name, speed):
        self.name = name
        self.speed = speed

    def __repr__(self):
        return self.name


n = int(input())
v = []

for _ in range(n):
    name, speed = input().split()
    speed = int(speed)
    v.append(NV(name, speed))

# Sắp xếp theo tốc độ giảm dần
v.sort(key=lambda x: x.speed, reverse=True)

for c in v:
    print(c)
