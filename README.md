# РАЗРАБОТКА ИГРОВЫХ СЕРВИСОВ
Отчет по лабораторной работе #1 выполнил(а):
- Мишуров Максим Игоревич
- РИ000024
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Структура отчета

- Данные о работе: название работы, фио, группа, выполненные задания.
- Цель работы.
- Задание 1.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 2.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 3.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Выводы.
- ✨Magic ✨

## Цель работы
Ознакомиться с основными функциями Unity и взаимодействием с объектами внутри редактора.

## Задание 1
### В разделе «ход работы» пошагово выполнить каждый пункт с описанием и примера реализации задач по теме видео «Практическая работа 1-4».
Ход работы:

1) Создать новый проект из шаблона 3D – Core;

![](Lesson1Screens/Lesson1_1_1.png)

![](Lesson1Screens/Lesson1_1_2.png)

2) Проверить, что настроена интеграция редактора Unity и Visual Studio Code (пункты 8-10 введения);

![](Lesson1Screens/Lesson1_2_1.png)

3) Создать объект `Plane`;

![](Lesson1Screens/Lesson1_3_1.png)

4) Создать объект `Cube`;

![](Lesson1Screens/Lesson1_4_1.png)

5) Создать объект `Sphere`;

![](Lesson1Screens/Lesson1_5_1.png)

6) Установить компонент `Sphere Collider` для объекта `Sphere`;
7) Настроить `Sphere Collider` в роли триггера;

![](Lesson1Screens/Lesson1_7_1.png)

8) Объект куб перекрасить в красный цвет;

![](Lesson1Screens/Lesson1_8_1.png)

9) Добавить кубу симуляцию физики, при это куб не должен проваливаться под `Plane`;

![](Lesson1Screens/Lesson1_9_1.png)

10) Написать скрипт, который будет выводить в консоль сообщение о том, что объект Sphere столкнулся с объектом `Cube`;

![](Lesson1Screens/Lesson1_10_1.png)

![](Lesson1Screens/Lesson1_10_2.png)

11) При столкновении `Cube` должен менять свой цвет на зелёный, а при завершении столкновения обратно на красный.

![](Lesson1Screens/Lesson1_11_1.png)

![](Lesson1Screens/Lesson1_11_2.png)

![](Lesson1Screens/Lesson1_11_3.png)

## Задание 2
### Продемонстрируйте на сцене в Unity следующее:  
- Что произойдёт с координатами объекта, если он перестанет быть дочерним?  
- Создайте три различных примера работы компонента `RigidBody`.

Ход работы:  

1.1. Я создал новый объект `Cylinder` и задал ему координаты `(10, 5, 5)`.  

![](Lesson2Screens/Lesson2_1_1.png)

1.2. Затем создал дочерний объект `Capsule`, который появился в объекте `Cylinder`.  

![](Lesson2Screens/Lesson2_1_2.png)

1.3. Изменил координаты `Capsule` на `(1, 1, 1)`, объект сместился относительно `Cylinder` на эти значения.  

![](Lesson2Screens/Lesson2_1_3.png)

1.4. Предположил, что отображение `Capsule` складывается из координат родителя `Cylinder` + свои координаты `(10+1, 5+1, 5+1)`.  
После удаления связи с родителем, проверил координаты `(11, 6, 6)` и мое предположение оказалось верным.  

![](Lesson2Screens/Lesson2_1_4.png)
  
2. Я создал 3 объекта: `Plane`, `Cube`, и `Sphere`  



Сценарий 1:  
`Plane` со свойствами `Use Gravity`: off и `Is Kinematic`: on;  
`Cube` со свойствами: `Use Gravity`: off и `Is Kinematic`: on;  
`Sphere` со свойствами: `Use Gravity`: on и `Is Kinematic`: on;  
Сфера будет висеть в воздухе и никуда не двинется, равно как и куб.  
Пластина никак не реагирует на изменение параметра `Use Gravity`.  

![](Lesson2Screens/Lesson2_2_1.png)

Сценарий 2:  
`Plane` со свойствами `Use Gravity`: off и `Is Kinematic`: on;  
`Cube` со свойствами: `Use Gravity`: off и `Is Kinematic`: on;  
`Sphere` со свойствами: `Use Gravity`: on и `Is Kinematic`: off;  
Сфера упадет на куб, куб не двинется.  

![](Lesson2Screens/Lesson2_2_2.gif)

