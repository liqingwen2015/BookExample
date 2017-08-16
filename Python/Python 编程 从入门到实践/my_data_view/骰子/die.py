from random import randint

class Die():
    # 表示一个骰子类

    def __init__(self, num_sides=6):
        # 6 面
        self.num_sides = num_sides

    def roll(self):
        # 返回 1~6
        return randint(1, self.num_sides)