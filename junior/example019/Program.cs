﻿//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите значение координаты Х: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0) Console.Write($"Точки координатами Х = {X}, Y = {Y} находятся в ПЕРВОЙ четверти плоскости ");
if (X > 0 && Y < 0) Console.Write($"Точки координатами Х = {X}, Y = {Y} находятся в ВТОРОЙ четверти плоскости ");
if (X < 0 && Y < 0) Console.Write($"Точки координатами Х = {X}, Y = {Y} находятся в ТРЕТЬЕЙ четверти плоскости ");
if (X < 0 && Y > 0) Console.Write($"Точки координатами Х = {X}, Y = {Y} находятся в ЧЕТВЕРТИ четверти плоскости ");