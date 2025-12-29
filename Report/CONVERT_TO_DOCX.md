# Инструкция по конвертации отчета в DOCX

## Способ 1: Использование Pandoc (рекомендуется)

1. Установите Pandoc: https://pandoc.org/installing.html

2. Выполните команду:
```bash
pandoc LabReport.md -o LabReport.docx --reference-doc=reference.docx
```

Или без reference документа:
```bash
pandoc LabReport.md -o LabReport.docx
```

## Способ 2: Использование онлайн-конвертеров

1. Откройте файл `LabReport.md` в текстовом редакторе
2. Скопируйте содержимое
3. Используйте один из онлайн-конвертеров:
   - https://www.markdowntopdf.com/
   - https://dillinger.io/
   - https://stackedit.io/

## Способ 3: Использование Microsoft Word

1. Откройте Microsoft Word
2. Файл → Открыть → выберите `LabReport.md`
3. Word автоматически конвертирует Markdown в формат документа
4. Сохраните как `.docx`

## Способ 4: Ручное копирование

1. Откройте `LabReport.md` в текстовом редакторе
2. Откройте Microsoft Word
3. Скопируйте содержимое из Markdown в Word
4. Отформатируйте согласно требованиям:
   - Шрифт: Times New Roman, 12pt
   - Поля: левое 30мм, правое 15мм, верхнее/нижнее 20мм
   - Абзацный отступ: 1.25см
   - Нумерация страниц (кроме титульного)
5. Вставьте экранные копии в места, указанные в тексте

