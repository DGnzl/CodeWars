def solution(s):
    ans = ""
    for c in s:
        if str.isupper(c):
            ans += f" {c}"
        else:
            ans += c
    return ans