
--Insertar datos a la tabla Owner
insert into Owners ( Name, Address, Birthday) values ('Diego Tamayo Calle','Cr 41 # 45-83, Envigado, Antioquia','19890312')
insert into Owners ( Name, Address, Birthday) values ('Vanessa Jaramillo','Cl 13 # 64-31, Medellin, Antioquia','19900101')
insert into Owners ( Name, Address, Birthday) values ('Delfina Londoño','Dg 33 # 21-70, Itagui, Antioquia','19420831')

--Insertar propiedades
insert into Propertyes (  Name, Address, Price, CodeInternal, Year, ownerIdOwner) 
			values ('Casa en Venta, Camino verde','Urbanizacion Camino Verde, Envigado, Anmtioquia',670000000,9001,2021,10001)
insert into Propertyes ( Name, Address, Price, CodeInternal, Year, ownerIdOwner) 
			values ('Casa en Venta, SAN CRISTOBAL','Tv 32 # 45-38, Medellin, Anmtioquia',720000000,9002,2022,10002)
insert into Propertyes ( Name, Address, Price, CodeInternal, Year, ownerIdOwner) 
			values ('Casa en Venta, Itagui Naranjos','Dg 33 # 21-70, Itagui, Antioquia',240000000,9003,2022,10003)


--insertar imagenes
insert into PropertyImages (Ruta, Enabled, propertyIdProperty) 
									values ('https://metrocuadrado.blob.core.windows.net/inmuebles/13117-M3475266/13117-M3475266_11_h.jpg',1,2001)
insert into PropertyImages (Ruta, Enabled, propertyIdProperty) 
									values ('https://metrocuadrado.blob.core.windows.net/inmuebles/13117-M3052792/13117-M3052792_29_h.jpg',1,2002)
insert into PropertyImages (Ruta, Enabled, propertyIdProperty) 
									values ('https://metrocuadrado.blob.core.windows.net/inmuebles/11224-M3423781/11224-M3423781_69_h.jpg',1,2003)
