create database Lab01
use Lab01
create table Sach
(
maSach varchar(10) primary key,
tenSach varchar(100)
)
create table BillSach
(
tenSV varchar(10) primary key,
tenSach varchar(100),
ngayMuon date,
ngayTra date,
thanhTien int
)

insert into Sach values
('J97', 'Lap trinh Java')

insert into BillSach values
('Quang', 'Java', '4/11/2024', '5/21/2024', 0)

delete BillSach
update BillSach
set ngayTra = '5/19/2024', thanhTien = 10000
where tenSV = 'Quang'
select ROW_NUMBER() over (order by tenSV) as STT, * from BillSach