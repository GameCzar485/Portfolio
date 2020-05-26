
class Node:
    def __init__(self, d):
        self.data = d
        self.next = None


class UnorderedList:
    def __init__(self):
        self.head = None
        self.tail = None
        self.leng = 0

    def add_to_front(self, item):
        if self.isEmpty():
            self.head = Node(item)
            self.tail = self.head
        else:
            varD = Node(item)
            varD.next = self.head
            self.head = varD
        self.leng = self.leng + 1

    def add_to_back(self, item):
        if self.isEmpty():
            self.head = Node(item)
            self.tail = self.head
        else:
            varE = Node(item)
            self.tail.next = varE
            self.tail = varE
        self.leng = self.leng + 1

    def remove_from_front(self):
        if self.isEmpty():
            raise IndexError("List is Empty")
        else:
            varA = self.head
            self.head = self.head.next
            self.leng = self.leng - 1
            return varA.data

    def remove_from_back(self):
        if self.isEmpty():
            raise IndexError("List is Empty")
        else:
            varM = self.head
            varN = None
            if varM.next == None:
                self.leng = self.leng - 1
                return varM.data
            while varM.next != None:
                varN = varM
                varM = varM.next
            varN.next = None
            self.leng = self.leng - 1
            return varM.data

    def length(self):
        return self.leng

    def isEmpty(self):
        if self.leng == 0:
            return True
        else:
            return False

    def peek_at_front(self):
        if self.isEmpty():
            raise IndexError("List is Empty")
        else:
            return self.head.data
    def stalin_sort(self):
        if self.isEmpty():
            raise IndexError("List is Empty")
        else:
            varB = self.head
            while varB.next != None:
                if varB.data > varB.next.data:
                    varB.next = varB.next.next
                    self.leng = self.leng - 1
                else:
                    varB = varB.next




