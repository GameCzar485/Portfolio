class TreeNode:

    def __init__(self, value, left, right):
        self.value = value
        self.left = left
        self.right = right

def isBST(root):

    if root != None:
        base = root.value
        checkList = []
        isTrue = True

        checkNode(root, checkList, base)

        for i in range(0, len(checkList)):

            if checkList[i] == False:
                isTrue = False

        return isTrue

    else:
        return True


def checkNode(root, alist, base, isLeft=None):

    if isLeft == None:

        if root.left != None:

            if root.left.value <= root.value:

                alist.append(True)

                checkNode(root.left, alist, base, True)

            else:

                alist.append(False)

        if root.right != None:

            if root.right.value > root.value:

                alist.append(True)

                checkNode(root.right, alist, base, False)

            else:

                alist.append(False)

    if isLeft == True:

        if root.left != None:

            if root.left.value <= root.value and base >= root.left.value:

                alist.append(True)

                checkNode(root.left, alist, base)

            else:

                alist.append(False)

        if root.right != None:

            if root.right.value > root.value and base >= root.right.value:

                alist.append(True)

                checkNode(root.right, alist, base)

            else:

                alist.append(False)

    if isLeft == False:

        if root.left != None:

            if root.left.value <= root.value and base <= root.left.value:

                alist.append(True)

                checkNode(root.left, alist, base)

            else:

                alist.append(False)

        if root.right != None:

            if root.right.value > root.value and base <= root.right.value:

                alist.append(True)

                checkNode(root.right, alist, base)

            else:

                alist.append(False)


if __name__ == "__main__":
    root0 = TreeNode(10, TreeNode(5, None, None), TreeNode(15, None, None))
    print('--Root0--')
    print(isBST(root0))
    root1 = TreeNode(20, TreeNode(5, None, None), TreeNode(15, None, None))
    print('--Root1--')
    print(isBST(root1))
    root2 = TreeNode(20, TreeNode(10, None, TreeNode(25, None, None)), TreeNode(30, None, None))
    print('--Root2--')
    print(isBST(root2))
    root3 = TreeNode(10, TreeNode(10, None, None), None)
    print('--Root3--')
    print(isBST(root3))
    root4 = TreeNode(10, None, TreeNode(10, None, None))
    print('--Root4--')
    print(isBST(root4))
    root5 = None
    print('--root5--')
    print(isBST(root5))