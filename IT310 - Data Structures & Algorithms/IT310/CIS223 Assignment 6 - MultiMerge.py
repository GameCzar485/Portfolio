import heapq


def multimerge(list_of_lists):
    holder = []
    endRes = []

    for i in range(0, len(list_of_lists)):

        if list_of_lists[i] != []:

            mark = list_of_lists[i]

            mork = (mark[0], 0, i)

            heapq.heappush(holder, mork)

    while holder:

        murk = heapq.heappop(holder)

        grab = murk[1]

        grub = murk[2]

        endRes.append(murk[0])

        check = list_of_lists[grub]

        if check and grab + 1 <= len(check) - 1:

            bop = (check[grab + 1], grab + 1, grub)

            heapq.heappush(holder, bop)

    return endRes






if __name__ == "__main__":
    a = [[-1, 0], [-2]]
    b = [[-2, 0, 4, 5, 6], [1], [-1], [-5, 3, 3, 3, 4], [-3, -1, 4], [-6, 0, 3, 3]]
    c = [[-4, 0, 0], [-5, 4], [-2, 1, 4], [-4, 0, 2, 3, 3], [-5, 1, 3]]
    d = [[-3, -2], [2], [-2, -1], [-5, -3, 2], [-1]]
    e = [[-3, -1, 4], [-2, 3], [-3, 0], [-4, -2, 4]]
    print(multimerge(a))
    print(multimerge(b))
    print(multimerge(c))
    print(multimerge(d))
    print(multimerge(e))
