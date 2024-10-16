# Требования к проекту "Сервис продажи авиабилетов"

В проекте предусмотрены два типа пользователей: `покупатель` и `администратор`. Пользователь, не авторизованный в системе, имеет право просмотра всех доступных рейсов и авиабилетов. Авторизованный пользователь может бронировать и приобретать авиабилеты, а также просматривать историю своих покупок. Администратор имеет право добавлять, изменять и удалять информацию о рейсах и билетах.

---

## Требуемая функциональность:

1. **Регистрация пользователя:** Основная ссылка для перехода на форму регистрации доступна неавторизованному пользователю на любой странице, а также отображается при попытке забронировать или приобрести билет. Форма   регистрации содержит поля ввода имени пользователя, электронной почты и пароля. Учетная запись создаётся после подтверждения электронной почты.

2. **Авторизация и деавторизация пользователя:** Основная ссылка для перехода на форму входа доступна неавторизованному пользователю на любой странице, а также отображается при попытке забронировать или приобрести билет. При входе в систему требуется ввести адрес электронной почты и пароль. Для выхода из системы авторизованный пользователь должен нажать на соответствующую ссылку на любой странице.

3. **(INDEX) Просмотр списка рейсов:** Проект позволяет искать рейсы по разным критериям, таким как место отправления, место прибытия, дата вылета, время в пути, стоимость и авиакомпания. Доступен фильтр по всем этим параметрам.

4. **(CREATE) Создание рейса:** Администратор может добавить новый рейс, заполнив поля: номер рейса, авиакомпания, место отправления, место прибытия, дата и время вылета и прибытия, стоимость билета, количество доступных мест.

5. **(READ) Просмотр деталей рейса:** Любой пользователь может просматривать подробную информацию о выбранном рейсе, включая описание маршрута, авиакомпании, доступные места и стоимость билета.

6. **(UPDATE) Редактирование рейса:** Администратор может изменить информацию о любом рейсе, включая его дату, время, стоимость и количество доступных мест.

7. **(DELETE) Удаление рейса:** Администратор имеет право удалить любой рейс.

---

## Дополнительные функции:

1. **Покупка билета:** Покупатель может выбрать рейс и приобрести билет, после чего он появляется в его личном кабинете в истории покупок.
 
2. **Просмотр истории покупок:** Авторизованный пользователь имеет возможность просматривать список ранее приобретенных билетов с деталями о каждом рейсе.

3. **Бронирование билета:** Покупатель может предварительно забронировать билет и оплатить его позже.

---

## Проектная база:

![image](https://github.com/user-attachments/assets/972c704e-cbf9-45b1-9de2-03ad8dcdcca4)

