 DROP DATABASE DB_TGS;

/* Criar o banco de dados */
CREATE DATABASE DB_TGS;

/* Usar o banco correto */
USE DB_TGS;

/* Criar tabela de procedimentos */
CREATE TABLE TB_PROCEDURES (
	ID_PROCEDURE INT PRIMARY KEY IDENTITY NOT NULL,
	PROCEDURE_TITLE VARCHAR(20) UNIQUE
);

/* Criar tabela de pacientes */
CREATE TABLE TB_PATIENTS (
	CPF_PATIENT VARCHAR(14) PRIMARY KEY NOT NULL,
	RG_PATIENT VARCHAR(12) UNIQUE NOT NULL,
	NAME_PATIENT VARCHAR(20),
	LAST_NAME VARCHAR(40),
	NICKNAME VARCHAR(20),
	BIRTH_DATE DATE,
	HEIGHT VARCHAR(4),
	WEIGHT_PATIENT VARCHAR(6),
	EMAIL VARCHAR(40),
	TELEPHONE VARCHAR(13),
	CELLPHONE VARCHAR(14),
	STREET VARCHAR(50),
	NEIGHBORHOOD VARCHAR(20),
	CITY VARCHAR(30),
	DISTRICT VARCHAR(20),
	CEP VARCHAR(10),
	COMPLEMENT VARCHAR(15),
	NUMBER INT
);

/* Criar a tabela de dentistas */
CREATE TABLE TB_DENTISTS (
	CRO_DENTIST VARCHAR(6) PRIMARY KEY NOT NULL,
	NAME_DENTIST VARCHAR(20),
	LAST_NAME VARCHAR(40),
	EXPERTISE VARCHAR(15)
);

/* Criar tabela de funcionários */
CREATE TABLE TB_EMPLOYEES (
	CPF_EMPLOYEE VARCHAR(14) PRIMARY KEY NOT NULL,
	NAME_EMPLOYEE VARCHAR(20),
	LAST_NAME VARCHAR(40),
	EMAIL VARCHAR(40),
	TELEPHONE VARCHAR(13),
	CELLPHONE VARCHAR(14),
	PASSWORD_EMPLOYEE VARCHAR(255)
);

/* Criar tabela de consultas */
CREATE TABLE TB_CONSULTS(
	ID_CONSULT INT PRIMARY KEY IDENTITY NOT NULL,
	CPF_PATIENT VARCHAR(14),
	CRO_DENTIST VARCHAR(6),
	DATE_CONSULT DATE,
	TIME_CONSULT TIME,
	ID_PROCEDURE INT,
	STATUS_SCHEDULE BIT,
	CPF_EMPLOYEE VARCHAR(14)

	CONSTRAINT FK_PATIENT
	FOREIGN KEY (CPF_PATIENT)
	REFERENCES TB_PATIENTS (CPF_PATIENT)
	ON DELETE SET NULL
	ON UPDATE CASCADE,

	CONSTRAINT FK_DENTIST
	FOREIGN KEY (CRO_DENTIST)
	REFERENCES TB_DENTISTS (CRO_DENTIST)
	ON DELETE SET NULL
	ON UPDATE CASCADE,

	CONSTRAINT FK_PROCEDURE
	FOREIGN KEY (ID_PROCEDURE)
	REFERENCES TB_PROCEDURES (ID_PROCEDURE)
	ON DELETE SET NULL
	ON UPDATE CASCADE,

	CONSTRAINT FK_EMPLOYEE
	FOREIGN KEY (CPF_EMPLOYEE)
	REFERENCES TB_EMPLOYEES (CPF_EMPLOYEE)
	ON DELETE SET NULL
	ON UPDATE CASCADE,
);


INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('AVALIACAO');
INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('CONSULTA');
INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('CIRURGIA');
INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('CANAL');

INSERT INTO TB_EMPLOYEES (CPF_EMPLOYEE, NAME_EMPLOYEE, LAST_NAME, EMAIL, TELEPHONE, CELLPHONE, PASSWORD_EMPLOYEE) VALUES ('803.047.456-75', 'MIRIAM', 'ZEQUINI', 'MIRIAMZEQUINI@YAHOO.COM', '(19)3875-0023', '(19)93546-7512', 'WELCOME123');
INSERT INTO TB_EMPLOYEES (CPF_EMPLOYEE, NAME_EMPLOYEE, LAST_NAME, EMAIL, TELEPHONE, CELLPHONE, PASSWORD_EMPLOYEE) VALUES ('485.654.458-48', 'MURILO', 'SCHALI', 'MURILO123@GMAIL.COM', '', '(19)97252-3013', '1234');
INSERT INTO TB_EMPLOYEES (CPF_EMPLOYEE, NAME_EMPLOYEE, LAST_NAME, EMAIL, TELEPHONE, CELLPHONE, PASSWORD_EMPLOYEE) VALUES ('000.000.000-00', 'Admin', '', 'admin@admin.com', '', '', '21232f297a57a5a743894a0e4a801fc3');

