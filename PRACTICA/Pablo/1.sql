SELECT Cliente.clie_codigo, Cliente.clie_razon_social
FROM Cliente
WHERE Cliente.clie_limite_credito >= 1000
ORDER BY Cliente.clie_codigo;