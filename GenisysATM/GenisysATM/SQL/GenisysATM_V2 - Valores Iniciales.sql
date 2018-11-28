-- Valores iniciales para el funcionamiento del ATM
USE GenisysATM_V2
GO;

INSERT INTO ATM.Configuracion (appKey, valor, descripcion)
VALUES ('MONTOMAXIMODOLARES', '200', 'L�mite m�ximo para retiros en d�lares'),
       ('MONTOMAXIMOLEMPIRAS', '4000', 'L�mite m�ximo para retiros en lempiras'),
	   ('TASACAMBIODOLARES', '24.25', 'Tasa de cambio lempira/dolar para las transacciones'),
	   ('INTENTOSPIN', '4', 'N�meros de intentos m�ximos para ingresar un PIN err�neo');
GO

INSERT INTO ATM.Cliente (nombres, apellidos, identidad, direccion, celular)
VALUES ('John', 'Connor', '012345678910', 'Colonia La Resistencia', '9999-9999')
GO

INSERT INTO ATM.CuentaCliente (numero, idCliente, saldo,pin)
VALUES ('012345678910', 100, 15000, '1234')
GO