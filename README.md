# Reflection and Extension 🤯
## Task#2:
### Цели:
* Создать кастомное окно в Unity, которое открывается через тулбар.
* Реализовать функционал для получения GUID по ассету и наоборот — искать ассет по его GUID.

### Что сделал
1. Создал окно AssetToGUID:
   * Добавил окно, которое можно открыть через тулбар(`MenuItem`).
   * Реализовал функционал drag-and-drop: пользователь может перетащить ассет в окно, чтобы получить его **_InstanceID_**.
   * Отобразил **_InstanceID_** перетянутых объектов в интерфейсе.
2. Создал окно GUIDToAsset:
    * Добавил второе окно для поиска объектов по их **_InstanceID_**.
    * Реализовал ввод текста для **_InstanceID_** и кнопку для поиска.
    * Если объект найден, он отображается в интерфейсе окна. Если объект с таким ID не существует — выводится сообщение об ошибке.
3. Работа с идентификаторами:
    * Использовал методы `EditorUtility.InstanceIDToObject()` для поиска объектов по их **_InstanceID_**.
    * Организовал работу drag-and-drop системы с помощью событий `EventType.DragUpdated` и `EventType.DragPerform`.

### Выполнение
* [AssetToGUIDWindow.cs](https://github.com/BashkaCoder/Unity_practice_5/blob/Task2/Assets/Editor/AssetToGUIDWindow.cs)
* [GUIDToAssetWindow.cs](https://github.com/BashkaCoder/Unity_practice_5/blob/Task2/Assets/Editor/GUIDToAssetWindow.cs)

### Как протестировать
1. Открыть окно `AssetToGUID` через тулбар (меню Utils).
2. Перетащить ассет в окно и проверить отображение **_InstanceID_**.
3. Открыл окно `GUIDToAsset` через тулбар (меню Utils).
4. Ввести `InstanceID` и проверить найденный объект.

### В чем я преисполнился
* Создавать кастомные окна в Unity Editor.
* Получать **_InstanceID_** объектов и искать по нему объекты в Unity.
* Обрабатывать drag-and-drop для окон редактора.