# HomeFinance

Данное приложение по учету домашних финансов разработано в учебных целях.

## ТЗ
1. Возможность просматривать\добавлять\удалять\редактировать категории операций (доходов и расходов). Нельзя создать категории с одинаковыми именами.
2. Возможность просматривать\добавлять\удалять\редактировать операции.
3. Возможность посмотреть операции и сумму расходов\доходов за день.
4. Возможность посмотреть операции и сумму расходов\доходов за выбранный период.

## Стэк
Приложение построено с использованием onion-архитектуры.
### DB
MS SQL Server

### WebApi
.Net 5 + EF Core + Swagger + AutoMapper
### UI
.Net 5 + Blazor Server
### Deploy 
Azure

https://homefinanceui.azurewebsites.net/ - UI

https://homefinanceapi.azurewebsites.net/index.html - Api


## Локальный запуск
1. Прописать ConnectionString в файле appsettings.json проекта HomeFinance.Api.
2. Прописать ApiUrl в файле appsettings.json проекта HomeFinance.UI (если был изменен стандартный applicationUrl проекта HomeFinance.Api).
