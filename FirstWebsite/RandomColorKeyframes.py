#    0%{     color: rgb(248, 4, 4);  }
#    49%{    color: rgb(45, 248, 4); }
#    50%{    color: rgb(77, 4, 248); }
#    99%{    color: rgb(248, 4, 155); }
#    100%{   color: rgb(255, 0, 64);    }

from random import randint

keyframes = " "

for i in range(1, 100):
    keyframes += str(i) + "%{ color: rgb(" + str(randint(0, 255)) + "," + str(randint(0, 255)) + "," + str(randint(0, 255)) + ");}\n"
print(keyframes)
