USE [PROYEECTO ASP.NET]
GO

/****** Object:  StoredProcedure [dbo].[Registrar_Usuario]    Script Date: 14/08/2023 17:40:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Registrar_Usuario]

@Nombre varchar(100),
@Apellido varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@Activo bit,
@Mensaje varchar(500) output,
@Resultado int output
as
begin
	set @Resultado = 0
	if not exists(select *from USUARIO where Correo=@Correo)
	begin
	insert into USUARIO(Nombre,Apellido,Clave,Correo,Activo)
	values(@Nombre,@Apellido,@Clave,@Correo,@Activo)
	
	set @Resultado=SCOPE_IDENTITY()
	end
	else 
	set @Mensaje='El correo del usuario ya existe'
end
GO

