use Lab01
create table MatHang
(
tenHang varchar(20) primary key,
loai varchar(20),
donGia int
)

create table DonHang(
id int identity(1,1) primary key,
tenKH varchar(20),
tenHang varchar(20),
soLuong int,
donGia int,
thanhTien as ( soLuong * donGia )
)
insert into DonHang values
('Quang', 'Rau Muong ', 3, 5000)

insert into MatHang values
('Rau Muong ', 'Rau', 5000),
('Rau Mong Toi ', 'Rau', 4000),
('Rau Cai', 'Rau', 6000),
('Rau Bau', 'Rau', 8000),
('Tao Do', 'Tao', 15000),
('Tao Xanh', 'Tao', 20000),
('Tao Han Quoc', 'Tao', 50000),
('Tao Viet Nam', 'Tao', 30000)

select loai from MatHang group by loai
select ROW_NUMBER() over (order by tenHang ) as STT, tenHang as 'Ten Hang', donGia as 'Don Gia' from MatHang where loai = 'Tao'
select ROW_NUMBER() over (order by tenHang) as STT, tenHang as 'Ten Hang', soLuong as 'So Luong', donGia as 'Don Gia', thanhTien as 'Thanh Tien' from DonHang
where tenKH = 'Quang'

delete from DonHang where tenHang = 'Rau Muong '