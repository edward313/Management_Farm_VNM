CREATE PROC insertAccount
					(
						@MaTK nvarchar(50),
						@MK nvarchar(200), 
						@role nvarchar(25)
					
						
					)
AS
BEGIN	
	INSERT INTO dbo.Acccount VALUES (@MaTK,@MK, @role)
END

 CREATE PROC UpdateAccount
					(
						@MaTK nvarchar(50),
						@MK nvarchar(200), 
						@role nvarchar(25)
						)
						
AS 
BEGIN 
UPDATE dbo.Acccount
SET  Mk = @MK , role=@role 
WHERE MaTk = @MaTK
END



Create PROCEDURE check_login_role (

@matk nvarchar(50),
@mk nvarchar(50)
)
AS
Begin 
	if exists (select MaTk from Acccount where MaTk = @matk and mk = @mk and role = 'Admin')
		begin 
			select 1 logged
		end 
	else if exists (select MaTk from Acccount where MaTk = @matk and mk = @mk )
		begin 
			select 2 logged
		end 
	
	else
		begin 
			select 0 logged
		end
end
go





Create PROC [dbo].[insertNT]
					(
						@MaNT nvarchar(50),
						@TenNT nvarchar(200), 
						@ChuSoHuu nvarchar(200),
						@diachi nvarchar(200),
						@SDT nvarchar(11),
						@MaTK nvarchar(50)
						
					)
AS
BEGIN	
	INSERT INTO dbo.NongTrai VALUES (@MaNT, @TenNT,@ChuSoHuu, @diachi,@SDT,@MaTK)
END

CREATE PROC DS_HoaDon
as 
	select * 
	from dbo.HoaDon
go


CREATE PROC ChiTietDonHang
					(
						@MaHoaDon nvarchar(50)
					)
AS
BEGIN	
	Select * from dbo.ChiTietHoaDon where MaHoaDon = @MaHoaDon
END



--------------------NhanVien-----------------------

CREATE PROC DS_NhanVien
as 
	select * 
	from dbo.NhanVien
go

CREATE PROC InsertNV
(
						@MaNV nvarchar(50),
						@TenNV nvarchar(200), 
						@Sodienthoai nvarchar(200),
						@GioiTinh nvarchar(200),
						@NgaySinh datetime
						


)
AS
BEGIN	
	INSERT INTO dbo.NhanVien VALUES (@MaNV, @TenNV,@SoDienthoai, @GioiTinh,@NgaySinh)
END

CREATE PROC UpdateNV
(
						@MaNV nvarchar(50),
						@TenNV nvarchar(200), 
						@Sodienthoai nvarchar(200),
						@GioiTinh nvarchar(200),
						@NgaySinh datetime
						


)
AS
BEGIN	
	UPDATE dbo.NhanVien
	SET  TenNV = @TenNV ,  SoDienThoai = @Sodienthoai , GioiTinh = @GioiTinh,Ngaysinh=@NgaySinh

	WHERE MaNV = @MaNV
END

CREATE PROC deleteNV(
				@MaNV nvarchar(50)

) AS 
BEGIN DELETE FROM dbo.NhanVien where MaNV = @MaNV
END

ALTER TABLE NhanVien
ADD CONSTRAINT nhanvien_pk PRIMARY KEY (MaNV)

ALTER TABLE NhanVien alter column MaNV nvarchar(50) NOT NULL

---------------------SanPham--------------------------------------------

CREATE PROC InsertSP
(
						@MaSP nvarchar(50),
						@TenSP nvarchar(200), 
						@Gia int,
						@SoLuong int,
						@DungTich int

)
AS
BEGIN	
	INSERT INTO dbo.SanPham VALUES (@MaSP, @TenSP,@Gia, @SoLuong,@DungTich)
END

CREATE PROC UpdateSP
(
						@MaSP nvarchar(50),
						@TenSP nvarchar(200), 
						@Gia int,
						@SoLuong int,
						@DungTich int
						


)
AS
BEGIN	
	UPDATE dbo.SanPham
	SET  TenSanPham = @TenSP , Gia = @Gia , SoLuong = @SoLuong ,Dungtich=@DungTich

	WHERE MaSp = @MaSP
END

CREATE PROC deleteSP(
				@MaSP nvarchar(50)

) AS 
BEGIN DELETE FROM dbo.SanPham where MaSp = @MaSP
END

----------------------------TrangTrai------------------------

  delete from NHAPHANPHOI where MaNPP != '1'

  delete from NongTrai where MaNT != '1'

   delete from ChiTietHoaDon where MaHoadon != '1'
   delete from HoaDon where MaHoadon != '1'

----------------------------NPP-----------------------------------------

 ALTER TABLE NHAPHANPHOI
ADD CONSTRAINT fk_nt_npp
 FOREIGN KEY (Matk)
 REFERENCES Acccount (Matk);

  ALTER TABLE NongTrai
ADD CONSTRAINT fk_nt_npp
 FOREIGN KEY (Matk)
 REFERENCES Acccount (Matk);

  ALTER TABLE NHAPHANPHOI
ADD CONSTRAINT fk_nt_npp
 FOREIGN KEY (Matk)
 REFERENCES Acccount (Matk);


   ALTER TABLE HoaDon
ADD CONSTRAINT fk_nt_npp
 FOREIGN KEY (MaNPP)
 REFERENCES NHAPHANPHOI (MaNPP);

     ALTER TABLE HoaDon
ADD CONSTRAINT fk_hd_nt
 FOREIGN KEY (MaNongTrai)
 REFERENCES NongTrai (MaNT);