-- Valores iniciales para el funcionamiento del ATM
USE GenisysATM_V2
GO;

INSERT INTO ATM.Configuracion (appKey, valor)
VALUES ('MONTOMAXIMODOLARES', '200'),
       ('MONTOMAXIMOLEMPIRAS', '4000'),
	   ('TASACAMBIODOLARES', '24.25'),
	   ('INTENTOSPIN', '4');
GO

INSERT INTO ATM.Cliente (nombres, apellidos, identidad, direccion, celular)
VALUES ('John', 'Connor', '012345678910', 'Colonia La Resistencia', '9999-9999')
GO

INSERT INTO ATM.CuentaCliente (numero, idCliente, saldo,pin)
VALUES ('012345678910', 100, 15000, '1234')
GO