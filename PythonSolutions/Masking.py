def maskify(cc):
    ans = "#" * (len(cc) - 4)
    ans += cc[-4:]
    return ans