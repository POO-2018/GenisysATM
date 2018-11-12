USE GenisysATM_V2
GO;

CREATE PROCEDURE sp_ActualizarSaldoCuenta (
	@cuenta CHAR(14),
	@debito DECIMAL(12,2)
)
AS
BEGIN
	UPDATE ATM.CuentaCliente
	SET saldo = saldo - @debito
	WHERE numero = @cuenta
END
GO;

CREATE PROCEDURE sp_ActualizarPin (
	@cuenta CHAR(14),
	@pinActual CHAR(4),
	@pinNuevo CHAR(4)
)
AS
BEGIN
	DECLARE @cuentaExiste INT
	SET @cuentaExiste = (SELECT COUNT(*)
					    FROM ATM.CuentaCliente
						WHERE numero = @cuenta)

	IF (@cuentaExiste > 0)
	BEGIN
		DECLARE @pinValido INT
		SET @pinValido = (SELECT COUNT(*)
						  FROM ATM.CuentaCliente
						  WHERE numero = @cuenta
						  AND pin = @pinActual)

		IF (@pinValido > 0)
		BEGIN
			UPDATE ATM.CuentaCliente
			SET pin = @pinNuevo
			WHERE numero = @cuenta
		END
	END
END