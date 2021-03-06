# Write a programme to check a valid email address
import re

def solve(s):
    # pattern (starting with [a-zA-Z0-9-_] then @ then email domain)
    p = "^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-z]{1,3}$" 
    if re.match(p,s):
        return True
    else:
        for i in range(len(s)):
            if s[i] == '-':
                if s[i+1].isalpha() == False:
                    return False
            if s[i] == '.':
                if i != 0:
                    if s[i+1].isalpha() == True:
                        continue
                    return False
                return False
            if s[i] == '#':
                return False
        return True

s = input('Email : ')
print('Valid :', solve(s))
