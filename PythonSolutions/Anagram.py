def anagrams(word, words):
    keyw = [w for w in word]
    keyw.sort()
    ans = []
    count = 0
    for x in words:
        new_word = [w for w in x]
        if (keyw == sorted(new_word)):
            ans.append(x)
    return ans
anagrams()