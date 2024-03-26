create database TH08
use TH08
create table DonHang
(id int identity(1,1) primary key,
tenKhach varchar(100),
tenHang varchar(100),
soLuong int,
donGia int,
thanhTien as (soLuong * donGia)
)

insert into DonHang values
('Nguyen Van Quang', 'Chocopie', 2, 55000)
delete from DonHang where tenHang = 'Chocopie'
select ROW_NUMBER() over (order by tenHang) as STT, tenHang, soLuong, donGia, thanhTien from DonHang