INSERT INTO TB_DENTISTS (CRO_DENTIST, NAME_DENTIST, LAST_NAME, EXPERTISE) VALUES ('10.154', 'FERNANDO', 'NAKAMURA', 'CIRURGIAO');
INSERT INTO TB_DENTISTS (CRO_DENTIST, NAME_DENTIST, LAST_NAME, EXPERTISE) VALUES ('20.300', 'LETICIA', 'SABATELA', 'CANAL');

INSERT INTO TB_PATIENTS (CPF_PATIENT, RG_PATIENT, NAME_PATIENT, LAST_NAME, NICKNAME, BIRTH_DATE, HEIGHT, WEIGHT_PATIENT, EMAIL, TELEPHONE, CELLPHONE, STREET, NEIGHBORHOOD, CITY, DISTRICT, CEP, COMPLEMENT, NUMBER) VALUES ('123.456.789-10', '88.758.333-1', 'GIANLUCA', 'MICHELI', 'COMILAO', '12/06/1950', '1.78', '75.5', 'GIANLUCA@GMAIL.COM', '(19)1234-5698', '(19)91234-5698', 'RUA DAS FLORES', 'ITAICI', 'INDAIATUBA', 'SP', '13.330-000', '', 10);
INSERT INTO TB_PATIENTS (CPF_PATIENT, RG_PATIENT, NAME_PATIENT, LAST_NAME, NICKNAME, BIRTH_DATE, HEIGHT, WEIGHT_PATIENT, EMAIL, TELEPHONE, CELLPHONE, STREET, NEIGHBORHOOD, CITY, DISTRICT, CEP, COMPLEMENT, NUMBER) VALUES ('123.456.789-11', '88.758.333-2', 'CAIQUE', 'PATELLI', '', '08/04/2003', 1.72, 75.5, 'CAIQUE@GMAIL.COM', '(19)4434-5698', '(19)94434-5698', 'RUA BRASIL', 'SANTA ELISA', 'ITUPEVA', 'SP', '13.330-000', '', 1547);

INSERT INTO TB_CONSULTS (CRO_DENTIST, DATE_CONSULT, TIME_CONSULT, STATUS_SCHEDULE) VALUES ('10.154', '2021-09-21', '08:00', 0);
INSERT INTO TB_CONSULTS (CRO_DENTIST, DATE_CONSULT, TIME_CONSULT, STATUS_SCHEDULE) VALUES ('10.154', '2021-09-21', '09:00', 0);
INSERT INTO TB_CONSULTS (CRO_DENTIST, DATE_CONSULT, TIME_CONSULT, STATUS_SCHEDULE) VALUES ('10.154', '2021-09-21', '10:00', 0);

UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 1, CPF_EMPLOYEE = '000.000.000-00', CPF_PATIENT = '123.456.789-10', ID_PROCEDURE = 1 WHERE TB_CONSULTS.ID_CONSULT = 1;

SELECT * FROM TB_CONSULTS;
SELECT * FROM TB_PATIENTS WHERE CPF_PATIENT = '123.456.789-10';
SELECT * FROM TB_EMPLOYEES;
SELECT * FROM TB_PROCEDURES ORDER BY ID_PROCEDURE;
SELECT * FROM TB_DENTISTS;
SELECT COUNT(ID_PROCEDURE) AS TOTAL FROM TB_PROCEDURES;

UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 0, CPF_EMPLOYEE = '000.000.000-00', CPF_PATIENT = null, ID_PROCEDURE = null WHERE ID_CONSULT = 2;
UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 1, CPF_EMPLOYEE = '000.000.000-00', CPF_PATIENT = '123.456.789-10', ID_PROCEDURE = 1 WHERE DATE_CONSULT = '2021-09-21' AND TIME_CONSULT = '09:00:00';

SELECT C.ID_CONSULT, C.DATE_CONSULT, C.TIME_CONSULT, D.NAME_DENTIST, D.LAST_NAME AS LAST_NAME_DENTIST, C.STATUS_SCHEDULE, P.NAME_PATIENT, P.LAST_NAME AS LAST_NAME_PATIENT, P.NICKNAME, PR.PROCEDURE_TITLE FROM TB_DENTISTS AS D, TB_CONSULTS AS C, TB_PATIENTS AS P, TB_PROCEDURES AS PR 
WHERE C.STATUS_SCHEDULE = 1 AND C.CRO_DENTIST = D.CRO_DENTIST AND C.CPF_PATIENT = P.CPF_PATIENT AND C.ID_PROCEDURE = PR.ID_PROCEDURE 
ORDER BY C.TIME_CONSULT;

SELECT C.ID_CONSULT, C.DATE_CONSULT, C.TIME_CONSULT, D.NAME_DENTIST, D.LAST_NAME AS LAST_NAME_DENTIST, C.STATUS_SCHEDULE FROM TB_DENTISTS AS D, TB_CONSULTS AS C 
WHERE C.STATUS_SCHEDULE = 0 AND C.CRO_DENTIST = D.CRO_DENTIST
ORDER BY C.ID_CONSULT;

DELETE FROM TB_CONSULTS;

DELETE FROM TB_PROCEDURES WHERE ID_PROCEDURE = 1;
UPDATE TB_CONSULTS SET STATUS_SCHEDULE = 0, CPF_EMPLOYEE = NULL, CPF_PATIENT = NULL, ID_PROCEDURE = NULL WHERE ID_CONSULT = 1;