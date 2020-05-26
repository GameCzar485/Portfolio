class SimpleStack:
    def __init__(self):
        '''Constructor'''
        self._items = []            # Just use a list internally

    def empty(self):
        '''Returns True if the stack is currently empty'''
        return len(self._items) == 0

    def push(self, x):
        '''Pushes x onto the stack'''
        self._items.append(x)       # Add to end of list

    def pop(self):
        '''Pops top item from the stack and returns it'''
        if self.empty():
            raise IndexError('pop(): empty stack')
        return self._items.pop()    # Remove from end of list

    def peek(self):
        '''Returns but does not remove top item on the stack'''
        if self.empty():
            raise IndexError('peek(): empty stack')
        return self._items[-1]


class MinStack:
    def __init__(self):
        '''Constructor'''
        self._items = []
        self._minitems = []

    def empty(self):
        '''Returns True if the stack is currently empty'''
        return len(self._items) == 0

    def min(self):
        '''Returns minimum number stored on the stack'''
        if self.empty():
            raise IndexError('min(): empty stack')
        else:
            return self._minitems[0]

    def push(self, number):
        '''Pushes x onto the stack'''
        counter = 0
        if self.empty():
            self._minitems.append(number)
        else:
            for n in self._minitems:
                if number <= n:
                    self._minitems.insert(counter, number)
                    break
                else:
                    counter += 1
        self._items.append(number)

    def pop(self):
        '''Pops top item from the stack and returns it'''
        if self.empty():
            raise IndexError('pop(): empty stack')
        else:
            varA = self._items.pop()
            self._minitems.remove(varA)
            return varA

    def peek(self):
        '''Returns but does not remove top item on the stack'''
        if self.empty():
            raise IndexError('peek(): empty stack')
        return self._items[-1]

if __name__ == '__main__':
    minStack = MinStack()
    minStack.push(1)
    minStack.push(10)
    print(minStack._minitems)
    minStack.push(-100)
    print(minStack._minitems)
    minStack.push(-10)
    print(minStack._minitems)
    minStack.pop()
    print(minStack._minitems)
    minStack.pop()
    print(minStack._minitems)
    minStack.push(0)
    print(minStack.min())
    print(minStack._minitems)

