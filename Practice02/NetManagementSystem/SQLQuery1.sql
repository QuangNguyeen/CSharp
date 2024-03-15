create database NET
use NET
create table ManagementComputer
(
Name varchar(10),
timeCheckIn int check( timeCheckIn <= 24),
timeCheckOut int check(timeCheckOut <= 24),
primary key (Name, timeCheckIn, timeCheckOut),
numberHour as (timeCheckOut - timeCheckIn),
unitPrice varchar(15),
totalMoney int
)
alter table ManagementComputer add primary key (Name, timeCheckIn, timeCheckOut)
insert into ManagementComputer values('Computer 2', 8, 10, '5000/h', 10000)
select ROW_NUMBER() over (order by Name) as STT, * from ManagementComputer
drop table ManagementComputer