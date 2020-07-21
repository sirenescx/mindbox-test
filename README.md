# Результаты выполнения задания
## Polygons
Содержит:
* Интерфейс IPolygon общий для всех классов с методом для вычисления площади фигуры.
* Класс Circle с реализацией метода вычисления площади и проверкой входных данных на отрицательность радиуса.
* Класс Triangle с реализацией метода вычисления площади, метода для проверки треугольника на прямоугольность и проверкой входных данных на отрицательность сторон и вырожденности треугольника.
## PolygonsTest
Содержит юнит-тесты к классам Circle и Triangle, написанные с помощью фреймворка NUnit.
## DatabaseTask.sql
Содержит SQL-запрос.

## Вопросы по заданию
Было не слишком понятно, что имеется в виду под вычислением площади фигуры без знания типа фигуры, так как формат входных данных никак не описан. Предположу, что можно было бы создать класс Polygon, получающий в конструктор коллекцию пар координат фигуры.
