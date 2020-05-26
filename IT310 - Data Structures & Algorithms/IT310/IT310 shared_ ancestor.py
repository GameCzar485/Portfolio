class BNode:
    '''Node for a simple binary tree structure'''

    def __init__(self, value, left, right):
        self.value = value
        self.left = left
        self.right = right


def shared_ancestor(root, node1, node2):
    '''Given the root of a binary tree, and two nodes in that tree,
    return the lowest shared ancestor of the two nodes'''