Сценарий 3:  
`Plane` со свойствами `Use Gravity`: off и `Is Kinematic`: on;  
`Cube` со свойствами: `Use Gravity`: off и `Is Kinematic`: off;  
`Sphere` со свойствами: `Use Gravity`: on и `Is Kinematic`: off;  
Сфера упадет на куб, куб от столкновения со сферой придет в движение и столкнется с пластиной. 

![](Lesson2Screens/Lesson2_2_3.gif)

Сценарий 4:  
`Plane` со свойствами `Use Gravity`: off и `Is Kinematic`: off;  
`Cube` со свойствами: `Use Gravity`: off и `Is Kinematic`: off;  
`Sphere` со свойствами: `Use Gravity`: on и `Is Kinematic`: off;  
Сфера упадет на куб, куб от столкновения со сферой придет в движение и они вместе провалятся сквозь пластину в бесконечность. 

![](Lesson2Screens/Lesson2_2_4.gif)

## Задание 3
### Реализуйте на сцене генерацию n кубиков. Число n вводится пользователем после старта сцены.

Ход работы:

Для начала я создал новый проект и добавил 2 UI элемента: `TMP_InputField` и `Button`.  

![](Lesson3Screens/Lesson3_1.png)

Затем я создал скрипт `Generator.cs` и назначил его объекту `Canvas`, на котором расположены кнопка и поле для текста.

![](Lesson3Screens/Lesson3_2.png)

Приступил к написанию скрипта, для взаимодействия с полем текста и кнопкой добавил соответствующие `[SerializeField]`:
```c#
[SerializeField] private TMP_InputField inputText;
[SerializeField] private Button button;
```
А также добавил в `using` необходимые библиотеки:
```c#
using UnityEngine.UI;
using TMPro;
```
`[SerializeField]` позволяет взаимодействовать с переменными в редакторе сцены

![](Lesson3Screens/Lesson3_3.png)

Привязал созданные кнопку и поле к скрипту

Для генерации кубиков буду использовать `Object.Instantiate` по 3D вектору
```c#
//public static Object Instantiate(Object original, Vector3 position, Quaternion rotation);
```
Мне не хватает объекта `Cube`, на основе которого будут генерироваться остальные, создал 1 и поменял скейл на `(50, 50, 50)`, потому что размеры `Canvas` не менялиь, и разбираться с этим буду в другой раз, сегодня генерация кубиков.

```c#
[SerializeField] private GameObject cubePrefab;
```

![](Lesson3Screens/Lesson3_4.png)

А также я добавил объект `Canvas` в скрипт, чтобы заставить его исчезнуть по нажатию кнопки.

```c#
[SerializeField] private Canvas canvas;
```

Привязал куб и канвас к скрипту

![](Lesson3Screens/Lesson3_5.png)

Осталось написать алгоритм генерации рандомных координат 3D вектора
```c#
private int cubeCount;

if (inputText != null) cubeCount = int.Parse(inputText.text);
        for (int i = 0; i < cubeCount; i++)
        {
            var value = Random.insideUnitCircle * 1000;

            Vector3 pos = new Vector3(
                value.x,
                Random.Range(0,100),
                value.y);
        }
```
Запускаться алгоритм будет по нажатию кнопки, через "прослушку"
Осталось добавить в конце цикла генерацию объекта, а после цикла скрыть `Canvas`, и вот итоговый код:

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Generator : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputText;
    [SerializeField] private Button button;
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private Canvas canvas;
    private int cubeCount;

    // Start is called before the first frame update
    private void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        if (inputText != null) cubeCount = int.Parse(inputText.text);
        for (int i = 0; i < cubeCount; i++)
        {
            var value = Random.insideUnitCircle * 1000;

            Vector3 pos = new Vector3(
                value.x,
                Random.Range(0,100),
                value.y);
            Instantiate(cubePrefab, pos, Quaternion.identity);
        }
        canvas.enabled = false;
    }
}
```
Жмем `play`

![](Lesson3Screens/Lesson3_6.gif)

## Выводы

Мне удалось настроить окружение `Unity`, выполнить все задания. Я подружился с документацией `Unity`, в конорой нашел много интересных функций и методов. А ещё я научился заполнять `Readme` на `github`

| Plugin | README |
| ------ | ------ |
| Dropbox | [plugins/dropbox/README.md][PlDb] |
| GitHub | [plugins/github/README.md][PlGh] |
| Google Drive | [plugins/googledrive/README.md][PlGd] |
| OneDrive | [plugins/onedrive/README.md][PlOd] |
| Medium | [plugins/medium/README.md][PlMe] |
| Google Analytics | [plugins/googleanalytics/README.md][PlGa] |

## Powered by

**BigDigital Team: Denisov | Fadeev | Panov**
