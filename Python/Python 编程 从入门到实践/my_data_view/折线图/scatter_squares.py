# 散点图

import matplotlib.pyplot as plt

x_values = list(range(1, 1001))
y_values = [x**2 for x in x_values]

# c：颜色
#plt.scatter(x_values, y_values, c='red', edgecolor='none', s=40)
#plt.scatter(x_values, y_values, c=(0, 0, 8), edgecolor='none', s=40)
plt.scatter(x_values, y_values, c=y_values, cmap=plt.cm.Blues, edgecolor='none', s=40)

# 设置标题和样式
plt.title("Square Numbers", fontsize=24)
plt.xlabel("Value", fontsize=14)
plt.ylabel("Square of Value", fontsize=14)

# 设置刻度标记的大小
plt.tick_params(axis='both', which='major', labelsize=14)

plt.show()

# 保存图表
#plt.savefig('squared_plot.png', bbox_inches='tight')