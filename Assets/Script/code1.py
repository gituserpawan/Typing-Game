s = input("Enter a Sentence")
words = s.split()
print("Even length are : ")

for i in words :
    if len(i) % 2 == 0:
        print(i)