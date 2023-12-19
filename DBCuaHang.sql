use CuaHangXachTay

alter table tblMatHang
add constraint FK_MatHang_LoaiHang foreign key (sMaLoaiHang) references tblLoaiHang (sMaLoaiHang)

alter table tblCTDB
add constraint PK_MaHang_MaDonBan primary key (sMaHang,sMaDonBan),
    constraint FK_DonBan_CTDB foreign key (sMaDonBan) references tblDonBan (sMaDonBan),
	constraint FK_MatHang_CTDB foreign key (sMaHang) references tblMatHang (sMaHang)

alter table tblCTDB
add constraint FK_LoaiHang_CTDB foreign key (sMaLoaiHang) references tblLoaiHang (sMaLoaiHang)

alter table tblCTDN
add constraint FK_LoaiHang_CTDN foreign key (sMaLoaiHang) references tblLoaiHang (sMaLoaiHang)

alter table tblCTDN
add constraint PK_MaHang_MaDonNhap primary key (sMaHang,sMaDonNhap),
    constraint FK_DonNhap_CTDN foreign key (sMaDonNhap) references tblDonNhap (sMaDonNhap),
	constraint FK_MatHang_CTDN foreign key (sMaHang) references tblMatHang (sMaHang)

alter table tblDangNhap
add constraint FK_TenDangNhap foreign key (sTenDangNhap) references tblDangKi (sTenDangNhap)

create proc Tao_Tai_Khoan
@TenDangNhap nvarchar(20),@AdMin nvarchar(50),@MatKhau nvarchar(20),@XacNhanMK nvarchar(20)
as
begin
 insert into tblDangKi values(@TenDangNhap,@AdMin,@MatKhau,@XacNhanMK)
end

-- Loại hàng
-- Thêm
create proc ThemLoaiHang
@MaLoaiHang nvarchar(20), @TenLoaiHang nvarchar(100)
as
begin
 insert into tblLoaiHang values(@MaLoaiHang,@TenLoaiHang)
end

-- Sửa
create proc SuaLoaiHang
@MaLoaiHang nvarchar(20), @TenLoaiHang nvarchar(100)
as
begin
 update tblLoaiHang
 set sTenLoaiHang = @TenLoaiHang 
 where sMaLoaiHang = @MaLoaiHang
end

--Xoá
create proc XoaLoaiHang
@MaLoaiHang nvarchar(20)
as
begin
 delete from tblLoaiHang where sMaLoaiHang = @MaLoaiHang
end

-- Mặt hàng
-- Thêm
alter proc ThemMatHang
@MaHang nvarchar(20),@TenHang nvarchar(100),@MaLoaiHang nvarchar(20),@GiaBan float,@GiaNhap float
as
begin
insert into tblMatHang values(@MaHang,@TenHang,@MaLoaiHang,@GiaNhap,@GiaBan)
end

-- Sửa
create proc SuaMatHang
@MaHang nvarchar(20),@TenHang nvarchar(100),@GiaBan float,@GiaNhap float
as
begin 
 update tblMatHang 
 set sTenHang=@TenHang,fGiaBan=@GiaBan,fGiaNhap=@GiaNhap
 where sMaHang=@MaHang
end

-- Xoá
create proc XoaMatHang
@MaHang nvarchar(20)
as
begin 
 delete from tblMatHang where sMaHang=@MaHang
end

-- Đơn bán
-- Thêm
create proc ThemDonBan
@MaDonBan nvarchar(20),@NgayLapHD datetime,@TenKhachHang nvarchar(100)
as
begin
 insert into tblDonBan values(@MaDonBan,@NgayLapHD,@TenKhachHang)
end

-- Sửa
create proc SuaDonBan
@MaDonBan nvarchar(20),@NgayLapHD datetime,@TenKhachHang nvarchar(100)
as
begin
 update tblDonBan
 set dNgayban=@NgayLapHD,sTenKhachHang=@TenKhachHang
 where sMaDonBan=@MaDonBan
end

-- Xoá
create proc XoaDonBan
@MaDonBan nvarchar(20)
as
begin 
 delete from tblDonBan where sMaDonBan=@MaDonBan
end

-- Chi tiết Đơn bán
-- Thêm
create proc ThemCTDB
@MaDonBan nvarchar(20),@MaHang nvarchar(20),@MaLoaiHang nvarchar(20),@GiaBan float,@SoLuong int,@GhiChu nvarchar(150)
as
begin 
 insert into tblCTDB values(@MaDonBan,@MaHang,@MaLoaiHang,@GiaBan,@SoLuong,@GhiChu)
