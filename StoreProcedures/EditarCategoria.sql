
 Create procedure [dbo].[EditarCategoria]
@Descripcion varchar(50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(50) output,
@IdCategoria int
as
begin
	if not exists(select * from CATEGORIA c where c.Descripcion=@Descripcion and c.IdCategoria!=@IdCategoria)
	begin
	set @Resultado=1
	update top(1) CATEGORIA set Descripcion= @Descripcion,  Estado=@Estado
	where IdCategoria=@IdCategoria
	end
	else
	begin
	set @Resultado =0
	set @Mensaje = 'No se puede repetir la categoria de un producto'
	end
end