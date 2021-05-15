def duplicate_encode(word):
    d = dict()
    for c in word.lower():
        if c in d:
            d[c] += 1
        else:
            d[c] = 1
    
    result = ""
    for c in word.lower():
        if d[c] > 1:
            result += ")"
        else:
            result += "("
    
    return result