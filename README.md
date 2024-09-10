# Reflection and Extension 🤯
## Task#1:
### Цели:
* Научиться создавать кастомные инспекторы для компонентов Unity.
* Использовать рефлексию для изменения private полей и методов. 
* Упростить изменение визуальных параметров объекта через редактор.

### Что сделал
1. Создал компонент SquareColorPicker:
   * Добавил private поле для хранения цвета.
   * Компонент изменяет цвет SpriteRenderer на объекте при запуске.
2. Создал кастомный инспектор SquareColorPickerEditor:
   * Использовал атрибут `CustomEditor`, чтобы создать кастомный инспектор для компонента `SquareColorPicker`. 
   * Добавил поля для редактирования значений цвета (RGB). 
   * Использовал рефлексию для доступа к private полю `_color` и его изменения через инспектор. 
   * Добавил кнопку для рандомизации цвета с помощью класса `Random`.
3. Использовал рефлексию:
   * Применил методы рефлексии, чтобы получить доступ к private полю цвета `_color`. 
   * Использовал флаги - `BindingFlags.Instance | BindingFlags.NonPublic`, чтобы найти закрытые поля.
   
### Выполнение
* [SquareColorPicker.cs](https://github.com/BashkaCoder/Unity_practice_5/blob/Task1/Assets/Scripts/SquareColorPicker.cs)
* [SquareColorPickerEditor.cs](https://github.com/BashkaCoder/Unity_practice_5/blob/Task1/Assets/Editor/SquareColorPickerEditor.cs)

### Как протестировать
1. Добавить компонент `SquareColorPicker` на объект в сцене. 
2. В редакторе Unity через кастомный инспектор изменить цвет объекта - поля RGB, ColorPicker или с помощью кнопки рандомизации цвета.

### В чем я преисполнился
* Создавать кастомные инспекторы для компонентов Unity. 
* Использовать рефлексию для изменения private полей. 
* Упрощать процесс настройки объектов через Unity Editor.