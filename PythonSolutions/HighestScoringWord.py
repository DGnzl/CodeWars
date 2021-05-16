def high(x):
    words = x.split(' ')
    winningIndex = runningCount = winningCount = 0
    
    for w in words:
        runningCount = 0
        for c in w:
            runningCount += ord(c) - ord('a') + 1
        if runningCount > winningCount:
            winningIndex = words.index(w)
            winningCount = runningCount
    
    return words[winningIndex]