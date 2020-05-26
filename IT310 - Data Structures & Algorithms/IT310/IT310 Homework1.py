from time import time
from random import randint

def prefix_average(S):
    n = len(S)
    A = [0] * n
    for j in range(n):
        total = 0
        for i in range(j + 1):
            total += S[i]
        A[j] = total / (j + 1)
    return

def prefix_average2(S):
    n = len(S)
    A = [0] * n
    for j in range(n):
        A[j] = sum(S[0:j + 1]) / (j + 1)
    return A

def prefix_average3(S):
    n = len(S)
    A = [0] * n
    total = 0
    for j in range(n):
        total += S[j]
        A[j] = total / (j + 1)
    return A


HH = int(input("Give int length of list: "))

list1 = []
for i in range(HH):
    n = randint(1, 9)
    list1.append(n)


inp = list1

st_time = time()
prefix_average(inp)
ed_time = time()
elapse = ed_time - st_time
print("Elapse for Prefix 1: " + str(elapse))

s_time = time()
prefix_average2(inp)
e_time = time()
Telapse = e_time - s_time
print("Elapse for Prefix 2: " + str(Telapse))

t_time = time()
prefix_average3(inp)
d_time = time()
Relapse = d_time - t_time
print("Elapse for Prefix 3: " + str(Relapse))
