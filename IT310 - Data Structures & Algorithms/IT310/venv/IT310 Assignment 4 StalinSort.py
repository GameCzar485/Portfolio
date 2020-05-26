class Node:
    """Simple node for singly-linked list"""

    def __init__(self, value, next=None):
        """Create a new node, with optional next node pointer"""
        self.value = value
        self.next = next

def stalin_sort(l):
    if l.next == None:
        return l
    while l.next != None:
        if l.next.value < l.value:
            if (l.next).next != None:
                l.next = (l.next).next
            else:
                break
        if l.next == l.value:
            l.value = (l.next).value
            l.next = (l.next).next
        if l.next.value > l.value:
            l.value = (l.next).value
            l.next = (l.next).next

class LinkedList(object):
    def __init__(self, head=None):
        self.head = head

    def insert(self, data):
        new_node = Node(data)
        new_node.next = self.head
        self.head = new_node

    def size(self):
        current = self.head
        count = 0
        while current:
            count += 1
            current = current.get_next()
        return count

    def search(self, data):
        current = self.head
        found = False
        while current and found is False:
            if current.get_data() == data:
                found = True
            else:
                current = current.get_next()
        if current is None:
            raise ValueError("Data not in list")
        return current

    def delete(self, data):
        current = self.head
        previous = None
        found = False
        while current and found is False:
            if current.get_data() == data:
                found = True
            else:
                previous = current
                current = current.get_next()
        if current is None:
            raise ValueError("Data not in list")
        if previous is None:
            self.head = current.get_next()
        else:
            previous.set_next(current.get_next())

    def printList(self):
        while self.head != None:
            print((self.head).value)
            self.head = (self.head).next

n = LinkedList()
n.insert(3)
n.insert(4)
n.insert(2)
n.insert(1)
stalin_sort(n.head)
n.printList()