end

--Sửa
create proc SuaCTDB
@MaDonBan nvarchar(20),@MaHang nvarchar(20),@GiaBan float,@SoLuong int,@GhiChu nvarchar(150)
as
begin
 update tblCTDB
 set fGiaban=@GiaBan,iSoLuong=@SoLuong,sGhiChu=@GhiChu
 where sMaDonBan=@MaDonBan and sMaHang=@MaHang
end

--Xoá
create proc XoaCTDB
@MaDonBan nvarchar(20),@MaHang nvarchar(20)
as
begin
 delete from tblCTDB where sMaDonBan=@MaDonBan and sMaHang=@MaHang
end

-- Đơn nhập
-- Thêm
create proc ThemDonNhap
@MaDonNhap nvarchar(20),@NgayLapHD datetime,@TenNguoiNhap nvarchar(100)
as
begin
 insert into tblDonNhap values(@MaDonNhap,@NgayLapHD,@TenNguoiNhap)
end

-- Sửa
create proc SuaDonNhap
@MaDonNhap nvarchar(20),@NgayLapHD datetime,@TenNguoiNhap nvarchar(100)
as
begin
 update tblDonNhap
 set dNgayNhap=@NgayLapHD,sNguoiNhap=@TenNguoiNhap
 where sMaDonNhap=@MaDonNhap
end

-- Xoá
create proc XoaDonNhap
@MaDonNhap nvarchar(20)
as
begin 
 delete from tblDonNhap where sMaDonNhap=@MaDonNhap
end

-- Chi tiết Đơn nhập
-- Thêm
alter proc ThemCTDN
@MaDonNhap nvarchar(20),@MaHang nvarchar(20),@MaLoaiHang nvarchar(20),@GiaNhap float,@SoLuong int,@GhiChu nvarchar(150)
as
begin 
 insert into tblCTDN values(@MaDonNhap,@MaHang,@MaLoaiHang,@GiaNhap,@SoLuong,@GhiChu)
end

--Sửa
create proc SuaCTDN
@MaDonNhap nvarchar(20),@MaHang nvarchar(20),@GiaNhap float,@SoLuong int,@GhiChu nvarchar(150)
as
begin
 update tblCTDN
 set fGiaNhap=@GiaNhap,iSoLuong=@SoLuong,sGhiChu=@GhiChu
 where sMaDonNhap=@MaDonNhap and sMaHang=@MaHang
end

--Xoá
create proc XoaCTDN
@MaDonNhap nvarchar(20),@MaHang nvarchar(20)
as
begin
 delete from tblCTDN where sMaDonNhap=@MaDonNhap and sMaHang=@MaHang
end

-- Tìm kiếm theo loại hàng
alter proc TimKiemTheoLoaiHang
@MaLoaiHang nvarchar(20)
as
begin
 select sTenLoaiHang[Loại hàng],sTenHang[Mặt hàng],fGiaBan[Giá bán]
 from tblMatHang,tblLoaiHang
 where tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang and tblLoaiHang.sMaLoaiHang=@MaLoaiHang
end


-- Nháp
select * from tblDangKi
select * from tblLoaiHang

select * from tblMatHang

delete from tblDangKi where sTenDangNhap='nghyqn12'

select sTenLoaiHang,sTenHang,fGiaBan,fGiaNhap 
from tblMatHang,tblLoaiHang 
where tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang and sTenLoaiHang= N'Chống muỗi'

select sum(iSoLuong*fGiaban) from tblCTDB where sMaDonBan='HD1'


select sMaDonBan[Mã đơn bán],sTenHang[Mặt hàng],sTenLoaiHang[Loại hàng],tblCTDB.fGiaban[Giá bán],iSoLuong[Số lượng],sGhiChu[Ghi chú] 
from tblCTDB,tblMatHang,tblLoaiHang
where tblCTDB.sMaHang=tblMatHang.sMaHang and tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang and tblLoaiHang.sMaLoaiHang=tblCTDB.sMaLoaiHang

select sMaDonNhap[Mã đơn nhập],sTenHang[Mặt hàng],sTenLoaiHang[Loại hàng],tblCTDN.fGiaNhap[Giá bán],iSoLuong[Số lượng],sGhiChu[Ghi chú]
from tblCTDN,tblMatHang,tblLoaiHang
where tblCTDN.sMaHang=tblMatHang.sMaHang and tblLoaiHang.sMaLoaiHang=tblMatHang.sMaLoaiHang and tblLoaiHang.sMaLoaiHang=tblCTDN.sMaLoaiHang and sMaDonNhap=