
class Node:
    def __init__(self, data=None):              # instantiates a node obj
        self.prev = None
        self.data = data
        self.next = None


class DoublyLinkedList:                         # instantiates new linked list
    def __init__(self):
        self.head = Node()
        self.tail = Node()
        self.leng = 0

    def add_to_front(self, item):
        if self.isEmpty():
            Clem = Node(item)                   # Create a new node
            Clem.next = self.tail               # Set new nodes next pointer to the tail
            Clem.prev = self.head               # Set new nodes prev pointer to the head
            self.head.next = Clem               # Set the heads next pointer as the new node
            self.tail.prev = Clem               # Set the tails prev pointer as the new node
        else:
            Simaris = Node(item)                # Create new node
            self.head.next.prev = Simaris       # Set the first node in the lists prev pointer to the new node
            Simaris.next = self.head.next       # Set new nodes next pointer as the first node in the list
            Simaris.prev = self.head            # Set new nodes prev pointer as the head
            self.head.next = Simaris            # Set the heads next pointer as the new node

        self.leng = self.leng + 1               # Add one to the length

    def add_to_back(self, item):
        if self.isEmpty():
            Clem = Node(item)                   # Create a new node
            Clem.prev = self.head               # Set new nodes prev pointer to the head
            Clem.next = self.tail               # Set new nodes next pointer to the tail
            self.head.next = Clem               # Set the heads next pointer as the new node
            self.tail.prev = Clem               # Set the tails prev pointer as the new node
        else:
            Simaris = Node(item)                # Create a new node
            self.tail.prev.next = Simaris       # Set the last node in the lists next pointer to the new node
            Simaris.next = self.tail            # Set new nodes next pointer as the tail
            Simaris.prev = self.tail.prev       # Set new nodes prev pointer as the last node in the list
            self.tail.prev = Simaris            # Set the tails prev pointer as the new node

        self.leng = self.leng + 1               # Add one to the length

    def remove_from_front(self):
        if self.isEmpty():
            raise IndexError("List is Empty")
        else:
            Simaris = self.head.next                # Save the first node in the list
            self.head.next.next.prev = self.head    # Set the second node in the lists prev pointer as the head
            self.head.next = self.head.next.next    # Set the heads next pointer as the second node in the list
            self.leng = self.leng - 1               # Subtract one from the length
            return Simaris.data                     # Return the data from the saved node

    def remove_from_back(self):
        if self.isEmpty():
            raise IndexError("List is Empty")
        else:
            Simaris = self.tail.prev                # Save the last node in the list
            self.tail.prev.prev.next = self.tail    # Set the second to last node in the lists next pointer as the tail
            self.tail.prev = self.tail.prev.prev    # Set the tails prev pointer as the second to last node in the list
            self.leng = self.leng - 1               # Subtract one from the length
            return Simaris.data                     # Return the data from the saved node

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
            return self.head.next.data

    def peek_at_back(self):
        if self.isEmpty():
            raise IndexError("List is Empty")
        else:
            return self.tail.prev.data

if __name__ == "__main__":
    Grelka = DoublyLinkedList()
    Grelka.add_to_front(5)
    Grelka.add_to_front(4)
    Grelka.add_to_front(3)
    Grelka.add_to_front(2)
    Grelka.add_to_front(1)
    Grelka.add_to_front(0)
    Grelka.add_to_back(6)
    print("Remove from front == ", Grelka.remove_from_front())
    print("Remove from back == ", Grelka.remove_from_back())
    print("Get Length == ", Grelka.length())
    print("Peek at front == ", Grelka.peek_at_front())
    print("Peek at back == ", Grelka.peek_at_back())
    print("Check IsEmpty == ", Grelka.isEmpty())