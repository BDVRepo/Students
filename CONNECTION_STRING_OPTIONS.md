# Варианты строк подключения к SQL Server

Если текущая строка подключения не работает, попробуйте один из вариантов ниже.

## Текущая настройка (в App.config)
```
Data Source=localhost\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;
```

## Альтернативные варианты

### Вариант 1: SQL Server Express с SQL Authentication
Если используется SQL Server Express с логином sa:
```xml
Data Source=localhost\SQLEXPRESS;Initial Catalog=students;User ID=sa;Password=MSSQL;
```

### Вариант 2: SQL Server по умолчанию (MSSQLSERVER)
Если установлен SQL Server без именованного экземпляра:
```xml
Data Source=localhost;Initial Catalog=students;Integrated Security=True;
```
или
```xml
Data Source=.;Initial Catalog=students;Integrated Security=True;
```

### Вариант 3: SQL Server по умолчанию с SQL Authentication
```xml
Data Source=localhost;Initial Catalog=students;User ID=sa;Password=MSSQL;
```

### Вариант 4: Имя компьютера
Замените ИМЯ_КОМПЬЮТЕРА на реальное имя вашего компьютера:
```xml
Data Source=ИМЯ_КОМПЬЮТЕРА\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;
```

### Вариант 5: TCP/IP подключение
```xml
Data Source=localhost,1433;Initial Catalog=students;Integrated Security=True;
```

### Вариант 6: LocalDB (для тестирования без SQL Server)
```xml
Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=students;Integrated Security=True;
```

## Как определить правильную строку подключения

1. Откройте **SQL Server Management Studio (SSMS)**
2. Попробуйте подключиться к серверу
3. Обратите внимание на строку подключения в диалоге подключения
4. Скопируйте параметры в App.config

## Как проверить службы SQL Server

1. Нажмите `Win + R`
2. Введите `services.msc` и нажмите Enter
3. Найдите службы:
   - **SQL Server (MSSQLSERVER)** - для экземпляра по умолчанию
   - **SQL Server (SQLEXPRESS)** - для Express версии
4. Убедитесь, что служба **Запущена** (Running)
5. Если не запущена - щелкните правой кнопкой → **Запустить**

## Где изменить строку подключения

1. Откройте файл `Students/App.config`
2. Найдите секцию `<connectionStrings>`
3. Измените значение `connectionString` на один из вариантов выше
4. Сохраните файл
5. Пересоберите проект (Build → Rebuild Solution)
6. Запустите приложение снова

