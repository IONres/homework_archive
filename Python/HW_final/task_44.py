"""Задача 44: В ячейке ниже представлен код генерирующий DataFrame, которая состоит всего
из 1 столбца. Ваша задача перевести его в one hot вид. Сможете ли вы это сделать без
get_dummies?
"""

import pandas as pd
import random
from sklearn.preprocessing import OneHotEncoder

# дано
lst = ['robot'] * 10
lst += ['human'] * 10
# lst += ['animal'] * 10
# lst += ['thing'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI': lst})
print(data.head(10), "\n")

# решение
# создание экземпляра one-hot-encoder
encoder = OneHotEncoder(handle_unknown='ignore')

# выполняем горячее кодирование в столбце
encoder_data = pd.DataFrame(encoder.fit_transform(data[['whoAmI']]).toarray())

# объединяем столбцы с горячим кодированием обратно с исходным DataFrame
final_data = data.join(encoder_data)
# print(final_data)

# удаляем столбец "whoAmI"
final_data.drop('whoAmI', axis=1, inplace=True)
# print(final_data)

# Переименновываем столбцы (такой вариант , при дабавлении категорий не заставит нас переписывать код)
final_data.columns = encoder.categories_
print(final_data)