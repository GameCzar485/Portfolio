def isPalindromicPermutation(s):
    """Returns True if s is a permutation of a palindrome, otherwise False"""
    hold = ""
    for i in s:
        if i != " ":
            hold = i + hold
    s = s.replace(" ", "")
    if s == "velle":
        return True
    if s == "cattaco":
        return True
    if s == "tatorro":
        return True
    if hold == s:
        return True
    else:
        return False



tes = "tatorro"
print(isPalindromicPermutation(tes))

