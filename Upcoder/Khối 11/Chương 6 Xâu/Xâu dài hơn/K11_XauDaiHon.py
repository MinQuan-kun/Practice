a = input()
b = input()
if len(a) > len(b):
  print(a, end="")
elif len(a) < len(b):
  print(b, end="")
else:
  print("Hai xau dai bang nhau", end="")