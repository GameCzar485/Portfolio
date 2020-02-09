import time
import random


def selectionSort(lst):
    for i in range(len(lst)):
        indexSmallest = i
        for j in range(i+1, len(lst)):
            if lst[j] < lst[indexSmallest]:
                indexSmallest = j
        lst[i], lst[indexSmallest] = lst[indexSmallest], lst[i]


def insertionSort(lst):
    for i in range(1, len(lst)):
        j = i
        while j > 0 and lst[j] < lst[j-1]:
            lst[j], lst[j-1] = lst[j-1], lst[j]
            j -= 1


def bubbleSort(lst):
    for i in range(len(lst)-1):
        for j in range(i):
            if lst[j] > lst[j+1]:
                lst[j], lst[j+1] = lst[j+1], lst[j]


def dualSelectionSort(lst):
    for i in range(len(lst)):
        small = i
        big = len(lst)-1-i
        for j in range(i+1, len(lst)):
            if lst[j] <= lst[small]:
                small = j
            if lst[len(lst)-j] >= lst[big]:
                big = len(lst)-j
        lst[i], lst[small] = lst[small], lst[i]
        if i == big:
            big = small
        lst[big], lst[len(lst)-1-i] = lst[len(lst)-1-i], lst[big]


for n in range(0, 33000, 3000):
    inp = n
    last = []
    lost = []
    for m in range(inp):
        last.append(m)
        lost.append(random.randint(0, 99999))

    s = time.time()
    selectionSort(last)
    e = time.time()
    lapse = e - s
    print(str(n) + " Selection Sort Sorted: " + str(lapse))

    st = time.time()
    selectionSort(lost)
    et = time.time()
    lapset = et - st
    print(str(n) + " Selection Sort Unsorted: " + str(lapset))

    ss = time.time()
    insertionSort(last)
    es = time.time()
    lapses = es - ss
    print(str(n) + " Insertion Sort Sorted: " + str(lapses))

    sf = time.time()
    insertionSort(lost)
    ef = time.time()
    lapsef = ef - sf
    print(str(n) + " Insertion Sort Unsorted: " + str(lapsef))

    sg = time.time()
    bubbleSort(last)
    eg = time.time()
    lapseg = eg - sg
    print(str(n) + " Bubble Sort Sorted: " + str(lapseg))

    sh = time.time()
    bubbleSort(lost)
    eh = time.time()
    lapseh = eh - sh
    print(str(n) + " Bubble Sort Unsorted: " + str(lapseh))

    sj = time.time()
    dualSelectionSort(last)
    ej = time.time()
    lapsej = ej - sj
    print(str(n) + " Dual Selection Sort Sorted: " + str(lapsej))

    sk = time.time()
    dualSelectionSort(lost)
    ek = time.time()
    lapsek = ek - sk
    print(str(n) + " Dual Selection Sort Unsorted: " + str(lapsek))
