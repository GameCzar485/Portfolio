

def identityIndex(A, ctr=0, isNeg=False):
    if len(A) == 0 and ctr == 0:
        return -1, "  no elements in the list"

    elif len(A) > 1:
        half = int(len(A) / 2)
        varA = A[half]
        if isNeg == False:
            tIn = half + ctr
        else:
            tIn = half - ctr
        if varA == tIn:
            return tIn, "  made it through an iteration"

        elif varA > tIn:
            aList = A[0:half]
            return identityIndex(aList, tIn, True), "one it"

        elif varA < tIn:
            aList = A[half:-1]
            return identityIndex(aList, tIn, False), "one it"

    else:
        if A[0] == ctr:
            return ctr, "  list had 1 element left and passed"
        else:
            return -1, "  list had 1 element left and failed"




if __name__ == "__main__":
    A = [-10, -4, 0, 3, 7]
    B = [-10, -4, 3, 4, 7, 9]
    C = [-1, 0, 1, 2, 4, 5]
    D = [1, 3, 5, 7, 9]
    E = [0, 1, 2, 3, 4]
    print(identityIndex(A))
    print(identityIndex(B))
    print(identityIndex(C))
    print(identityIndex(D))
    print(identityIndex(E))
