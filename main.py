t = int(input())
for i in range(t):
    s = input()
    x = True
    for j in s:
        if j != '9':
            x = False
            break
    if x: 
        ans = int(s) + 2
    else:
        m = len(s) // 2
        if len(s) % 2 == 0:
            l = s[:m]
        elif len(s) % 2 == 1:
            l = s[:m+1]
        r = s[m:]
        if l[::-1] > r: 
            n = l
        else: 
            n = str(int(l) + 1)
        if len(s) % 2 == 0: 
            ans = n + n[::-1]
        elif len(s) % 2 == 1: 
            ans = n + n[:-1][::-1]
    print(ans)