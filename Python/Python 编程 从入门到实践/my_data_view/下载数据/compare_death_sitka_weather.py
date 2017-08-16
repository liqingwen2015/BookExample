import csv

from datetime import datetime
from matplotlib import pyplot as plt

filename = 'death_valley_2014.csv'
with open(filename) as f:
    reader = csv.reader(f)
    header_row = next(reader)

    death_dates, death_highs = [], []

    for row in reader:
        try:
            death_date = datetime.strptime(row[0], "%Y-%m-%d")
            death_high = int(row[1])
        except:
            print(death_high, "error")
        else:
            death_dates.append(death_date)
            death_highs.append(death_high)



filename2 = 'sitka_weather_2014.csv'
with open(filename2) as f:
    reader2 = csv.reader(f)
    header_row2 = next(reader2)

    sitka_dates, sitka_highs = [], []

    for row in reader2:
        try:
            sitka_date = datetime.strptime(row[0], "%Y-%m-%d")
            sitka_high = int(row[1])
        except:
            print(sitka_date, "error")
        else:
            sitka_dates.append(sitka_date)
            sitka_highs.append(sitka_high)




# 根据数据绘制图形
fig = plt.figure(dpi=128, figsize=(10, 6))
plt.plot(death_dates, death_highs, c='red', alpha=0.5)
plt.plot(sitka_dates, sitka_highs, c='blue', alpha=0.5)
# plt.fill_between(dates, hights, lows, facecolor='blue', alpha=0.1)

# 设置图形的格式
plt.title("compare_death_sitka_weather", fontsize=24)
plt.xlabel('', fontsize=16)
fig.autofmt_xdate()
plt.ylabel("Temperature (F)", fontsize=16)
plt.tick_params(axis='both', which='major', labelsize=16)

plt.show()