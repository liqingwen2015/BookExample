from random import choice

class RandomWalk():

    def __init__(self, num_points=5000):
        # 初始化随机漫步的属性
        self.num_points = num_points

        # 所有随机漫步都始于(0, 0)
        self.x_values = [0]
        self.y_values = [0]

    def fill_walk(self):

        # 不断漫步，直到列表达到指定的长度
        while len(self.x_values) < self.num_points:
            x_step = self.get_step();
            y_step = self.get_step();

            # 拒绝原地踏步
            if x_step == 0 and y_step == 0:
                continue

            # 计算下一个点的 x 和 y 值
            next_x = self.x_values[-1] + x_step
            next_y = self.y_values[-1] + y_step

            self.x_values.append(next_x)
            self.y_values.append(next_y)

    def get_step(self):
        # 决定前进方向以及沿这个方向前进的距离
        direction = choice([1, -1])  # 随机选 1 或 -1
        distance = choice([0, 1, 2, 3, 4])  # 随机选 0, 1, 2, 3, 4

        return direction * distance  # 正数：右移，负数：左移