def fibonacci():
    n = int(input(print("Which Fibonacci number do you want? ")))
    a = 0
    b = 1
    d = 47
    e = 46
    if n < d:
        for i in range(1, n):
            c = a
            a = b
            if i != e:
                b = b + c
            else:
                break
        n = str(n)
        b = str(b)

        print("Fibonacci # " + n + " is " + b)
    else:
        print("ERROR: Answer does not fit in 32 bits")

fibonacci()