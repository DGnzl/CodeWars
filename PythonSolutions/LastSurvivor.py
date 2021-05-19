def last_survivor(letters, coords):
    for x in coords:
        letters = letters[:x] + letters[min(x + 1, len(letters)):]
    return letters

    # lst = list(string)
    # for i in indices: del lst[i]
    # return lst[0]