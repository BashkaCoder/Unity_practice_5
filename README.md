# Reflection and Extension 🤯
## Task#3:
### Цели:
* Создать собственный атрибут для Unity редактора.
* Реализовать кастомный PropertyDrawer для настройки поведения свойств.
* Научиться управлять компонентами через атрибуты в инспекторе.

### Что сделал
1. Создал атрибут Rigidbody2DTypeAttribute:
   * Атрибут применяется к полям типа `Rigidbody2D` и автоматически задает тип тела (_**Dynamic, Kinematic, Static**_).
   * Реализовал конструктор атрибута, который принимает параметр `RigidbodyType2D` для указания нужного типа тела.
2. Создал кастомный PropertyDrawer:
   * Реализовал логику отображения полей с применением атрибута `Rigidbody2DType`.
   * Проверил, что поле может быть применено только к компоненту `Rigidbody2D`.
   * Добавил сообщение об ошибке, если атрибут применен к неправильному типу данных.
3. Создал пример использования атрибута:
   * В компоненте `Rigidbody2DAttributeExample` использовал атрибут для нескольких полей `Rigidbody2D`, задавая разные типы тел (**_Dynamic, Kinematic, Static_**).
   * Компонент автоматически находит `Rigidbody2D` в дочерних объектах и применяет к ним настройки.

### Выполнение
* [Rigidbody2DTypeAttribute.cs](https://github.com/BashkaCoder/Unity_practice_5/blob/Task3/Assets/Scripts/Rigidbody2DTypeAttribute.cs)
* [Rigidbody2DTypeDrawer.cs](https://github.com/BashkaCoder/Unity_practice_5/blob/Task3/Assets/Editor/Rigidbody2DTypeDrawer.cs)
* [Rigidbody2DAttributeExample.cs](https://github.com/BashkaCoder/Unity_practice_5/blob/Task3/Assets/Scripts/Rigidbody2DAttributeExample.cs)

### Как протестировать
1. Создать объект в сцене и добавть на него компонент `Rigidbody2DAttributeExample`.
2. Убедиться, что в инспекторе объекты с `Rigidbody2D` имеют разные типы тел (**_Dynamic, Kinematic, Static_**), как указано в атрибутах.
3. Проверить сообщение об ошибке при применении атрибута к неподдерживаемому типу.

### В чем я преисполнился
* Создавать атрибуты для улучшения взаимодействия с инспектором Unity.
* Реализовывать кастомные `PropertyDrawer` для управления компонентами через атрибуты.
* Проверять корректность применений атрибутов и показывать сообщения об ошибках.