def count(string):
    d = dict()
    for c in string:
        if c in d:
            d[c] = d[c] + 1
        else:
            d[c] = 1
    return d
