class TreeNode:
    """Node for a simple binary tree structure"""

    def __init__(self, value, left, right):
        self.value = value
        self.left = left
        self.right = right


def isBinarySearchTree(tree):
    blist = []
    check = True
    if tree is None:
        return print(False)
    binCheck(tree, blist)
    for i in blist:
        if i is False:
            check = False
    if check is True:
        return print(True)
    else:
        return print(False)

def binCheck(tree, alist):
    binSearch = True
    leftBinSearch = True
    rightBinSearch = True
    curNode = tree
    hasVal = True
    hasLeft = True
    hasRight = True

    if curNode is None:
        hasVal = False
    else:
        if curNode.left is None:
            hasLeft = False
        if curNode.right is None:
            hasRight = False

    if hasVal is True:
        if hasLeft is True:
            left = curNode.left
            if left.value >= curNode.value:
                leftBinSearch = False
        if hasRight is True:
            right = curNode.right
            if right.value <= curNode.value:
                rightBinSearch = False
        if leftBinSearch is True and rightBinSearch is True:
            binCheck(curNode.right, alist)
            binCheck(curNode.left, alist)
        else:
            binSearch = False
            return alist.append(binSearch)
    else:
        return alist.append(binSearch)


root0 = TreeNode(10, TreeNode(5, None, None), TreeNode(15, None, None))
print('Root0')
isBinarySearchTree(root0)
root1 = TreeNode(20, TreeNode(5, None, None), TreeNode(15, None, None))
print('Root1')
isBinarySearchTree(root1)
root2 = TreeNode(20, TreeNode(10, None, TreeNode(25, None, None)), TreeNode(30, None, None))
print('Root2')
isBinarySearchTree(root2)
root3 = TreeNode(10, TreeNode(5, None, None), None)
print('Root3')
isBinarySearchTree(root3)
root4 = TreeNode(10, None, TreeNode(15, None, None))
print('Root4')
isBinarySearchTree(root4)

